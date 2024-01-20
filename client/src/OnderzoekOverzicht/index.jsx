import React, { useEffect, useState } from "react";

import { Button, Img, Input, Line, Text } from "components";

const OnderzoekOverzicht = () => {
  const [listWithResearches, setData] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch('https://localhost:7258/api/research/researches');
        const result = await response.json();

        setData(result);
      } catch (error) {
        console.error('Error fetching data:', error);
      }
    };


    fetchData();
  }, []);


  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col gap-[19px] items-center justify-start max-w-[1337px] mb-[17px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-center p-2.5 w-[465px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400"
                size="txtJockeyOneRegular60"
              >
                Onderzoeken
              </Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start p-2.5 w-[116px]">
              <Img
                className="md:h-auto h-full object-cover w-full"
                src="images/img_Logo.png"
                alt="Accessibility Logo"
              />
            </div>
          </div>
          <div className="flex flex-col gap-[50px] items-center justify-start w-[37%] md:w-full">
            <div className="bg-deep_orange-50 flex flex-col font-jockeyone gap-11 items-center justify-start py-[35px] rounded-[27px] w-full">
              <Input
                name="rowzoekhier"
                placeholder="Typ hier om een onderzoek te zoeken"
                className="!placeholder:text-gray-500 !text-gray-500 leading-[normal] p-0 text-left text-xl w-full"
                wrapClassName="flex outline outline-[3px] outline-black-900 w-[92%]"
                suffix={
                  <Img
                    className="h-[30px] mr-2 my-px"
                    src="images/img_image5.png"
                    alt="Zoek icoon"
                  />
                }
                shape="round"
                color="deep_orange_50"
                size="xs"
                variant="fill"
              ></Input>
              <div className="bg-blue_gray-100_02 w-full  h-96 mb-8 overflow-y-auto">
                <ul className="">
                  {listWithResearches.map(research => (
                    <li key={research.id}>
                      <div key={research.id} className="border rounded p-4 m-4 max-w-m">
                        <h3 className="text-lg font-semibold mb-2">{research.title}</h3>
                        <div className="max-h-32 overflow-y-auto">
                          <p>{research.description}</p>
                          <p>Datum: {research.startDate}</p>
                        </div>
                      </div>
                      <br />
                    </li>
                  ))}
                </ul>
              </div>

            </div>
            <Button
              className="cursor-pointer font-black font-inter h-14 leading-[normal] text-center text-xl w-[486px]"
              shape="round"
              color="blue_gray_100_01"
              size="lg"
              variant="fill"
            >
              Terug naar het menu
            </Button>
          </div>
        </div>
      </div>
    </>
  );
};

export default OnderzoekOverzicht;
