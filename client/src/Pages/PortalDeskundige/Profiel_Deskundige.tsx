import React from "react";

import { Button, Img, Text } from "../../components";

const ProfielErvaringsdeskundigePaginaPage = () => {
  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[35px] sm:px-5 w-full">
        <div className="flex flex-col gap-[38px] items-center justify-start max-w-[1328px] mb-[100px] mx-auto md:px-5 w-full">
          <div className="flex flex-row md:gap-10 items-start justify-between w-full">
            <Text
              className="md:text-5xl text-6xl text-teal-400"
              size="txtJockeyOneRegular60"
              as="any"
            >
              Profiel
            </Text>
            <div className="flex flex-col h-[100px] md:h-auto items-start justify-start p-2.5 w-[116px]">
              <Img
                className="md:h-auto h-full object-cover w-full"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
              />
            </div>
          </div>
          <div className="flex flex-col font-inter items-center justify-start w-[37%] md:w-full">
            <div className="md:h-[150px] h-[291px] relative w-full">
              <div className="absolute bottom-[19%] h-[119px] md:h-[42px] inset-x-[0] mx-auto w-full">
                <div className="absolute flex flex-col h-[65px] md:h-auto items-center justify-center p-2.5 right-[2%] top-[0] w-60">
                  <Text
                    className="text-base text-right text-white-A700 underline"
                    size="txtInterBlack16"
                    as="any"
                  >
                    Verander Profiel afbeelding
                  </Text>
                </div>
                <div className="absolute bottom-[0] flex flex-col h-[61px] md:h-auto inset-x-[0] items-center justify-center mx-auto p-2.5 w-[486px] sm:w-full">
                  <Text
                    className="text-lg text-white-A700 w-auto"
                    size="txtInterBlack18"
                    as="any"
                  >
                    Naam:{" "}
                  </Text>
                </div>
              </div>
              <div className="absolute bottom-[0] flex flex-col h-[61px] md:h-auto inset-x-[0] items-center justify-center mx-auto p-2.5 w-[486px] sm:w-full">
                <Text
                  className="text-lg text-white-A700 w-auto"
                  size="txtInterBlack18"
                  as="any"
                >
                  Email:{" "}
                </Text>
              </div>
              <Img
                className="absolute h-[150px] left-[2%] object-cover top-[0] w-[150px]"
                src="images/img_images2modified.png"
                alt="images2modified"
              />
            </div>
            <div className="flex flex-col h-[117px] md:h-auto items-center justify-center mt-[15px] p-2.5 w-[486px] sm:w-full">
              <Text
                className="text-lg text-white-A700 w-auto"
                size="txtInterBlack18"
                as="any"
              >
                Beperkingstype(s):{" "}
              </Text>
            </div>
            <div className="flex flex-col h-[115px] md:h-auto items-center justify-center p-2.5 w-[486px] sm:w-full">
              <Text
                className="text-lg text-white-A700 w-auto"
                size="txtInterBlack18"
                as="any"
              >
                Hulpmiddel(en):{" "}
              </Text>
            </div>
            <Button
              className="cursor-pointer flex h-[60px] items-center justify-center mt-[15px] w-[486px]"
              rightIcon={
                <Img
                  className="ml-2.5 mr-[95px]"
                  src="images/img_image12.png"
                  alt="imageTwelve"
                />
              }
              shape="round"
              color="teal_400"
              size="md"
              variant="fill"
              as="any"
              leftIcon
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Gegevens aanpassen
              </div>
            </Button>
            <Button
              className="cursor-pointer font-black h-[60px] leading-[normal] mt-[72px] text-center text-xl w-[486px]"
              shape="round"
              color="blue_gray_100_01"
              variant="fill"
              as="any"
              leftIcon
              rightIcon
            >
              Terug naar Menu
            </Button>
          </div>
        </div>
      </div>
    </>
  );
};

export default ProfielErvaringsdeskundigePaginaPage;