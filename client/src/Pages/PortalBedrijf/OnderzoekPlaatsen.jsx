import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, CheckBox, Img, Input, Text } from "../../components";

const SignUpPaginaPage = () => {
  const navigate = useNavigate();

  return (
    <>
    <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col gap-[18px] items-center justify-start max-w-[1337px] mb-[19px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-center p-2.5 w-[445px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400"
                size="txtJockeyOneRegular60"
              >
                Onderzoek
              </Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start p-2.5 w-[116px]">
              <Img
                className="md:h-auto h-full object-cover w-full"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
              />
            </div>
          </div>
          <div className="flex flex-col font-inter items-start justify-start w-[37%] md:w-full">
            <Text className="text-white-A700 text-xl" size="txtInterBlack20">
              Soort onderzoek
            </Text>
            <div className="flex sm:flex-col flex-row gap-[21px] items-center justify-between mt-4 w-[99%] md:w-full">
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] text-base text-center w-[229px]"
                shape="round"
                color="teal_400"
                size="xl"
                variant="fill"
              >
                Vragenlijst
              </Button>
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] text-base text-center w-[232px]"
                shape="round"
                color="teal_400"
                size="xl"
                variant="fill"
              >
                Uitnodigingen
              </Button>
            </div>
            <Button
              className="cursor-pointer font-black h-14 leading-[normal] mt-5 text-base text-center w-[229px]"
              shape="round"
              color="teal_400"
              size="xl"
              variant="fill"
            >
              Online Opdracht
            </Button>
            <Text
              className="mt-8 text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Taal (language)
            </Text>
            <div className="flex sm:flex-col flex-row gap-3.5 items-center justify-between mt-3.5 w-[99%] md:w-full">
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] text-base text-center underline w-[226px]"
                shape="round"
                color="teal_400"
                size="xl"
                variant="fill"
              >
                Nederlands
              </Button>
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] text-base text-center underline w-[242px]"
                shape="round"
                color="teal_400"
                size="xl"
                variant="fill"
              >
                English
              </Button>
            </div>
            <Text
              className="mt-5 text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Type Beperking
            </Text>
            <div className="flex flex-row gap-[63px] items-start justify-start mt-4 w-[30%] md:w-full">
              <Input
                name="rectangleFive"
                placeholder=""
                className="p-0 w-full"
                wrapClassName="flex h-5 my-0.5 rounded-[3px] w-5"
                color="blue_gray_100"
              ></Input>
              <Text
                className="text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Fysiek
              </Text>
            </div>
            <div className="flex flex-row gap-[63px] items-center justify-start mt-[19px] w-2/5 md:w-full">
              <CheckBox
                className="my-0.5"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectangleFive_One"
                id="rectangleFive_One"
              ></CheckBox>
              <Text
                className="text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Zintuigelijk
              </Text>
            </div>
            <div className="flex flex-row gap-[63px] items-center justify-start mt-[19px] w-[36%] md:w-full">
              <CheckBox
                className="my-0.5"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectangleFive_Two"
                id="rectangleFive_Two"
              ></CheckBox>
              <Text
                className="text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Cognitief
              </Text>
            </div>
            <div className="flex flex-row gap-[63px] items-center justify-start mt-[19px] w-[44%] md:w-full">
              <CheckBox
                className="my-0.5"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectangleFive_Three"
                id="rectangleFive_Three"
              ></CheckBox>
              <Text
                className="text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Neurologisch
              </Text>
            </div>
            <div className="flex flex-row gap-[63px] items-center justify-start mt-[19px] w-[43%] md:w-full">
              <CheckBox
                className="my-0.5"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectangleFive_Four"
                id="rectangleFive_Four"
              ></CheckBox>
              <Text
                className="text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Ontwikkeling
              </Text>
            </div>
            <Text
              className="mt-9 text-center text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Postcode
            </Text>
            <Input
              name="rectangleTen"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] mt-[19px] w-full"
              shape="round"
            ></Input>
            <div className="flex flex-row items-center justify-between mt-[31px] w-[83%] md:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Min. Leeftijd
              </Text>
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Max. Leeftijd
              </Text>
            </div>
            <div className="flex sm:flex-col flex-row sm:gap-[51px] items-center justify-between mt-[18px] w-full">
              <Input
                name="rectangleEleven"
                placeholder=""
                className="p-0 w-full"
                wrapClassName="flex sm:flex-1 h-[54px] sm:w-full"
                shape="round"
              ></Input>
              <Input
                name="rectangleTwelve"
                placeholder=""
                className="p-0 w-full"
                wrapClassName="flex sm:flex-1 h-[54px] sm:w-full"
                shape="round"
              ></Input>
            </div>
            <Text
              className="mt-[22px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Titel
            </Text>
            <Input
              name="rectangleThirteen"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] mt-[17px] w-full"
              shape="round"
            ></Input>
            <Text
              className="mt-[31px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Beschrijving Opdracht
            </Text>
            <div className="bg-deep_orange-50 h-[188px] mt-[15px] rounded-[27px] w-full"></div>
            <Text
              className="mt-10 text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Upload Bestand
            </Text>
            <Input
              name="rectangleFifteen"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] mt-3.5 w-full"
              shape="round"
            ></Input>
            <Button
              className="cursor-pointer font-black h-12 leading-[normal] mt-[72px] rounded-[24px] text-center text-xl w-[486px]"
              color="teal_400"
              size="md"
              variant="fill"
            >
              Onderzoek Plaatsen
            </Button>
            <Button
              className="cursor-pointer font-black h-14 leading-[normal] mt-[57px] text-center text-xl w-[486px]"
              shape="round"
              color="blue_gray_100_01"
              variant="fill"
            >
              Annuleren
            </Button>
          </div>
        </div>
      </div>
    </>
  );
};

export default SignUpPaginaPage;
