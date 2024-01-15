import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, Img, List, Text } from "../components";

const SignUpPaginaPage = () => {
  const navigate = useNavigate();

  return (
    <>
     <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[46px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col items-center justify-start max-w-[1332px] mb-6 mx-auto w-full">
          <div className="flex md:flex-col flex-row md:gap-10 items-start justify-between w-full">
            <div className="md:h-[104px] h-[172px] relative w-[68%] md:w-full">
              <div className="absolute flex flex-col h-28 md:h-auto items-center justify-start left-[0] p-2.5 top-[0] w-[460px] sm:w-full">
                <Text
                  className="md:text-5xl text-6xl text-teal-400 w-[331px]"
                  size="txtJockeyOneRegular60"
                >
                  Ondersteuning
                </Text>
              </div>
              <div className="absolute bottom-[0] flex flex-col h-[70px] md:h-auto items-center justify-center p-2.5 right-[0] w-[496px] sm:w-full">
                <Text
                  className="text-4xl sm:text-[32px] md:text-[34px] text-white-A700 w-[271px]"
                  size="txtJockeyOneRegular36"
                >
                  Veelgestelde vragen
                </Text>
              </div>
            </div>
            <div className="flex flex-col h-[108px] md:h-auto items-center justify-start md:mt-0 mt-0.5 p-2.5 w-[116px]">
              <Img
                className="common-pointer md:h-auto h-full object-cover w-full"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
                onClick={() => navigate("/menupagina")}
              />
            </div>
          </div>
          <div className="flex flex-col font-inter gap-[21px] h-[580px] md:h-auto items-center justify-center mt-[27px] w-[486px] sm:w-full">
            <Text
              className="text-lg text-white-A700 w-auto"
              size="txtInterBlack18"
            >
              Wat is het doel van deze website?
            </Text>
            <Text
              className="max-w-[486px] md:max-w-full text-sm text-white-A700"
              size="txtInterBlack14"
            >
              Om bedrijven onderzoek te laten doen om Accessibility op hun
              websites te testen en te verbeteren.
            </Text>
            <Text
              className="max-w-[486px] md:max-w-full text-lg text-white-A700"
              size="txtInterBlack18"
            >
              Hoe komen gebruikers in contact met de klantenservice?
            </Text>
            <Text
              className="max-w-[468px] md:max-w-full text-sm text-white-A700"
              size="txtInterBlack14"
            >
              Onder aan deze pagina kunt u een bericht versturen naar onze
              klantenservice die u bericht zo snel mogelijk zal beantwoorden.
            </Text>
            <Text
              className="text-lg text-white-A700 w-auto"
              size="txtInterBlack18"
            >
              Hoe doe ik mee aan een onderzoek?
            </Text>
            <Text
              className="max-w-[468px] md:max-w-full text-sm text-white-A700"
              size="txtInterBlack14"
            >
              U kunt uitgenodigd worden via de mail om een een onderzoek mee te
              doen.
            </Text>
            <Text
              className="text-lg text-white-A700 w-auto"
              size="txtInterBlack18"
            >
              Hoe verander ik mijn wachtwoord?
            </Text>
            <Text
              className="max-w-[468px] md:max-w-full text-sm text-white-A700"
              size="txtInterBlack14"
            >
              U kan uw wachtwoord veranderen in uw profiel. Ga terug naar het
              menu en klik op ‘profiel’, dat zijn uw gegevens en uw wachtwoord
              staat daar tussen. Klik op ‘wachtwoord’ en verander naar wens,
              klik daarna op ‘opslaan’ en klaar is Kees!
            </Text>
            <Text
              className="text-lg text-white-A700 w-auto"
              size="txtInterBlack18"
            >
              Hoe chat ik met een bedrijf?
            </Text>
            <Text
              className="max-w-[481px] md:max-w-full text-sm text-white-A700"
              size="txtInterBlack14"
            >
              U kan chatten met een bedrijf bij uw chatoverzicht. Klik op ‘terug
              naar menu’ onder aan de pagina klik daarna op de knop met ‘chats’
              en zoek voor uw gewenst bedrijf waar uw mee wil chatten. Klik op
              het gewenste bedrijf en nu kan u hier berichten sturen naar
              bedrijven.
            </Text>
          </div>
          <div className="flex flex-col items-center justify-start mt-[45px] w-[38%] md:w-full">
            <List
              className="flex flex-col font-jockeyone gap-[22px] items-center w-full"
              orientation="vertical"
            >
              <div className="flex sm:flex-1 flex-col h-[90px] md:h-auto items-center justify-center mr-2.5 my-0 p-2.5 w-[496px] sm:w-full">
                <Text
                  className="text-4xl sm:text-[32px] md:text-[34px] text-white-A700 w-72"
                  size="txtJockeyOneRegular36"
                >
                  Stuur ons een bericht!
                </Text>
              </div>
              <div className="font-inter h-[111px] md:h-[69px] my-0 relative w-full">
                <div className="absolute flex flex-col h-11 md:h-auto inset-x-[0] items-center justify-center mx-auto p-2.5 top-[0] w-[486px] sm:w-full">
                  <Text
                    className="text-white-A700 text-xl w-full"
                    size="txtInterBlack20"
                  >
                    Naam
                  </Text>
                </div>
                <Img
                  className="absolute bottom-[0] h-[69px] inset-x-[0] mx-auto w-[506px]"
                  src="images/img_frame21.svg"
                  alt="frameSixtyTwo"
                />
              </div>
              <div className="font-inter h-[116px] md:h-[74px] my-0 relative w-full">
                <div className="absolute flex flex-col h-11 md:h-auto inset-x-[0] items-center justify-center mx-auto p-2.5 top-[0] w-[486px] sm:w-full">
                  <Text
                    className="text-white-A700 text-xl"
                    size="txtInterBlack20"
                  >
                    Email
                  </Text>
                </div>
                <Img
                  className="absolute bottom-[0] h-[74px] inset-x-[0] mx-auto w-[506px]"
                  src="images/img_frame21.svg"
                  alt="frameSixtyOne"
                />
              </div>
              <div className="flex sm:flex-1 flex-col font-inter h-11 md:h-auto items-center justify-center mx-auto my-0 p-2.5 w-[486px] sm:w-full">
                <Text
                  className="text-white-A700 text-xl"
                  size="txtInterBlack20"
                >
                  Onderwerp
                </Text>
              </div>
            </List>
            <Img
              className="h-[74px] w-[506px]"
              src="images/img_frame21.svg"
              alt="frameSixty"
            />
            <div className="flex flex-col font-inter h-11 md:h-auto items-center justify-center mt-[31px] p-2.5 w-[476px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Uw bericht
              </Text>
            </div>
            <Img
              className="h-[232px] w-[506px]"
              src="images/img_frame21.svg"
              alt="frameFiftyNine"
            />
            <Button
              className="cursor-pointer font-black font-inter h-14 leading-[normal] mt-[45px] text-center text-xl w-[486px]"
              shape="round"
              color="teal_400"
              variant="fill"
            >
              Verstuur Bericht
            </Button>
            <Button
              className="common-pointer cursor-pointer font-black font-inter h-14 leading-[normal] mt-[41px] text-center text-xl w-[486px]"
              onClick={() => navigate("/menupagina")}
              shape="round"
              color="blue_gray_100_01"
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

export default SignUpPaginaPage;
