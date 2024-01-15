import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, CheckBox, Img, Input, Text } from "components";

const SignUpPaginaPage = () => {
  const navigate = useNavigate();

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col justify-start max-w-[1337px] mb-[108px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-start p-2.5 w-[460px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400"
                size="txtJockeyOneRegular60"
              >
                Sign Up
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
          <Text
            className="md:ml-[0] ml-[437px] mt-[49px] text-4xl sm:text-[32px] md:text-[34px] text-white-A700"
            size="txtJockeyOneRegular36"
          >
            Maak een Account!
          </Text>
          <div className="flex flex-col font-inter justify-start md:ml-[0] ml-[427px] mt-[35px] w-[36%] md:w-full">
            <div className="flex flex-col h-11 md:h-auto items-center justify-start mr-3 p-2.5 w-[466px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Voornaam
              </Text>
            </div>
            <Input
              name="rectanglethree"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 w-full"
              wrapClassName="h-[54px] ml-2.5 md:ml-[0] mr-0.5 rounded-[27px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-center justify-start mr-3 mt-2.5 p-2.5 w-[466px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Achternaam
              </Text>
            </div>
            <Input
              name="rectangleseven"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 w-full"
              wrapClassName="h-[54px] ml-2.5 md:ml-[0] mr-0.5 rounded-[27px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-center justify-start ml-0.5 md:ml-[0] mt-2.5 p-2.5 w-[464px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Geboortedatum
              </Text>
            </div>
            <Input
              name="rectanglefour"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 w-full"
              wrapClassName="h-[54px] ml-2.5 md:ml-[0] mr-0.5 mt-1 rounded-[27px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-center justify-start ml-0.5 md:ml-[0] mt-3.5 p-2.5 w-[464px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Email
              </Text>
            </div>
            <Input
              name="rectangleeight"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 w-full"
              wrapClassName="h-[54px] ml-3 md:ml-[0] rounded-[27px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-center justify-start ml-0.5 md:ml-[0] mt-2.5 p-2.5 w-[464px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Telefoonnummer
              </Text>
            </div>
            <Input
              name="rectanglefive"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 w-full"
              wrapClassName="h-[54px] ml-3 md:ml-[0] mt-1 rounded-[27px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-center justify-start ml-0.5 md:ml-[0] mt-2.5 p-2.5 w-[454px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Postcode
              </Text>
            </div>
            <Input
              name="rectanglesix"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 w-full"
              wrapClassName="h-[54px] ml-2.5 md:ml-[0] mr-0.5 mt-0.5 rounded-[27px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-center justify-start ml-0.5 md:ml-[0] mt-4 p-2.5 w-[454px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Wachtwoord
              </Text>
            </div>
            <Input
              name="rectanglesixone"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 w-full"
              wrapClassName="h-[54px] ml-3 md:ml-[0] mr-0.5 mt-[17px] rounded-[27px] w-[98%]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="ml-2.5 md:ml-[0] mt-7 text-center text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Type Beperking
            </Text>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[0] mt-[41px] w-[24%] md:w-full">
              <CheckBox
                className="my-0.5"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectanglefiveon"
                id="rectanglefiveon"
                shape="round"
                color="blue_gray_100"
                variant="fill"
              ></CheckBox>
              <Text
                className="text-center text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Fysiek
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[0] mt-[23px] w-[33%] md:w-full">
              <div className="bg-blue_gray-100 h-[19px] mb-[5px] rounded-[3px] w-5"></div>
              <Text
                className="text-center text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Zintuigelijk
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[0] mt-[22px] w-[29%] md:w-full">
              <CheckBox
                className="mb-1"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectanglefiveth"
                id="rectanglefiveth"
                shape="round"
                color="blue_gray_100"
                variant="fill"
              ></CheckBox>
              <Text
                className="text-center text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Cognitief
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[0] mt-[23px] w-[38%] md:w-full">
              <div className="bg-blue_gray-100 h-[21px] mb-[3px] rounded-[3px] w-5"></div>
              <Text
                className="text-center text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Neurologisch
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start ml-2.5 md:ml-[0] mt-[25px] w-[37%] md:w-full">
              <CheckBox
                className="mb-1"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectanglefivefi"
                id="rectanglefivefi"
                shape="round"
                color="blue_gray_100"
                variant="fill"
              ></CheckBox>
              <Text
                className="text-center text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Ontwikkeling
              </Text>
            </div>
            <Text
              className="ml-3 md:ml-[0] mt-[30px] text-center text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Voogd
            </Text>
            <Button
              className="cursor-pointer font-black h-[54px] leading-[normal] ml-2.5 md:ml-[0] mr-0.5 mt-[13px] text-center text-xl underline w-[466px]"
              shape="round"
              color="teal_400"
              size="lg"
              variant="fill"
            >
              Ik heb geen Voogd
            </Button>
            <Text
              className="ml-2.5 md:ml-[0] mt-[31px] text-center text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Hulpmiddelen
            </Text>
            <Input
              name="rectangleeleven"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] ml-3 md:ml-[0] mt-[17px] w-[98%]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Button
              className="cursor-pointer font-black h-14 leading-[normal] ml-2.5 md:ml-[0] mr-0.5 mt-[113px] text-center text-xl w-[466px]"
              shape="round"
              color="teal_400"
              size="lg"
              variant="fill"
            >
              Sign Up
            </Button>
            <Button
              className="common-pointer bg-transparent cursor-pointer font-semibold h-[39px] leading-[normal] ml-3 md:ml-[0] mt-[47px] text-3xl sm:text-[26px] md:text-[28px] text-center text-white-A700 w-[454px]"
              onClick={() => navigate("/loginpagina")}
              size="xs"
            >
              Al een account? Log In
            </Button>
          </div>
        </div>
      </div>
    </>
  );
};

export default SignUpPaginaPage;
