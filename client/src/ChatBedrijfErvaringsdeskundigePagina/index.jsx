import React from "react";

import { Img, Line, Text } from "components";

const ChatBedrijfErvaringsdeskundigePaginaPage = () => {
  return (
    <>
      <div className="bg-deep_orange-50 flex flex-col font-jockeyone items-center justify-start mx-auto pb-[18px] w-full">
        <div className="flex flex-col items-center justify-start w-full">
          <div className="bg-blue_gray-900 flex md:flex-col flex-row md:gap-5 items-center justify-start px-1 w-full">
            <Img
              className="h-[90px] md:h-auto object-cover w-[90px]"
              src="images/img_Logo.png"
              alt="download5remove"
            />
            <Line className="bg-blue_gray-900_01 md:h-[3px] h-[90px] ml-1 md:ml-[0] w-[3px] md:w-full" />
            <Img
              className="h-[50px] md:h-auto ml-5 md:ml-[0] object-cover w-[50px]"
              src="images/img_images2modified.png"
              alt="images2modified"
            />
            <Img
              className="h-[60px] md:h-auto md:ml-[0] ml-[1191px] object-cover w-[60px]"
              src="images/img_imagesremovebgpreview.png"
              alt="imagesremovebgp"
            />
          </div>
          <Line className="bg-black-900 h-px mt-[757px] rotate-[-180deg] w-full" />
          <div className="flex flex-row md:gap-10 items-end justify-between max-w-[1381px] mt-4 mx-auto md:px-5 w-full">
            <Text
              className="mt-2 sm:text-2xl md:text-[26px] text-[28px] text-gray-400_01"
              size="txtJockeyOneRegular28"
            >
              Klik hier om te typen...
            </Text>
            <Img
              className="h-[50px] md:h-auto object-cover w-[50px]"
              src="images/img_image11.png"
              alt="imageeleven"
            />
          </div>
        </div>
      </div>
    </>
  );
};

export default ChatBedrijfErvaringsdeskundigePaginaPage;
