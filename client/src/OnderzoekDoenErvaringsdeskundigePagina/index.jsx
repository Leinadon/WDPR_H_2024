import React from "react";

import { Button, Img, Input, Text } from "components";

const OnderzoekDoenErvaringsdeskundigePaginaPage = () => {
  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[35px] sm:px-5 w-full">
        <div className="flex flex-col gap-11 items-center justify-start max-w-[1338px] mb-[13px] mx-auto md:px-5 w-full">
          <div className="flex md:flex-col flex-row md:gap-5 items-start justify-start w-full">
            <div className="flex md:flex-1 flex-col gap-[41px] justify-start w-[44%] md:w-full">
              <div className="flex sm:flex-col flex-row sm:gap-10 items-start justify-between mr-1.5 w-[99%] md:w-full">
                <Text
                  className="md:text-5xl text-6xl text-teal-400"
                  size="txtJockeyOneRegular60"
                >
                  Onderzoek
                </Text>
                <Img
                  className="h-[150px] md:h-auto sm:mt-0 mt-[83px] object-cover w-[150px]"
                  src="images/img_images2modified.png"
                  alt="images2modified"
                />
              </div>
              <div className="flex flex-col font-inter gap-[25px] items-start justify-start md:ml-[0] ml-[423px]">
                <Text
                  className="text-lg text-white-A700"
                  size="txtInterBlack18"
                >
                  Soort onderzoek:{" "}
                </Text>
                <Text
                  className="text-lg text-white-A700"
                  size="txtInterBlack18"
                >
                  Taal:{" "}
                </Text>
                <Text
                  className="text-lg text-white-A700"
                  size="txtInterBlack18"
                >
                  Beperkingstype:
                </Text>
              </div>
            </div>
            <div className="flex flex-col font-inter gap-[52px] items-start justify-start md:ml-[0] ml-[29px] md:mt-0 mt-[145px]">
              <Text
                className="text-base text-white-A700"
                size="txtInterBlack16"
              >
                Titel:{" "}
              </Text>
              <Text
                className="text-base text-white-A700"
                size="txtInterBlack16"
              >
                -
              </Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start md:ml-[0] ml-[571px] md:mt-0 mt-2.5 p-2.5 w-[116px]">
              <Img
                className="md:h-auto h-full object-cover w-full"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
              />
            </div>
          </div>
          <div className="flex flex-col font-inter items-start justify-start w-[37%] md:w-full">
            <Text className="text-lg text-white-A700" size="txtInterBlack18">
              Beschrijving:{" "}
            </Text>
            <Text
              className="mt-[232px] text-lg text-white-A700"
              size="txtInterBlack18"
            >
              Beloning:
            </Text>
            <Text
              className="mt-14 text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Bestand
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
              className="mt-12 text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Ingevuld bestand
            </Text>
            <Input
              name="rectanglesixtee"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[54px] mt-[7px] w-full"
              shape="round"
              color="deep_orange_50"
              variant="fill"
            ></Input>
            <Button
              className="cursor-pointer font-black h-14 leading-[normal] mt-[61px] text-center text-xl w-[486px]"
              shape="round"
              color="teal_400"
              size="lg"
              variant="fill"
            >
              Onderzoek Afgerond
            </Button>
            <Button
              className="cursor-pointer font-black h-14 leading-[normal] mt-[50px] text-center text-xl w-[486px]"
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

export default OnderzoekDoenErvaringsdeskundigePaginaPage;
