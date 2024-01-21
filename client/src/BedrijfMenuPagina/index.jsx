import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, Img, Text } from "components";

const BedrijfMenuPaginaPage = () => {
  const navigate = useNavigate();

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col md:gap-10 gap-[129px] items-center justify-start max-w-[1337px] mb-[216px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-center p-2.5 w-[460px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400"
                size="txtJockeyOneRegular60"
              >
                Bedrijf
              </Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start p-2.5 max-w-[116px]">
              <Img
                className="md:h-auto h-full object-cover w-full"
                src="images/img_Logo.png"
                alt="Logo Accessobility"
              />
            </div>
          </div>
          <div className="flex flex-col font-inter md:gap-10 gap-[74px] items-center justify-start w-[37%] md:w-full">
            <Button
              className="common-pointer cursor-pointer flex h-14 items-center justify-center w-[486px]"
              onClick={() => navigate("/profielpagina")}
              rightIcon={
                <Img
                  className="ml-2.5 max-w-full max-h-full"
                  src="images/img_Profile.png"
                  alt="Profiel Afbeelding"
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
              className="common-pointer cursor-pointer flex h-14 items-center justify-center w-[486px]"
              onClick={() => navigate("/onderzoekpagina")}
              rightIcon={
                <Img
                  className="ml-2.5 max-w-full max-h-full"
                  src="images/img_Research.png"
                  alt="Research afbeelding"
                />
              }
              shape="round"
              color="teal_400"
              size="md"
              variant="fill"
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Opdracht Plaatsen
              </div>
            </Button>
            <Button
              className="common-pointer cursor-pointer flex h-14 items-center justify-center w-[486px]"
              onClick={() => navigate("/ondersteuningpagina")}
              rightIcon={
                <Img
                  className="ml-2.5 max-w-full max-h-full"
                  src="images/img_Research.png"
                  alt="Research afbeelding"
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
              className="common-pointer cursor-pointer flex h-14 items-center justify-center w-[486px]"
              onClick={() => navigate("/chatpagina")}
              rightIcon={
                <Img
                  className="ml-2.5 max-w-full max-h-full"
                  src="images/img_Chat.png"
                  alt="Chat afbeelding"
                />
              }
              shape="round"
              color="teal_400"
              size="sm"
              variant="fill"
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Chats
              </div>
            </Button>
          </div>
        </div>
      </div>
    </>
  );
};

export default BedrijfMenuPaginaPage;
