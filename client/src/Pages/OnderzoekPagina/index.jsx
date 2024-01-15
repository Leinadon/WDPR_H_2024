import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, Img, Text } from "components";

const OnderzoekPaginaPage = () => {
  const navigate = useNavigate();

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col items-center justify-start max-w-[1332px] mb-[30px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-start p-2.5 w-[460px] sm:w-full">
              <div className="flex flex-col h-[97px] md:h-auto items-center justify-start p-2.5 w-[450px] sm:w-full">
                <Text
                  className="md:text-5xl text-6xl text-teal-400 w-auto"
                  size="txtJockeyOneRegular60"
                >
                  Onderzoek
                </Text>
              </div>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start p-2.5 w-[116px]">
              <Img
                className="common-pointer md:h-auto h-full object-cover w-full"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
                onClick={() => navigate("/menupagina")}
              />
            </div>
          </div>
          <div className="flex flex-col font-inter items-end justify-start w-[38%] md:w-full">
            <div className="flex flex-col h-11 md:h-auto items-center justify-center p-2.5 w-[496px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Soort onderzoek
              </Text>
            </div>
            <div className="flex sm:flex-col flex-row sm:gap-[46px] items-center justify-between w-[97%] md:w-full">
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] text-base text-center w-[220px]"
                shape="round"
                color="teal_400"
                size="xl"
                variant="fill"
              >
                Vragenlijst
              </Button>
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] text-base text-center w-[220px]"
                shape="round"
                color="teal_400"
                size="xl"
                variant="fill"
              >
                Uitnodigingen
              </Button>
            </div>
            <Button
              className="cursor-pointer font-black h-14 leading-[normal] mr-[276px] mt-[21px] text-base text-center w-[220px]"
              shape="round"
              color="teal_400"
              size="xl"
              variant="fill"
            >
              Online Opdracht
            </Button>
            <div className="flex flex-col h-11 md:h-auto items-center justify-center mt-[17px] p-2.5 w-[496px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Taal
              </Text>
            </div>
            <div className="flex sm:flex-col flex-row sm:gap-[46px] items-center justify-between w-[97%] md:w-full">
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] text-base text-center underline w-[220px]"
                shape="round"
                color="teal_400"
                size="xl"
                variant="fill"
              >
                Nederlands
              </Button>
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] text-base text-center underline w-[220px]"
                shape="round"
                color="teal_400"
                size="xl"
                variant="fill"
              >
                English
              </Button>
            </div>
            <Img
              className="h-[638px] mt-[34px] w-[506px]"
              src="images/img_frame21.svg"
              alt="framefiftyfour"
            />
            <Button
              className="common-pointer cursor-pointer font-black h-14 leading-[normal] mr-2.5 mt-[39px] text-center text-xl w-[486px]"
              onClick={() => navigate("/menupagina")}
              shape="round"
              color="blue_gray_100_01"
              size="lg"
              variant="fill"
            >
              Terug naar Menu
            </Button>
          </div>
        </div>
      </div>
    </>
  );
};

export default OnderzoekPaginaPage;
