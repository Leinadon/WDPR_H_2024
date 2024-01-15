import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, CheckBox, Img, Input, Text } from "components";

const ProfielPaginaPage = () => {
  const navigate = useNavigate();

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col md:gap-10 gap-[71px] items-center justify-start max-w-[1332px] mb-[42px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-start p-2.5 w-[460px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400 w-[241px]"
                size="txtJockeyOneRegular60"
              >
                Aanpassen
              </Text>
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
          <div className="flex flex-col font-inter items-start justify-start w-[37%] md:w-full">
            <Text
              className="md:ml-[0] ml-[5px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Voornaam
            </Text>
            <Input
              name="rectanglenine"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[49px] md:ml-[0] ml-[5px] mt-[7px] rounded-[24px] w-[99%]"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="md:ml-[0] ml-[5px] mt-[37px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Achternaam
            </Text>
            <Input
              name="rectanglethirte"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] md:ml-[0] ml-[5px] mt-[7px] w-[99%]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="md:ml-[0] ml-[5px] mt-9 text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Geboortedatum
            </Text>
            <Input
              name="rectangleten"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] md:ml-[0] ml-[5px] mt-[7px] w-[99%]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="md:ml-[0] ml-[5px] mt-[29px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Email
            </Text>
            <Input
              name="rectangletwelve"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] md:ml-[0] ml-[5px] mt-2 w-[99%]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="md:ml-[0] ml-[5px] mt-[26px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Telefoonnummer
            </Text>
            <Input
              name="rectangleeleven"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] md:ml-[0] ml-[5px] mt-2 w-[99%]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="md:ml-[0] ml-[5px] mt-[39px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Postcode
            </Text>
            <Input
              name="rectanglefourte"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] md:ml-[0] ml-[5px] mt-[7px] w-[99%]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="md:ml-[0] ml-[5px] mt-[30px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Wachtwoord
            </Text>
            <Input
              name="rectanglefiftee"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] md:ml-[0] ml-[5px] mt-[7px] w-[99%]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="md:ml-[0] ml-[5px] mt-8 text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Type Beperking
            </Text>
            <div className="flex flex-row gap-7 items-start justify-start md:ml-[0] ml-[5px] mt-5 w-[23%] md:w-full">
              <Input
                name="rectanglefive"
                placeholder=""
                className="p-0 w-full"
                wrapClassName="flex h-5 my-0.5 rounded-[3px] w-5"
                color="blue_gray_100"
                variant="fill"
              ></Input>
              <Text
                className="text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Fysiek
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start md:ml-[0] ml-[5px] mt-[23px] w-[32%] md:w-full">
              <CheckBox
                className="mb-1"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectanglefiveon"
                id="rectanglefiveon"
                shape="round"
                color="blue_gray_100"
                variant="fill"
              ></CheckBox>
              <Text
                className="text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Zintuigelijk
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start md:ml-[0] ml-[5px] mt-[23px] w-[29%] md:w-full">
              <CheckBox
                className="mb-1"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectanglefivetw"
                id="rectanglefivetw"
                shape="round"
                color="blue_gray_100"
                variant="fill"
              ></CheckBox>
              <Text
                className="text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Cognitief
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start md:ml-[0] ml-[5px] mt-[23px] w-[36%] md:w-full">
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
                className="text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Neurologisch
              </Text>
            </div>
            <div className="flex flex-row gap-7 items-start justify-start md:ml-[0] ml-[5px] mt-[23px] w-[36%] md:w-full">
              <CheckBox
                className="mb-1"
                inputClassName="h-5 mr-[5px] rounded-[3px] w-5"
                name="rectanglefivefo"
                id="rectanglefivefo"
                shape="round"
                color="blue_gray_100"
                variant="fill"
              ></CheckBox>
              <Text
                className="text-white-A700 text-xl"
                size="txtInterSemiBold20"
              >
                Ontwikkeling
              </Text>
            </div>
            <Text
              className="md:ml-[0] ml-[5px] mt-[35px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Hulpmiddelen
            </Text>
            <Input
              name="rectangleninete"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] md:ml-[0] ml-[5px] mt-2.5 w-[99%]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Button
              className="cursor-pointer font-black h-14 leading-[normal] mt-[84px] text-center text-xl w-[486px]"
              shape="round"
              color="teal_400"
              size="lg"
              variant="fill"
            >
              Opslaan
            </Button>
            <Button
              className="common-pointer cursor-pointer font-black h-14 leading-[normal] mt-[49px] text-center text-xl w-[486px]"
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

export default ProfielPaginaPage;
