import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, Img, Text } from "components";

const ProfielErvaringsdeskundigePaginaPage = () => {
  const navigate = useNavigate();
  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col justify-start max-w-[1440px] mb-[108px] mx-auto w-full">
          <div className="flex flex-col items-center justify-start w-full">
            <div className="flex flex-row font-jockeyone md:gap-10 gap-[885px] h-[104px] md:h-auto items-center justify-start max-w-[1368px] md:pl-10 sm:pl-5 pl-[121px] pr-2.5 py-2.5 w-full">
            <Text
                className="md:text-5xl text-6xl text-teal-400 items-left ml-[-64.5px]"
                size="txtJockeyOneRegular60"
            >
              Profiel
            </Text>
            <Img
                className="md:h-auto h-full items-right object-cover ml-[-px] w-[104px]"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
                onClick={() => navigate("/menupagina")}
              />
          </div>
          <div className="flex flex-col font-inter items-center justify-start w-[600px] mt-[60px] md:w-full">
            <div className="md:h-[150px] h-[291px] relative w-full" >
              <div className="absolute bottom-[19%] h-[119px] md:h-[42px] inset-x-[0] mx-auto w-full">
                <div className="absolute flex flex-col h-[65px] md:h-auto items-center justify-center p-2.5 right-[2%] top-[0] w-60">
                  <Button className="bg-transparent cursor-pointer font-black leading-[normal] min-w-[220px] text-base text-center text-white-A700 underline">
                    Verander Profiel afbeelding
                  </Button>
                </div>
                <div className="absolute bottom-[0] flex flex-col h-[61px] md:h-auto inset-x-[0] items-left justify-center mx-auto p-2.5 w-[600px] sm:w-full">
                  <Text
                    className="text-lg text-white-A700 w-auto"
                    size="txtInterBlack18"
                  >
                    Naam:{" "}
                  </Text>
                </div>
              </div>
              <div className="absolute bottom-[0] flex flex-col h-[61px] md:h-auto inset-x-[0] items-left justify-center mx-auto p-2.5 w-[600px] sm:w-full">
                <Text
                  className="text-lg text-white-A700 w-auto"
                  size="txtInterBlack18"
                >
                  Email:{" "}
                </Text>
              </div>
              <Img
                className="absolute h-[150px] left-[2%] object-cover top-[0] w-[150px] ml-[-6px]"
                src="images/img_images2modified.png"
                alt="images2modified"
              />
            </div>
            <div className="flex flex-col h-[117px] md:h-auto items-left justify-center mt-[15px] p-2.5 w-[600px] sm:w-full">
              <Text
                className="text-lg text-white-A700 w-auto"
                size="txtInterBlack18"
              >
                Beperkingstype(s):{" "}
              </Text>
            </div>
            <div className="flex flex-col h-[115px] md:h-auto items-left justify-center p-2.5 w-[600px] sm:w-full">
              <Text
                className="text-lg text-white-A700 w-auto"
                size="txtInterBlack18"
              >
                Hulpmiddel(en):{" "}
              </Text>
            </div>
            <Button
              className="cursor-pointer flex h-[60px] items-center justify-center mt-[15px] w-[600px]"
              onClick={() => navigate("/profielpagina")}
              rightIcon={
                <Img
                  className="md:h-auto h-full object-cover w-[50px]"
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
              className="cursor-pointer font-black h-[60px] leading-[normal] mt-[72px] text-center text-xl w-[600px]"
              shape="round"
              color="blue_gray_100_01"
              size="lg"
              variant="fill"
              onClick={() => navigate("/menupagina")}
            >
              Terug naar Menu
            </Button>
          </div>
        </div>
      </div>
    </div>  
    </>
  );
};

export default ProfielErvaringsdeskundigePaginaPage;
