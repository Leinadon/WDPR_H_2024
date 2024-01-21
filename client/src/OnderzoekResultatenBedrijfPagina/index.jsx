import React from "react";

import { Button, Img, Input, Text } from "components";

const OnderzoekResultatenBedrijfPaginaPage = () => {
  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col gap-[17px] items-center justify-start max-w-[1337px] mb-[11px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-center p-2.5 w-[465px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400"
                size="txtJockeyOneRegular60"
              >
                Resultaten
              </Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start p-2.5 w-[116px]">
              <Img
                className="md:h-auto h-full object-cover w-full"
                src="images/img_Logo.png"
                alt="Logo Accessobility"
              />
            </div>
          </div>
          <div className="flex flex-col items-start justify-start w-[37%] md:w-full">
            <Text className="text-white-A700 text-xl" size="txtInterBlack20">
              Soort onderzoek
            </Text>
            <div className="flex sm:flex-col flex-row font-inter gap-4 items-center justify-between mt-3 w-full">
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] text-base text-center w-[227px]"
                shape="round"
                color="teal_400"
                size="xl"
                variant="fill"
              >
                Vragenlijst
              </Button>
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] text-base text-center w-[243px]"
                shape="round"
                color="teal_400"
                size="xl"
                variant="fill"
              >
                Uitnodigingen
              </Button>
            </div>
            <Button
              className="cursor-pointer font-black font-inter h-14 leading-[normal] mt-[23px] text-base text-center w-[227px]"
              shape="round"
              color="teal_400"
              size="xl"
              variant="fill"
            >
              Online Opdracht
            </Button>
            <Text
              className="mt-5 text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Taal
            </Text>
            <div className="flex sm:flex-col flex-row font-inter gap-[15px] items-center justify-between mt-[5px] w-full">
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] text-base text-center underline w-[225px]"
                shape="round"
                color="teal_400"
                size="xl"
                variant="fill"
              >
                Nederlands
              </Button>
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] text-base text-center underline w-[243px]"
                shape="round"
                color="teal_400"
                size="xl"
                variant="fill"
              >
                English
              </Button>
            </div>
            <Text
              className="mt-7 text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Afgeronde Onderzoeken:
            </Text>
            <Input
              name="stackzoekhier"
              placeholder=""
              className="!placeholder:text-gray-500 !text-gray-500 font-jockeyone leading-[normal] p-0 placeholder:bg-deep_orange-50 text-left text-xl w-full"
              wrapClassName="mt-2.5 outline outline-[3px] outline-black-900 w-full"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Button
              className="cursor-pointer font-black font-inter h-14 leading-[normal] mt-[47px] text-center text-xl w-[486px]"
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

export default OnderzoekResultatenBedrijfPaginaPage;
