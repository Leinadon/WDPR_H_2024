import React, { useState } from 'react';

import { useNavigate } from "react-router-dom";

import { Button, Img, Input, Text, TextArea } from "components";

const OndersteuningPaginaPage = () => {
  const navigate = useNavigate();
 
  const returnToPrevious = () => navigate(-1);


  const returnToHomePage = () => {
    navigate("/");
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
              Stichting Accessibility
            </Text>
            <Img
                className="md:h-auto h-full items-right object-cover ml-[-110px] max-w-[104px]"
                src="images/img_Logo.png"
                alt="Logo Accessability"
                onClick={() => navigate("/menupagina")}
              />
          </div>
            </div>
          </div>
          <h1
            className="flex flex-col items-left justify-left w-[600px] mb-[30px] text-4xl sm:text-[32px] md:text-[34px] text-white-A700"
            size="txtJockeyOneRegular36"
          >
            Niet toegestaan
          </h1>
          <div className="flex flex-col font-inter gap-[21px] h-[580px] md:h-auto items-left justify-center mt-[27px] w-[600px] sm:w-full">
            <h2
              className="text-lg text-white-A700 w-auto"
              size="txtInterBlack18"
            >
              Dit deel van de website is niet beschikbaar. Keer terug via de knop hier beneden.
            </h2>
          
            <Button
              className="common-pointer cursor-pointer font-black h-14 leading-[normal] mt-[41px] text-center text-xl w-[600px]"
              onClick={returnToPrevious}
              shape="round"
              color="blue_gray_100_01"
              size="lg"
              variant="fill"
            >
              Ga terug
            </Button>
            <Button
              className="common-pointer cursor-pointer font-black h-14 leading-[normal] mt-[41px] text-center text-xl w-[600px]"
              onClick={returnToHomePage}
              shape="round"
              color="teal_400"
              size="lg"
              variant="fill"
            >
              Naar de homepage
            </Button>
          </div>
        </div>
    </>
  );
};

export default OndersteuningPaginaPage;
