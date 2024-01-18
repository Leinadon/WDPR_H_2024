import React from "react";

import { Button, Img, Input, Text, TextArea } from "components";

const ProfielPaginaBedrijvenPage = () => {
  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-5 w-full">
        <div className="flex flex-col gap-7 items-center justify-start max-w-[1365px] mb-36 mt-[23px] mx-auto md:px-5 w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-start justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-center p-2.5 w-[433px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400"
                size="txtJockeyOneRegular60"
              >
                Profiel
              </Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start sm:mt-0 mt-[5px] p-2.5 w-[116px]">
              <Img
                className="md:h-auto h-full object-cover w-full"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
              />
            </div>
          </div>
          <div className="flex flex-col font-inter items-start justify-start w-[36%] md:w-full">
            <Text className="text-white-A700 text-xl" size="txtInterBlack20">
              Bedrijfsnaam
            </Text>
            <Input
              name="rectanglenine"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[49px] mt-2 rounded-[24px] w-full"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="mt-[31px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Email
            </Text>
            <Input
              name="rectanglethirte"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] mt-[11px] w-full"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="mt-[31px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Link van Website
            </Text>
            <Input
              name="rectangleten"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] mt-[11px] w-full"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="mt-[33px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Bedrijfslocatie (hoofdgebouw)
            </Text>
            <Input
              name="rectangletwelve"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] mt-[9px] w-full"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="mt-[31px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Telefoonnummer
            </Text>
            <Input
              name="rectanglefiftee"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] mt-[11px] w-full"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Text
              className="mt-[43px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Informatie over het bedrijf
            </Text>
            <TextArea
              className="bg-deep_orange-50 border-0 mt-[11px] rounded-[27px] w-full"
              name="rectanglefourte"
              placeholder=""
            ></TextArea>
            <Button
              className="cursor-pointer font-black h-14 leading-[normal] mt-[60px] text-center text-xl w-[486px]"
              shape="round"
              color="teal_400"
              size="lg"
              variant="fill"
            >
              Opslaan
            </Button>
            <Button
              className="cursor-pointer font-black h-14 leading-[normal] mt-[68px] text-center text-xl w-[486px]"
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

export default ProfielPaginaBedrijvenPage;
