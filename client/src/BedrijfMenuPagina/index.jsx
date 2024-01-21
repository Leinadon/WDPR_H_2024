import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, Img, Text } from "components";

const BedrijfMenuPaginaPage = () => {
  const navigate = useNavigate();

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col justify-start max-w-[1440px] mb-[108px] mx-auto w-full">
          <div className="flex flex-col items-center justify-start w-full">
            <div className="flex flex-row font-jockeyone md:gap-10 gap-[885px] h-[104px] md:h-auto items-center justify-start max-w-[1368px]  md:pl-10 sm:pl-5 pl-[121px] pr-2.5 py-2.5 w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400 items-left ml-[-60px]"
                size="txtJockeyOneRegular60"
              >
                Menu
              </Text>
              <Img
                className="md:h-auto h-full items-right object-cover ml-[100px] max-w-[104px]"
                src="images/img_Logo.png"
                alt="Logo Accessability"
              />
            </div>
          </div>
          <div className="flex flex-col font-inter md:gap-10 gap-[74px] items-center justify-start mb-[228px] md:px-5 w-[100%] md:w-full">
            <Button
              className="common-pointer cursor-pointer flex h-14 items-center justify-center mt-[100px] w-[600px]"
              onClick={() => navigate("/profielbedrijfpagina")}
              rightIcon={
                <Img
                  className="ml-2.5 max-w-full max-h-full"
                  src="images/img_Profile.png"
                  alt="Profiel afbeelding"
                />
              }
              shape="round"
              color="teal_400"
              size="sm"
              variant="fill"
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Profiel
              </div>
            </Button>
            <Button
              className="common-pointer cursor-pointer flex h-14 items-center justify-center w-[600px]"
              onClick={() => navigate("/onderzoekplaatsenbedrijfpagina")}
              rightIcon={
                <Img
                  className="ml-2.5 max-w-full max-h-full"
                  src="images/img_googleforms.png"
                  alt="googleforms"
                />
              }
              shape="round"
              color="teal_400"
              size="sm"
              variant="fill"
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Opdracht Plaatsen
              </div>
            </Button>
            <Button
              className="common-pointer cursor-pointer flex h-14 items-center justify-center w-[600px]"
              onClick={() => navigate("/onderzoekresultatenbedrijfpagina")}
              rightIcon={
                <Img
                  className="ml-2.5 max-w-full max-h-full"
                  src="images/img_barchart2.svg"
                  alt="Barchart afbeelding"
                />
              }
              shape="round"
              color="teal_400"
              size="sm"
              variant="fill"
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Opdracht Resultaten
              </div>
            </Button>
            <Button
              className="common-pointer cursor-pointer flex h-14 items-center justify-center w-[600px]"
              onClick={() => navigate("/chatpagina")}
              rightIcon={
                <Img
                  className="ml-2.5 max-w-full max-h-full"
                  src="images/img_Chat.png"
                  alt="imageTwo_One"
                />
              }
              shape="round"
              color="teal_400"
              size="sm"
              variant="fill"
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Chat
              </div>
            </Button>
          </div>
        </div>
      </div>
    </>
  );
};

export default BedrijfMenuPaginaPage;
