import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, Img, Text } from "components";

const OnderzoekPaginaPage = () => {
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
                  Onderzoek
                </Text>
              <Img
                className="md:h-auto h-full object-cover w-[104px] ml-[-100px]"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
                onClick={() => navigate("/menupagina")}
              />
            </div>
          </div>
          <div className="flex flex-col justify-center font-inter w-[600px] ml-[420px] mt-[35px] ">
            <div className="flex flex-col h-11 md:h-auto items-left justify-start  mr-5 p-2.5 mb-1.5 w-[500px] sm:w-full">
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
            <div className="flex flex-col h-11 md:h-auto items-left justify-center mt-[17px] p-2.5 w-[496px] sm:w-full">
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
