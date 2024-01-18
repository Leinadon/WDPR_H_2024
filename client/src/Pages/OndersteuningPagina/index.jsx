import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, Img, Input, Text, TextArea } from "components";

const OndersteuningPaginaPage = () => {
  const navigate = useNavigate();

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col justify-start max-w-[1440px] mb-[108px] mx-auto w-full">
          <div className="flex flex-col items-center justify-start w-full">
            <div className="flex flex-row font-jockeyone md:gap-10 gap-[885px] h-[104px] md:h-auto items-center justify-start max-w-[1368px] md:pl-10 sm:pl-5 pl-[121px] pr-2.5 py-2.5 w-full">
            <Text
                className="md:text-5xl text-6xl text-teal-400 items-left ml-[-60px]"
                size="txtJockeyOneRegular60"
            >
              Ondersteuning
            </Text>
            <Img
                className="md:h-auto h-full items-right object-cover ml-[-188.5px] w-[104px]"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
                onClick={() => navigate("/menupagina")}
              />
          </div>
            </div>
          </div>
          <Text
            className="flex flex-col items-left justify-left w-[600px] mb-[30px] text-4xl sm:text-[32px] md:text-[34px] text-white-A700"
            size="txtJockeyOneRegular36"
          >
            Veelgestelde vragen:
          </Text>
          <div className="flex flex-col font-inter gap-[21px] h-[580px] md:h-auto items-left justify-center mt-[27px] w-[600px] sm:w-full">
            <Text
              className="text-lg text-white-A700 w-auto"
              size="txtInterBlack18"
            >
              1. Wat is het doel van deze website?
            </Text>
            <Text
              className="max-w-[600px] md:max-w-full text-sm text-white-A700"
              size="txtInterSemiBold20"
            >
              Om bedrijven onderzoek te laten doen om Accessibility op hun
              websites te testen en te verbeteren.
            </Text>
            <Text
              className="max-w-[600px] md:max-w-full text-lg text-white-A700"
              size="txtInterBlack18"
            >
              2. Hoe komen gebruikers in contact met de klantenservice?
            </Text>
            <Text
              className="max-w-[600px] md:max-w-full text-sm text-white-A700"
              size="txtInterSemiBold20"
            >
              Onder aan deze pagina kunt u een bericht versturen naar onze
              klantenservice die u bericht zo snel mogelijk zal beantwoorden.
            </Text>
            <Text
              className="text-lg text-white-A700 w-auto"
              size="txtInterBlack18"
            >
              3. Hoe doe ik mee aan een onderzoek?
            </Text>
            <Text
              className="max-w-[600px] md:max-w-full text-sm text-white-A700"
              size="txtInterSemiBold20"
            >
              U kunt uitgenodigd worden via de mail om een een onderzoek mee te
              doen.
            </Text>
            <Text
              className="text-lg text-white-A700 w-auto"
              size="txtInterBlack18"
            >
              4. Hoe verander ik mijn wachtwoord?
            </Text>
            <Text
              className="max-w-[600px] md:max-w-full text-sm text-white-A700"
              size="txtInterSemiBold20"
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
              5. Hoe chat ik met een bedrijf?
            </Text>
            <Text
              className="max-w-[600px] md:max-w-full text-sm text-white-A700"
              size="txtInterSemiBold20"
            >
              U kan chatten met een bedrijf bij uw chatoverzicht. Klik op ‘terug
              naar menu’ onder aan de pagina klik daarna op de knop met ‘chats’
              en zoek voor uw gewenst bedrijf waar uw mee wil chatten. Klik op
              het gewenste bedrijf en nu kan u hier berichten sturen naar
              bedrijven.
            </Text>
          </div>
          <div className="flex flex-col font-jockeyone h-[90px] md:h-auto items-left justify-center mt-[45px] p-2.5 w-[600px] ml-[-20px] sm:w-full">
            <Text
              className="text-4xl sm:text-[32px] md:text-[34px] text-white-A700 w-72"
              size="txtJockeyOneRegular36"
            >
              Stuur ons een bericht!
            </Text>
          </div>
          <div className="flex flex-col font-inter items-left justify-start mt-[18px] ml-[-18px] w-[600px] md:w-full">
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[600px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Naam
              </Text>
            </div>
            <Input
              name="rectangleseven"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: '20px' }}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Email
              </Text>
            </div>
            <Input
              name="rectangleseven"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: '20px' }}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Onderwerp
              </Text>
            </div>
            <Input
              name="rectangleseven"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: '20px' }}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Bericht
              </Text>
            </div>
            <TextArea
              name="rectangleseven"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[500px] ml-1 md:ml-[0] h-[500px] mt-1 rounded-[54px]"
              shape="round"
              backgroundcolor="deep_orange_50"
              variant="fill"
              rows={12}
              style={{ fontSize: '20px', backgroundColor: '#f8f0e5', }}
            ></TextArea>
            <Button
              className="cursor-pointer font-black h-14 leading-[normal] mt-11 text-center text-xl w-[600px]"
              shape="round"
              color="teal_400"
              size="lg"
              variant="fill"
            >
              Verstuur Bericht
            </Button>
            <Button
              className="common-pointer cursor-pointer font-black h-14 leading-[normal] mt-[41px] text-center text-xl w-[600px]"
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
    </>
  );
};

export default OndersteuningPaginaPage;
