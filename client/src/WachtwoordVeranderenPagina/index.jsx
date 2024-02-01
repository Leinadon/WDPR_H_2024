import React, { useState, useEffect, useRef, useContext } from "react";
import { Button, CheckBox, Img, Input, Text } from "components";
import { msalInstance } from "index";
import { useNavigate, Link, useLocation } from "react-router-dom";
import { loginRequest } from "../msalConfig";
import { UnauthenticatedTemplate, useMsal, MsalProvider } from '@azure/msal-react';

// import jwt from 'jsonwebtoken';
import axios from 'axios';
import axiosAPI from '../api/axios';
import AuthContext from "../AuthProvider";
import { useAuth } from "../AuthProvider";
const LOGIN_URL = 'https://localhost:7258/api/identityUser/login';


const LogInPaginaPage = () => {
  const navigate = useNavigate();
  const location = useLocation();
  const from = location.state?.from?.pathname || "/";

  const [data, setData] = useState();
  const { logout, login, auth } = useContext(AuthContext);
  // const { auth, login, logout } = useAuth();

  const userRef = useRef();
  const errRef = useRef(null);

  const [username, setUsername] = useState('');
  const [errorMsg, setErrormMsg] = useState('');
  const [email, setEmail] = useState('');
  
  const [password, setPassword] = useState('');
  const [passwordValid, setPasswordValid] = useState(false);
  const [passwordFocus, setPasswordFocus] = useState(false);

  const [confirmPassword, setConfirmPassword] = useState('');
  const [confirmValid, setConfirmValid] = useState(false);
  const [confirmFocus, setConfirmFocus] = useState(false);

  const handleLogin = async (e) => {
    e.preventDefault();
  }
    const resetPassword = async () => {
      if (password !== confirmPassword) {
        alert('Nieuw wachtwoord en herhaal nieuw wachtwoord komen niet overeen.');
        return;
      }
  
      try {
        const response = await axios.post("https://localhost:7258/api/identityUser/reset",
          JSON.stringify({ email, password, confirmPassword, }),
          {
            headers: { 'Content-Type': 'application/json' },
            withCredentials: true
          }
        );
  
        if (response.ok) {
          alert('Wachtwoord succesvol verandert!');
        } else {
          const result = await response.json();
          alert(`Wachtwoord verandering mislukt: ${result}`);
        }
      } catch (error) {
        console.error('Error verandering wachtwoord:', error);
      }
    };

  return (
    <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
      <div className="flex flex-col justify-start max-w-[1440px] mb-[108px] mx-auto w-full">
        <div className="flex flex-col items-center justify-start w-full">
          <div className="flex flex-row font-jockeyone md:gap-10 gap-[885px] h-[104px] md:h-auto items-center justify-start max-w-[1368px] md:pl-10 sm:pl-5 pl-[121px] pr-2.5 py-2.5 w-full">
            <Text
              className="md:text-5xl text-6xl text-teal-400 items-left ml-[-50px]"
              size="txtJockeyOneRegular60"
            >
              Verander
            </Text>
            <Img
              className="md:h-auto h-full items-right object-cover ml-[ 8px] max-w-[104px]"
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
          Wachtwoord veranderen
        </Text>
        <Text
          className="flex flex-col items-left justify-left ml-[410px] mt-[20px] text-4xl sm:text-[32px] md:text-[34px] text-white-A700"
          size="txtInterSemiBold20"
          style={{ fontSize: '20px' }}
        >
          Verander je wachtwoord hier!
        </Text>

        <div className="flex flex-col justify-center font-inter w-[600px] ml-[400px] mt-[35px] ">
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Email
              </Text>
            </div>
            <Input
              name="email"
              placeholder="Email"
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
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Nieuw wachtwoord
              </Text>
            </div>
            <Input
              name="passwordField"
              type="password" 
              required
              placeholder="Nieuw wachtwoord"
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              id="password"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: '20px' }}  
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Nogmaals nieuw wachtwoord
              </Text>
            </div>
            <Input
              name="confirmpasswordField"
              id="confirmPassword"
              type="password"
              placeholder="Nieuw wachtwoord"
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: '20px' }}
              value={confirmPassword}
              onChange={(e) => setConfirmPassword(e.target.value)}
            ></Input>

            <p ref={errRef} className={errorMsg ? "errmsg" : "offscreen"} aria-live="assertive">{errorMsg}</p>

            <div>
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] mt-[100px] mr-3 text-center text-xl w-[600px]"
                type="submit"
                shape="round"
                color="teal_400"
                size="lg"
                variant="fill"
                onClick={resetPassword}
              > Opslaan
              </Button>
            </div>
          <div>
            <Button
              className="cursor-pointer font-black h-14 leading-[normal] mt-[80px] mr-3 text-center text-xl w-[600px]"
              shape="round"
              color="blue_gray_100_01"
              size="lg"
              variant="fill"
              onClick={() => navigate("/profielpagina")}
            > Annuleren
            </Button>
          </div>
        </div>
      </div>
    </div >

  );
};

export default LogInPaginaPage;
