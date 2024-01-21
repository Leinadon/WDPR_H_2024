import React from "react";

import { Button, Img, Text } from "components";

const ProfielBeheerderPaginaPage = () => {
  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col gap-3.5 items-center justify-start max-w-[1337px] mb-[156px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-center p-2.5 w-[433px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400"
                size="txtJockeyOneRegular60"
              >
                Profiel
              </Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start p-2.5 w-[116px]">
              <Img
                className="h-[79px] md:h-auto object-cover w-24"
                src="images/img_Logo.png"
                alt="Logo Accessobility"
              />
            </div>
          </div>
          <div className="flex flex-col font-inter items-start justify-start w-[37%] md:w-full">
            <div className="flex sm:flex-col flex-row sm:gap-10 items-end justify-between w-full">
              <Img
                className="h-[150px] md:h-auto object-cover w-[150px]"
                src="images/img_images2modified_150x150.png"
                alt="images2modified"
              />
              <Button className="bg-transparent cursor-pointer font-black leading-[normal] min-w-[220px] sm:mt-0 mt-[131px] text-base text-center text-white-A700 underline">
                Verander Profiel afbeelding
              </Button>
            </div>
            <Text
              className="mt-[54px] text-lg text-white-A700"
              size="txtInterBlack18"
            >
              Naam:{" "}
            </Text>
            <Text
              className="mt-6 text-lg text-white-A700"
              size="txtInterBlack18"
            >
              Email:{" "}
            </Text>
            <Button
              className="cursor-pointer flex h-14 items-center justify-center mt-[159px] w-[486px]"
              rightIcon={
                <Img
                  className="ml-2.5 mr-[97px]"
                  src="images/img_image12.png"
                  alt="imageTwelve"
                />
              }
              shape="round"
              color="teal_400"
              size="md"
              variant="fill"
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Gegevens aanpassen
              </div>
            </Button>
            <Button
              className="cursor-pointer font-black h-14 leading-[normal] mt-[74px] text-center text-xl w-[486px]"
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

export default ProfielBeheerderPaginaPage;
