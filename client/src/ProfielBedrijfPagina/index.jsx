import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, Img, Text } from "components";


const ProfielBedrijfPaginaPage = () => {
  const navigate = useNavigate(); 
  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col gap-[9px] items-center justify-start max-w-[1337px] mb-[23px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-center p-2.5 w-[445px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400"
                size="txtJockeyOneRegular60"
              >
                Profiel
              </Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start p-2.5 w-[116px]">
              <Img
                className="md:h-auto h-full object-cover w-full"
                src="images/img_Logo.png"
                alt="reshotillustra"
              />
            </div>
          </div>
          <div className="flex flex-col font-inter items-start justify-start w-[37%] md:w-full">
            <div className="flex sm:flex-col flex-row sm:gap-10 items-start justify-between w-full">
              <Img
                className="h-[150px] md:h-auto mb-[5px] object-cover w-[150px]"
                src="images/img_images2modified_150x150.png"
                alt="images2modified"
              />
              <Text
                className="sm:mt-0 mt-[135px] text-base text-center text-white-A700 underline"
                size="txtInterBlack16"
              >
                Verander Profiel afbeelding
              </Text>
            </div>
            <Text
              className="ml-0.5 md:ml-[0] mt-[17px] text-lg text-white-A700"
              size="txtInterBlack18"
            >
              Naam:{" "}
            </Text>
            <Text
              className="ml-0.5 md:ml-[0] mt-[25px] text-lg text-white-A700"
              size="txtInterBlack18"
            >
              Email:{" "}
            </Text>
            <Text
              className="ml-0.5 md:ml-[0] mt-[25px] text-lg text-white-A700"
              size="txtInterBlack18"
            >
              Link van website:{" "}
            </Text>
            <Text
              className="mt-[62px] text-lg text-white-A700"
              size="txtInterBlack18"
            >
              Bedrijfslocatie:{" "}
            </Text>
            <Text
              className="mt-[49px] text-lg text-white-A700"
              size="txtInterBlack18"
            >
              Informatie over bedrijf:{" "}
            </Text>
            <Button
              className="cursor-pointer flex h-14 items-center justify-center ml-0.5 md:ml-[0] mt-[227px] w-[486px]"
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
              className="cursor-pointer font-black h-14 leading-[normal] mt-[47px] text-center text-xl w-[486px]"
              onClick={() => navigate("/bedrijfmenupagina")}
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

export default ProfielBedrijfPaginaPage;
