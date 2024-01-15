import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, Img, Text } from "../components";


const HomePaginaPage = () => {
  const navigate = useNavigate();

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col items-center justify-start mx-auto p-[47px] md:px-10 sm:px-5 w-full background">
        <div className="flex flex-col font-jockeyone h-[65px] md:h-auto items-center justify-center max-w-[1336px] mt-[7px] mx-auto py-2.5 w-full">
          <Text
            className="md:text-3xl sm:text-[28px] text-[32px] text-center text-white-A700"
            size="txtJockeyOneRegular32"
            as= "div"
          >
            Accessibility
          </Text>
        </div>
        <div className="flex flex-col h-[269px] md:h-auto items-center justify-center max-w-[250px] mt-7 p-2.5 w-full">
          <Img
            className="md:h-auto h-full object-cover w-full"
            src="images\img_logo.png"
            alt="Accesibility logo"
          />
        </div>
        <div className="flex flex-col font-jockeyone h-[70px] md:h-auto items-center justify-center max-w-[1336px] mt-7 mx-auto py-2.5 w-full">
          <Text
            className="text-4xl sm:text-[32px] md:text-[34px] text-center text-white-A700"
            size="txtJockeyOneRegular36"
            as= "div"
          >
            Hallo, Welkom !
          </Text>
        </div>
        <div className="flex flex-col font-inter h-[78px] md:h-auto items-center justify-center max-w-[1346px] mt-[33px] mx-auto py-2.5 w-full">
          <Text
            className="text-2xl md:text-[22px] text-center text-white-A700 sm:text-xl"
            size="txtInterMedium24"
            as= "div"
          >
            Welkom bij de testpanel Accessibility
          </Text>
        </div>
        <Button
          className="common-pointer cursor-pointer font-black font-inter h-14 leading-[normal] max-w-[682px] mt-[34px] text-center text-xl w-full"
          onClick={() => navigate("/login")}
          shape="round"
          color="teal_400"
          variant="fill"
          leftIcon
          rightIcon
          size="md"
        >
          Login
        </Button>
        <Button
          className="common-pointer cursor-pointer font-black font-inter h-14 leading-[normal] max-w-[682px] my-[57px] text-center text-xl w-full"
          onClick={() => navigate("/signup")}
          shape="round"
          color="teal_400"
          variant="fill"
          leftIcon
          rightIcon
          size="md" 
        >
          Sign Up
        </Button>
      </div>
    </>
  );
};

export default HomePaginaPage;
