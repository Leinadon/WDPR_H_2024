import React, { useState, useEffect } from "react";

import { useAuth } from '../AuthProvider';

import { useNavigate } from "react-router-dom";

import { Button, Img, Text } from "components";

const HomePaginaPage = () => {
  const navigate = useNavigate();
  const { auth, logout, user } = useAuth();
  const [roles, setRoles] = useState();
  const handleLogout = () => {
    logout();
    console.log("logging out");
  };
  const getRoles = () => {
    try {
      const stored = localStorage.getItem('roles');
      return stored ? JSON.parse(stored) : null;
    } catch (error) {
      console.error('Error parsing stored data:', error);
      return null;
    }
  };

  useEffect(() => {
    // Check if the user is already logged in when the app loads
    const storedRoles = getRoles();
    if (storedRoles) {
      setRoles(storedRoles);
    }
  }, []);


  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col items-center justify-start mx-auto p-[47px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col font-jockeyone h-[65px] md:h-auto items-center justify-center max-w-[1336px] mt-[7px] mx-auto py-2.5 w-full">
          <Text
            className="md:text-3xl sm:text-[28px] text-[32px] text-center text-white-A700"
            size="txtJockeyOneRegular32"
          >
            Accessibility
          </Text>
        </div>
        <div className="flex flex-col h-[269px] md:h-auto items-center justify-center max-w-[836px] mt-7 p-2.5 w-full">
          <Img
            className="md:h-auto max-h-full object-cover max-w-full"
            src="images/img_Logo.png"
            alt="Accessibility Logo"
          />
        </div>


        {user ? (
          <div>

            <div className="flex flex-col font-jockeyone h-[70px] md:h-auto items-center justify-center max-w-[1336px] mt-7 mx-auto py-2.5 w-full">
              <Text
                className="text-4xl sm:text-[32px] md:text-[34px] text-center text-white-A700"
                size="txtJockeyOneRegular36"
              >
                Hallo, {user.userName}!
              </Text>
              <Text
                className="text-4xl sm:text-[32px] md:text-[34px] text-center text-white-A700"
                size="txtJockeyOneRegular36"
              >
                Je beschikt over de volgende rollen: {roles}.
              </Text>
            </div>
            <Button
              className="common-pointer cursor-pointer font-black font-inter h-14 leading-[normal] max-w-[682px] mt-[34px] text-center text-xl w-full"
              onClick={handleLogout}
              shape="round"
              color="teal_400"
              size="lg"
              variant="fill"
            >
              Uitloggen
            </Button>
          </div>
        ) : (

          <div>

            <div className="flex flex-col font-jockeyone h-[70px] md:h-auto items-center justify-center max-w-[1336px] mt-7 mx-auto py-2.5 w-full">
              <Text
                className="text-4xl sm:text-[32px] md:text-[34px] text-center text-white-A700"
                size="txtJockeyOneRegular36"
              >
                Welkom op het testpanel Accessibility!
              </Text>
            </div>
            <div className="flex flex-col font-inter h-[78px] md:h-auto items-center justify-center max-w-[1346px] mt-[33px] mx-auto py-2.5 w-full">
              <Text
                className="text-2xl md:text-[22px] text-center text-white-A700 sm:text-xl"
                size="txtInterMedium24"
              >
                Onze ervaringsdeskundigen staan klaar om uw website te testen.
              </Text>
            </div>
            <Button
              className="common-pointer cursor-pointer font-black font-inter h-14 leading-[normal] max-w-[682px] mt-[34px] text-center text-xl w-full"
              onClick={() => navigate("/login")}
              shape="round"
              color="teal_400"
              size="lg"
              variant="fill"
            >
              Login
            </Button>
            <Button
              className="common-pointer cursor-pointer font-black font-inter h-14 leading-[normal] max-w-[682px] my-[57px] text-center text-xl w-full"
              onClick={() => navigate("/signup")}
              shape="round"
              color="teal_400"
              size="lg"
              variant="fill"
            >
              Sign Up
            </Button>

          </div>
        )}


      </div>
    </>
  );
};

export default HomePaginaPage;
