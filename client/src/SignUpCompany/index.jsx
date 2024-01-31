import React, { useState, useEffect, useRef } from "react";
import { faCheck, faTimes, faInfoCircle } from "@fortawesome/free-solid-svg-icons";

import axios from '../api/axios';

import { useNavigate } from "react-router-dom";

import { Button, CheckBox, Img, Input, Text } from "components";

const USER_REGEX = /^[A-z][A-z0-9-_]{3,23}$/;
const PWD_REGEX = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%]).{8,24}$/;

const SignUpPaginaPage = () => {
  const navigate = useNavigate();
  const [name, setName] = useState('');
  const [sector, setSector] = useState('');
  const [url, setUrl] = useState('');
  const [email, setEmail] = useState('');

  const [username, setUsername] = useState('');
  const [userValid, setUserValid] = useState(false);
  const [userFocus, setUserFocus] = useState(false);
  const userRef = useRef();

  const [password, setPassword] = useState('');
  const [passwordValid, setPasswordValid] = useState(false);
  const [passwordFocus, setPasswordFocus] = useState(false);

  const [confirmPassword, setConfirmPassword] = useState('');
  const [confirmValid, setConfirmValid] = useState(false);
  const [confirmFocus, setConfirmFocus] = useState(false);

  const [errorMessage, setErrorMsg] = useState('');
  const errorRef = useRef();

  const [listWithCompanies, setData] = useState([]);


  const fetchData = async () => {
    try {
      const response = await fetch('https://localhost:7258/api/companies');
      const result = await response.json();

      setData(result);
    } catch (error) {
      console.error('Error fetching data:', error);
    }
  };

  useEffect(() => {
    fetchData();
  }, []);

  const handleSubmit = async (e) => {
    e.preventDefault();
  
    try {
      const response = await axios.post(
        "https://localhost:7258/api/companies/registreer",
        {
          name: name,
          sector: sector,
          websiteURL: url,
          contactEmail: email
        },
        {
          headers: { 'Content-Type': 'application/json' },
          withCredentials: true
        }
      );
  
    } catch (err) {
      if (!err?.response) {
        setErrorMsg('No Server Response');
      } else if (err.response?.status === 409) {
        setErrorMsg('Conflict: Duplicate Entry');
      } else {
        setErrorMsg('Registration Failed');
      }
      errorRef.current.focus();
    }
  }
  
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
          <h1
            className="flex flex-col items-left justify-left ml-[430px] mt-[49px] text-4xl sm:text-[32px] md:text-[34px] text-white-A700"
            size="txtJockeyOneRegular36"
          >
            Nieuw bij Stichting Accessibility!
          </h1>
          <p className="flex flex-col items-left justify-left ml-[430px] mt-[10px] text-xl sm:text-[18px] md:text-[20px] text-white-A700" size="txtJockeyOneRegular36">
            Maak een account aan en laat je website testen op toegankelijkheid.
          </p>

          <h2
            className="flex flex-col items-left justify-left ml-[430px] mt-[49px] text-4xl sm:text-[32px] md:text-[34px] text-white-A700"
            size="txtJockeyOneRegular36"
          >
            Bedrijfsgegevens
          </h2>
          <div className="flex flex-col justify-center font-inter w-[600px] ml-[420px] mt-[35px] ">
            <p ref={errorRef} className={errorMessage ? "errmsg" : "offscreen"} aria-live="assertive" size="txtJockeyOneRegular36">
              {errorMessage}
            </p>

            <form onSubmit={handleSubmit}>
              <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-5 p-2.5 mb-1.5 w-[500px] sm:w-full">
                <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                  Naam van het bedrijf
                  <span className="text-red-900 text-4xl" size="txtInterBlack20">
                    *
                  </span>
                </Text>
              </div>
              <Input
                name="companyName"
                placeholder=""
                className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
                wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
                shape="round"
                color="deep_orange_50"
                variant="fill"
                style={{ fontSize: '20px' }}
                required
                value={name}
                onChange={(e) => setName(e.target.value)}
              ></Input>
              <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
                <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                  Sector
                </Text>
              </div>
              <Input
                name="sector"
                placeholder=""
                className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
                wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
                shape="round"
                color="deep_orange_50"
                variant="fill"

                style={{ fontSize: '20px' }}
                value={sector}
                onChange={(e) => setSector(e.target.value)}
              ></Input>

              <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
                <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                  Link naar de website
                  <span className="text-red-900 text-4xl" size="txtInterBlack20">
                    *
                  </span>
                </Text>
              </div>
              <Input
                name="url"
                placeholder=""
                className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
                wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]" //wrapClassName="flex h-[54px] ml-6 md:ml-[0] mt-[0] w-[100%]"
                shape="round"
                color="deep_orange_50"
                variant="fill"
                style={{ fontSize: '20px' }}
                required
                value={url}
                onChange={(e) => setUrl(e.target.value)}
              ></Input>
              <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
                <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                  Email*
                </Text>
              </div>
              <Input
                name="email"
                placeholder=""
                className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
                wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
                shape="round"
                color="deep_orange_50"
                variant="fill"
                style={{ fontSize: '20px' }}
                required
                value={email}
                onChange={(e) => setEmail(e.target.value)}
              ></Input>
              <div className="border rounded mt-[80px] bg-blue_gray-100_02 w-full  h-96 mb-8 overflow-y-auto">
                <ul className="">
                  {listWithCompanies.map(companies => (
                    <li key={companies.companyId}>
                      <div key={companies.companyId} className="border rounded p-4 m-4 max-w-m">
                        <h3 className="text-lg font-semibold mb-2"> Bedrijf: {companies.name}</h3>
                        <div className="max-h-32 overflow-y-auto">
                          <p>Link: {companies.websiteURL}</p>
                          <p>Email: {companies.contactEmail}</p>
                        </div>
                      </div>
                      <br/>
                    </li>
                  ))}
                </ul>
              </div>
              <div>
                <Button
                  className="cursor-pointer font-black h-14 leading-[normal] mt-[113px] mr-3 text-center text-xl w-[600px] "
                  shape="round"
                  color="teal_400"
                  size="lg"
                  variant="fill"
                > Registreer
                </Button>
              </div>
            </form>

            <div
              className="common-pointer flex flex-col h-[39px] md:h-auto items-center ml-[32px] justify-center p-2.5 w-[446px] sm:w-full"
              onClick={() => navigate("/login")}>
            </div>
          </div>
        </div>
      </div >
    </>
  );
};

export default SignUpPaginaPage;
