import { useNavigate } from "react-router-dom";

import { Button, Img, Input, Text, TextArea, CheckBox } from "components";

import React, { useState, useEffect } from "react";

import axios from "axios";

import Links from "Links";


const ProfielPaginaBedrijvenPage = () => {
  const [jsonData, setJsonData] = useState([]);
  const navigate = useNavigate();
  const LinkProfielPagina = new Links.LinkProfielPagina();
  const LinkBedrijf = new LinkProfielPagina.LinkBedrijf();

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get(LinkBedrijf.link);
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
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col justify-start max-w-[1440px] mb-[108px] mx-auto w-full">
          <div className="flex flex-col items-center justify-start w-full">
            <div className="flex flex-row font-jockeyone md:gap-10 gap-[885px] h-[104px] md:h-auto items-center justify-start max-w-[1368px] md:pl-10 sm:pl-5 pl-[121px] pr-2.5 py-2.5 w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400 items-left ml-[-60px]"
                size="txtJockeyOneRegular60"
              >
                Aanpassen
              </Text>
              <Img
                className="md:h-auto h-full items-right object-cover ml-[-20px] max-w-[104px]"
                src="images/img_Logo.png"
                alt="Accessibility Logo"
                onClick={() => navigate("/bedrijfmenupagina")}
              />
            </div>
          </div>
          <Text
            className="flex flex-col items-left justify-left ml-[410px] mt-[49px] text-4xl sm:text-[32px] md:text-[34px] text-white-A700"
            size="txtJockeyOneRegular36"
          >
            Pas hier je gegevens aan
          </Text>
          <div className="flex flex-col justify-center font-inter w-[600px] ml-[400px] mt-[35px] ">
            <div className="flex flex-col h-11 md:h-auto items-left justify-start  mr-5 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                <div>
                  <h1>Bedrijfsnaam</h1>
                </div>
              </Text>
            </div>
            <div>
            <Input
              name="rectanglethree"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              value={jsonData.bedrijfsnaam}
              type="text"
              style={{ fontSize: "20px", color: 'black'}}
            ></Input>
            </div>
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
              value={jsonData.email}
              style={{ fontSize: "20px" }}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Link van website
              </Text>
            </div>
            <Input
              name="rectanglefour"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              value={jsonData.link}
              style={{ fontSize: "20px" }}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Bedrijfslocatie
              </Text>
            </div>
            <Input
              name="rectanglefive"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]" //wrapClassName="flex h-[54px] ml-6 md:ml-[0] mt-[0] w-[100%]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              value={jsonData.bedrijfslocatie}
              style={{ fontSize: "20px" }}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Telefoonnummer
              </Text>
            </div>
            <Input
              name="rectanglesix"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              value={jsonData.phone}
              style={{ fontSize: '20px' }}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Informatie over het bedrijf
              </Text>
            </div>
            <TextArea
              name="rectangleseven"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 items-center justify-center ml-[4px] max-w-[592px] mb-2.5 w-full rounded-[10px]"
              wrapClassName="flex h-[500px] ml-1 md:ml-[0] h-[500px] mt-1"
              shape="round"
              backgroundcolor="deep_orange_50"
              variant="fill"
              rows={12}
              style={{ fontSize: '20px', backgroundColor: '#f8f0e5', }}
            ></TextArea>
            <div>
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] mt-[113px] mr-3 text-center text-xl w-[600px]"
                shape="round"
                color="teal_400"
                size="lg"
                variant="fill"
              >
                {" "}
                Opslaan
              </Button>
            </div>
            <div>
              <Button
                className="cursor-pointer font-black h-14 leading-[normal] mt-[80px] text-center text-xl w-[600px]"
                shape="round"
                color="blue_gray_100_01"
                size="lg"
                variant="fill"
                onClick={() => navigate("/profielbedrijfpagina")}
              >
                {" "}
                Annuleren
              </Button>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default ProfielPaginaBedrijvenPage;
