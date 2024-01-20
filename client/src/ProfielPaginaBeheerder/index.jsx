import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, Img, Input, Text } from "components";

const ProfielPaginaBeheerderPage = () => {
  const navigate = useNavigate();

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col gap-[50px] items-center justify-start max-w-[1337px] mb-[41px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-center p-2.5 w-[422px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400"
                size="txtJockeyOneRegular60"
              >
                Profiel
              </Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start p-2.5 w-[116px]">
              <Img
                className="common-pointer md:h-auto h-full object-cover w-full"
                src="images/img_Logo.png"
                alt="Accessibility Logo"
                onClick={() => navigate("/menupagina")}
              />
            </div>
          </div>
          <div className="flex flex-col font-inter items-start justify-start w-[37%] md:w-full">
            <Text className="text-white-A700 text-xl" size="txtInterBlack20">
              Voornaam
            </Text>
            <Input
              name="rectanglenine"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[49px] mt-[7px] rounded-[24px] w-full"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="mt-[37px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Achternaam
            </Text>
            <Input
              name="rectanglethirte"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] mt-[7px] w-full"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="mt-[35px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Email
            </Text>
            <Input
              name="rectangleten"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] mt-2 w-full"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="mt-[30px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Postcode
            </Text>
            <Input
              name="rectangletwelve"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] mt-[7px] w-full"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="mt-[27px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Wachtwoord
            </Text>
            <Input
              name="rectangleeleven"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] mt-[7px] w-full"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="mt-[38px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Telefoonnummer
            </Text>
            <Input
              name="rectanglefourte"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] mt-2 w-full"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Button
              className="cursor-pointer font-black h-14 leading-[normal] mt-16 text-center text-xl w-[486px]"
              shape="round"
              color="teal_400"
              size="lg"
              variant="fill"
            >
              Opslaan
            </Button>
            <Button
              className="common-pointer cursor-pointer font-black h-14 leading-[normal] mt-11 text-center text-xl w-[486px]"
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

export default ProfielPaginaBeheerderPage;
