import React from "react";

import { Img, Line, Text } from "components";

const InformatieLijstenBeheerderPaginaPage = () => {
  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[45px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col gap-[19px] items-center justify-start max-w-[1337px] mb-[145px] mx-auto w-full">
          <div className="flex md:flex-col flex-row md:gap-10 items-start justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[115px] md:h-auto items-center justify-start md:mt-0 mt-1.5 p-2.5 w-[514px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400"
                size="txtJockeyOneRegular60"
              >
                Lijsten
              </Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start p-2.5 w-[116px]">
              <Img
                className="md:h-auto h-full object-cover w-full"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
              />
            </div>
          </div>
          <div className="flex flex-col font-inter items-start justify-start w-[53%] md:w-full">
            <Text className="text-white-A700 text-xl" size="txtInterBlack20">
              Ervaringsdeskundigen Lijst
            </Text>
            <div className="h-[298px] md:h-[318px] sm:h-[376px] mt-5 relative w-full">
              <div className="h-[298px] sm:h-[356px] m-auto w-full">
                <div className="absolute bg-deep_orange-50 flex sm:flex-col flex-row sm:gap-10 h-max inset-[0] items-center justify-between m-auto p-[15px] rounded-[27px] w-full">
                  <Text
                    className="sm:ml-[0] ml-[132px] text-black-900 text-center text-xl"
                    size="txtInterBlack20Black900"
                  >
                    Email
                  </Text>
                  <Text
                    className="mb-[213px] sm:mt-0 mt-[5px] text-black-900 text-center text-xl"
                    size="txtInterBlack20Black900"
                  >
                    <>
                      Ingevulde <br />
                      Informatie
                    </>
                  </Text>
                </div>
                <Line className="absolute bg-black-900 h-[298px] inset-[0] justify-center m-auto w-px" />
              </div>
              <Line className="absolute bg-black-900 h-px inset-x-[0] mx-auto top-[31%] w-full" />
            </div>
            <Text
              className="mt-[51px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Onderzoeken Lijst
            </Text>
            <div className="bg-deep_orange-50 h-[297px] md:h-[317px] mt-5 relative rounded-[27px] w-full">
              <Text
                className="ml-[106px] mt-[33px] text-black-900 text-center text-xl"
                size="txtInterBlack20Black900"
              >
                Onderzoeken
              </Text>
              <div className="absolute h-[297px] inset-[0] justify-center m-auto w-full">
                <div className="absolute flex flex-row gap-[138px] h-full inset-y-[0] items-start justify-center my-auto right-[20%] w-[30%]">
                  <Line className="bg-black-900 h-[297px] w-px" />
                  <Text
                    className="mt-8 text-black-900 text-center text-xl"
                    size="txtInterBlack20Black900"
                  >
                    Details
                  </Text>
                </div>
                <Line className="absolute bg-black-900 h-px inset-x-[0] mx-auto top-[30%] w-full" />
              </div>
            </div>
            <Text
              className="mt-[54px] text-white-A700 text-xl"
              size="txtInterBlack20"
            >
              Bedrijven Lijst
            </Text>
            <div className="bg-deep_orange-50 h-[297px] md:h-[317px] mt-5 relative rounded-[27px] w-full">
              <Text
                className="ml-[126px] mt-9 text-black-900 text-center text-xl"
                size="txtInterBlack20Black900"
              >
                Bedrijven
              </Text>
              <div className="absolute h-[297px] inset-[0] justify-center m-auto w-full">
                <div className="absolute flex flex-row gap-3.5 h-full inset-y-[0] items-start justify-center my-auto right-[2%] w-[48%]">
                  <Line className="bg-black-900 h-[297px] w-px" />
                  <Text
                    className="mt-[21px] text-black-900 text-center text-xl"
                    size="txtInterBlack20Black900"
                  >
                    <>
                      Uitgezette
                      <br />
                      Onderzoeken
                    </>
                  </Text>
                </div>
                <Line className="absolute bg-black-900 h-px inset-x-[0] mx-auto top-[32%] w-full" />
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default InformatieLijstenBeheerderPaginaPage;
