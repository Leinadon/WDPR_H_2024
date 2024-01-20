
import { useNavigate } from "react-router-dom";

import { Button, Img, Input, Text, TextArea } from "components";

import React, { useState, useEffect } from "react";

import axios from "axios";


const ProfielPaginaBedrijvenPage = () => {
  const [jsonData, setJsonData] = useState([]);
  const navigate = useNavigate();

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get('https://localhost:7258/api/companies/1');
        const data = await response.data;
        setJsonData(data);
      } catch (error) {
        console.error('Error fetching JSON data:', error);
        console.log('Server Response:', error.response); // Log the response for more details
      }
    };

    fetchData();
  }, []); // Run once on component mount

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-5 w-full">
        <div className="flex flex-col justify-start max-w-[1440px] mb-[108px] mx-auto w-full">
          <div className="flex flex-col items-center justify-start w-full">
            <div className="flex flex-row font-jockeyone md:gap-10 gap-[885px] h-[104px] md:h-auto items-center justify-start max-w-[1368px] md:pl-10 sm:pl-5 pl-[121px] pr-2.5 py-2.5 w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400"
                size="txtJockeyOneRegular60"
              >
                Profiel Bedrijven
              </Text>
              <Img
                className="md:h-auto h-full items-right object-cover ml-[-100px] max-w-[104px]"
                src="images/img_Logo.png"
                alt="Accessibility Logo"
                onClick={() => navigate("/menupagina")} //NOG VERANDEREN
              />
            </div>
          </div>
          <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
          </div>
          <div>
            {Array.isArray(jsonData) ? (
              jsonData.map((jsonData, index) => (
                <div key={index}>
                  <p>Name: {jsonData.name}</p>
                </div>
              ))
            ) : (
              <p></p>
            )}
          </div>
        </div>
        <div>
          <div>
            <Text className="mt-[31px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Bedrijfsnaam
            </Text>
            <Input
              name="rectanglenine"
              placeholder=""
              className="p-0 w-full"
              wrapClassName="flex h-[49px] mt-2 rounded-[24px] w-full"
              color="deep_orange_50"
              value={jsonData.name}
              variant="fill"
              style={{ fontSize: "20px", color: 'black' }}
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
              value={jsonData.contactEmail}
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
              value={jsonData.websiteURL}
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
              value={jsonData.location}
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
              className="cursor-pointer font-black h-14 leading-[normal] mt-[60px] mb-10 text-center text-xl w-[486px]"
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
