import React, { useState, useEffect, useRef, useContext } from "react";
import { useNavigate } from "react-router-dom";
import axiosAPI from "../api/axios";
import { Button, CheckBox, Img, Input, Text } from "components";
import AuthContext from "../AuthProvider";
import { msalInstance } from "index";

const SIGNUP_URL = "https://localhost:3000/signup";

const SignUpPaginaPage = () => {
  const navigate = useNavigate();
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [birthdate, setBirthdate] = useState("");
  const [email, setEmail] = useState("");
  const [phone, setPhone] = useState("");
  const [postalCode, setPostalCode] = useState("");
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [checkboxFysiek, setCheckboxFysiek] = useState(false);
  const [checkboxAuditief, setCheckboxAuditief] = useState(false);
  const [checkboxVisueel, setCheckboxVisueel] = useState(false);
  const [checkboxOntwikkeling, setCheckboxOntwikkeling] = useState(false);
  const [checkboxCognitief, setCheckboxCognitief] = useState(false);
  const [hulpmiddelen, setHulpmiddelen] = useState("");
  const [resources, setResources] = useState("");
  const [voogdColor, setVoogdColor] = useState("#CCCCCC");
  const [voogdText, setVoogdText] = useState("Ik heb geen Voogd");
  const [voogdValue, setVoogdValue] = useState(false);
  const { setAuth } = useContext(AuthContext);
  const userRef = useRef();
  const errRef = useRef();
  const [error, setError] = useState("");
  const [success, setSuccess] = useState("");
  const handleButtonClickVoogd = () => {
    const newColor = voogdColor === "#CCCCCC" ? "#1ca883" : "#CCCCCC";
    const newText = voogdColor === "#CCCCCC" ? "Ik heb een Voogd" : "Ik heb geen Voogd";
    const newValue = voogdColor === "#1ca883";
    setVoogdColor(newColor);
    setVoogdText(newText);
    setVoogdValue(newValue);
  };

  const handleCheckboxChange = (checkboxNumber, setterFunction) => {
    setterFunction((prevValue) => !prevValue);
  };

  const validateFields = () => {
    if (!firstName || !lastName || !birthdate || !email || !phone || !postalCode || !username || !password || !hulpmiddelen) {
      setError('Vul alle velden in.');
      return false;
    }

    if (!(checkboxFysiek || checkboxAuditief || checkboxVisueel || checkboxOntwikkeling || checkboxCognitief)) {
      setError('Vink minimaal 1 checkbox.');
      return false;
    }

    if (!email.includes('@')) {
      setError('Voer een geldig emailadres in.');
      return false;
    }

    setError('');
    return true;
  };

  const handleSignUpAndSaveData = async () => {
    if (validateFields()) {
      try {
        const signUpResponse = await axiosAPI.post(SIGNUP_URL, {
          firstName,
          lastName,
          birthdate,
          email,
          phone,
          postalCode,
          username,
          password,
          checkboxFysiek,
          checkboxAuditief,
          checkboxVisueel,
          checkboxOntwikkeling,
          checkboxCognitief,
          voogdValue,
          hulpmiddelen,
        });

        if (signUpResponse.status === 200) {
          console.log('User signed up successfully!');
          
          const saveDataResponse = await axiosAPI.post('save-data-api-endpoint', {
          });

          if (saveDataResponse.status === 200) {
            console.log('Data saved successfully!');
          } else {
            console.error('Failed to save data');
          }
        } else {
          console.error('Failed to sign up user');
        }
      } catch (error) {
        console.error('Error during signup and data saving:', error);
      }
    }
  };
  
  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col justify-start max-w-[1440px] mb-[108px] mx-auto w-full">
          <div className="flex flex-col items-center justify-start w-full">
            <div className="flex flex-row font-jockeyone md:gap-10 gap-[885px] h-[104px] md:h-auto items-center justify-start max-w-[1368px] md:pl-10 sm:pl-5 pl-[121px] pr-2.5 py-2.5 w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400 items-left ml-[-60px]"
                size="txtJockeyOneRegular60"
              >
                Sign Up
              </Text>
              <Img
                className="md:h-auto h-full items-right object-cover ml-[58px] max-w-[104px]"
                src="images/img_Logo.png"
                alt="Logo Accessibility"
              />
            </div>
          </div>
          <Text
            className="flex flex-col items-left justify-left ml-[430px] mt-[49px] text-4xl sm:text-[32px] md:text-[34px] text-white-A700"
            size="txtJockeyOneRegular36"
          >
            Maak een Account!
          </Text>
          <div className="flex flex-col justify-center font-inter w-[600px] ml-[420px] mt-[35px] ">
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-5 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Voornaam
              </Text>
            </div>
            <Input
              type="text"
              name="firstname"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: "20px" }}
              value={firstName}
              onChange={(e) => setFirstName(e.target.value)}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Achternaam
              </Text>
            </div>
            <Input
              type="text"
              name="lastname"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: "20px" }}
              value={lastName}
              onChange={(e) => setLastName(e.target.value)}
              required
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Geboortedatum
              </Text>
            </div>
            <Input
              type="date"
              name="birthdate"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: "20px" }}
              value={birthdate}
              onChange={(e) => setBirthdate(e.target.value)}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Email
              </Text>
            </div>
            <Input
              type="mail"
              name="email"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: "20px" }}
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Telefoonnummer
              </Text>
            </div>
            <Input
              type="phone"
              name="phone"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]" //wrapClassName="flex h-[54px] ml-6 md:ml-[0] mt-[0] w-[100%]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: "20px" }}
              value={phone}
              onChange={(e) => setPhone(e.target.value)}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Postcode
              </Text>
            </div>
            <Input
              type="postalcode"
              name="postalcode"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: "20px" }}
              value={postalCode}
              onChange={(e) => setPostalCode(e.target.value)}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Gebruikersnaam
              </Text>
            </div>
            <Input
              type="username"
              name="username"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: "20px" }}
              value={username}
              onChange={(e) => setUsername(e.target.value)}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Wachtwoord
              </Text>
            </div>
            <Input
              type="password"
              name="password"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: "20px" }}
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 mt-3 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Type Beperking
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[] mt-[16px] w-[24%] md:w-full">
              <CheckBox
                className="fysiek"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectanglefiveon"
                id="rectanglefiveon"
                shape="round"
                color="blue_gray_100"
                variant="fill"
                type="checkbox"
                checked={checkboxFysiek}
                onChange={() => handleCheckboxChange(1, setCheckboxFysiek)}
              ></CheckBox>
              <Text
                className="text-center text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Fysiek
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[] mt-[22px] w-[29%] md:w-full">
              <CheckBox
                className="auditief"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectangleFive_Three"
                id="rectangleFive_Three"
                shape="round"
                color="blue_gray_100"
                variant="fill"
                type="checkbox"
                checked={checkboxAuditief}
                onChange={() => handleCheckboxChange(2, setCheckboxAuditief)}
              ></CheckBox>
              <Text
                className="text-center text-white-A700 text-xl mt-[-2px]"
                size="txtInterSemiBold20"
              >
                Auditief
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[] mt-[22px] w-[29%] md:w-full">
              <CheckBox
                className="visueel"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectanglefiveth"
                id="rectanglefiveth"
                shape="round"
                color="blue_gray_100"
                variant="fill"
                type="checkbox"
                checked={checkboxVisueel}
                onChange={() => handleCheckboxChange(3, setCheckboxVisueel)}
              ></CheckBox>
              
              <Text
                className="text-center text-white-A700 text-xl mt-[-2px]"
                size="txtInterSemiBold20"
              >
                Visueel
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[] mt-[22px] w-[29%] md:w-full">
              <CheckBox
                className="ontwikkeling"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectanglefiveth"
                id="rectanglefiveth"
                shape="round"
                color="blue_gray_100"
                variant="fill"
                type="checkbox"
                checked={checkboxOntwikkeling}
                onChange={() => handleCheckboxChange(4, setCheckboxOntwikkeling)}
              ></CheckBox>
              <Text
                className="text-center text-white-A700 text-xl mt-[-2px]"
                size="txtInterSemiBold20"
              >
                Ontwikkeling
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[] mt-[25px] w-[100%] md:w-full">
              <CheckBox
                className="cognitief_neurologisch"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectanglefivefi"
                id="rectanglefivefi"
                shape="round"
                color="blue_gray_100"
                variant="fill"
                type="checkbox"
                checked={checkboxCognitief}
                onChange={() => handleCheckboxChange(5, setCheckboxCognitief)}
              ></CheckBox>
              <Text
                className="text-center text-white-A700 text-xl mt-[-2px]"
                size="txtInterSemiBold20"
              >
                Cognitief of neurologisch
              </Text>
            </div>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 mt-3 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Voogd
              </Text>
            </div>
            <Button
              className="cursor-pointer font-black h-[54px] leading-[normal] mr-3 mt-[0] text-center text-xl underline w-[600px]"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="teal_400"
              size="lg"
              variant="fill"
              style={{ backgroundColor: voogdColor }}
              onClick={handleButtonClickVoogd}
            >
              {voogdText}
            </Button>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Hulpmiddelen
              </Text>
            </div>
            <div>
              <Input
                type="hulp"
                name="hulpmiddelen"
                placeholder=""
                className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
                wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
                shape="round"
                color="deep_orange_50"
                variant="fill"
                style={{ fontSize: "20px" }}
                value={hulpmiddelen}
                onChange={(e) => setHulpmiddelen(e.target.value)}
              ></Input>
            </div>
            <Text className="mt-[20px] ml-[6px]">
            {error && <p style={{ color: "red" }}>{error}</p>}
            </Text>
            <div>
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] mt-[113px] mr-3 text-center text-xl w-[600px] "
                shape="round"
                    color="teal_400"
                    size="lg"
                variant="fill"
                onClick={() => handleSignUpAndSaveData()}
              >
                {" "}
                Sign Up
                </Button>
            </div>
            <Button
              className="common-pointer bg-transparent cursor-pointer font-semibold h-[39px] ml-[20px] leading-[normal] ml-3 md:ml-[] mt-[47px] text-3xl sm:text-[26px] md:text-[28px] items-center text-center text-white-A700 w-[600px]"
              onClick={() => navigate("/loginpagina")}
              size="xs"
            ></Button>
            <div
              className="common-pointer flex flex-col h-[39px] md:h-auto items-center ml-[32px] justify-center p-2.5 w-[446px] sm:w-full"
              onClick={() => navigate("/loginpagina")}
            >
              <Text
                className="text-3xl text-right justify-right text-white-A700 w-full"
                size="txtInterSemiBold30"
              >
                <span className="text-white-A700 font-inter font-semibold">
                  Al een account?{" "}
                </span>
                <a
                  href="javascript:"
                  className="text-gray-400 font-inter font-black underline"
                >
                  Log in
                </a>
              </Text>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default SignUpPaginaPage;
