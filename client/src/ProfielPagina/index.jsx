import { useNavigate } from "react-router-dom";

import { Button, CheckBox, Img, Input, Text } from "components";

import React, { useState, useEffect } from "react";

import axios from "axios";

import { msalInstance } from "index";

import Links from "Links";

const ProfielPaginaPage = () => {
  const [jsonData, setJsonData] = useState({});
  const navigate = useNavigate();
  const [firstName, setFirstName] = useState('', jsonData.firstName);
  const [lastName, setLastName] = useState('');
  const [birthdate, setBirthdate] = useState('');
  const [phone, setPhone] = useState('');
  const [postalCode, setPostalCode] = useState('');
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const stylePointer = {cursor: 'pointer', textDecoration: 'underline'};
  const [resources, setResources] = useState('');
  const [voogdColor, setVoogdColor] = useState('#CCCCCC');
  const [voogdText, setVoogdText] = useState('Ik heb geen Voogd');      
  const LinkProfielPagina = new Links.LinkProfielPagina();
  const LinkErvaring = new LinkProfielPagina.LinkErvaring();
  const handleButtonClickVoogd = () => {
    const newColor = voogdColor === '#CCCCCC' ? '#1ca883' : '#CCCCCC';
    const newText = voogdColor === '#CCCCCC' ? 'Ik heb een Voogd' : 'Ik heb geen Voogd';
    setVoogdColor(newColor);
    setVoogdText(newText);
  };

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get(LinkErvaring.Link);
        const data = await response.data;
        setJsonData(data);
      } catch (error) {
        console.error('Error fetching JSON data:', error);
        console.log('Server Response:', error.response); // Log the response for more details
      }
    };

    fetchData();
  }, []); // Run once on component mount

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
                Aanpassen
              </Text>
              <Img
                className="md:h-auto h-full items-right object-cover ml-[-20px] max-w-[104px]"
                src="images/img_Logo.png"
                alt="Accessibility Logo"
                onClick={() => navigate("/menupagina")}
              />
            </div>
          </div>
          <Text
            className="flex flex-col items-left justify-left ml-[410px] mt-[49px] text-4xl sm:text-[32px] md:text-[34px] text-white-A700"
            size="txtJockeyOneRegular36"
          >
            Pas hier je gegevens aan
          </Text>
          <div className="flex flex-col justify-center font-inter w-[600px] ml-[400px] mt-[35px] ">
            <div className="flex flex-col h-11 md:h-auto items-left justify-start  mr-5 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                <div>
                  <h1>Voornaam</h1>
                </div>
              </Text>
            </div>
            <div>
              <Input
                type="text"
                onChange={ (e) => setFirstName(e.target.value)}
                name="rectanglethree"
                placeholder=""
                className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
                wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
                shape="round"
                color="deep_orange_50"
                variant="fill"
                value={jsonData.firstName}
                style={{ fontSize: "20px", color: 'black' }}
              ></Input>
            </div>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Achternaam
              </Text>
            </div>
            <Input  
              name="rectangleseven"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              value={jsonData.lastName}
              style={{ fontSize: "20px" }}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Geboortedatum
              </Text>
            </div>
            <Input
              name="rectanglefour"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              value={jsonData.birthDate}
              style={{ fontSize: "20px" }}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Telefoonnummer
              </Text>
            </div>
            <Input
              name="rectanglefive"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]" //wrapClassName="flex h-[54px] ml-6 md:ml-[0] mt-[0] w-[100%]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              value={jsonData.phone}
              style={{ fontSize: "20px" }}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Postcode
              </Text>
            </div>
            <Input
              name="rectanglesix"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: '20px' }}
              type="text"
              value={postalCode}
              onChange={ (e) => setPostalCode(e.target.value)}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Gebruikersnaam
              </Text>
            </div>
            <Input
              name="rectanglesix"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              value={jsonData.userName}
              style={{ fontSize: "20px" }}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 mt-3 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Type Beperking
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[] mt-[16px] w-[24%] md:w-full">
              <CheckBox
                className="my-0.5"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectanglefiveon"
                id="rectanglefiveon"
                shape="round"
                color="blue_gray_100"
                variant="fill"
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
                className="mb-1"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectangleFive_Three"
                id="rectangleFive_Three"
              ></CheckBox>
              <Text
                className="text-center text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Zintuigelijk
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[] mt-[22px] w-[29%] md:w-full">
              <CheckBox
                className="mb-1"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectanglefiveth"
                id="rectanglefiveth"
                shape="round"
                color="blue_gray_100"
                variant="fill"
              ></CheckBox>
              <Text
                className="text-center text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Cognitief
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[] mt-[22px] w-[29%] md:w-full">
              <CheckBox
                className="mb-1"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectangleFive_Three"
                id="rectangleFive_Three"
              ></CheckBox>
              <Text
                className="text-center text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Neurologisch
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[] mt-[25px] w-[37%] md:w-full">
              <CheckBox
                className="mb-1"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectanglefivefi"
                id="rectanglefivefi"
                shape="round"
                color="blue_gray_100"
                variant="fill"
              ></CheckBox>
              <Text
                className="text-center text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Ontwikkeling
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
              style={{ backgroundColor: voogdColor}}
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
                name="rectanglesix"
                placeholder=""
                className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
                wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
                shape="round"
                color="deep_orange_50"
                variant="fill"
                style={{ fontSize: "20px" }}
                type="text"
                value={resources}
                onChange={ (e) => setResources(e.target.value)}
              ></Input>
            </div>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 mt-[30px] p-2.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20" onClick={() => navigate("/wachtwoordveranderenpagina")} style={stylePointer}>
                Wachtwoord veranderen? Klik hier!
              </Text>
            </div>
            <div>
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] mt-[70px] mr-3 text-center text-xl w-[600px]"
                shape="round"
                color="teal_400"
                size="lg"
                variant="fill"
              >
                {" "}
                Opslaan
              </Button>
            </div>
            <div>
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] mt-[80px] text-center text-xl w-[600px]"
                shape="round"
                color="blue_gray_100_01"
                size="lg"
                variant="fill"
                onClick={() => navigate("/profielervaringsdeskundigepagina")}
              >
                {" "}
                Annuleren
              </Button>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default ProfielPaginaPage;
