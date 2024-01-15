import React from "react";

import { useNavigate } from "react-router-dom";

import { Img, Line, Text } from "components";

const ChatPaginaPage = () => {
  const navigate = useNavigate();

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[45px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col gap-[17px] items-center justify-start max-w-[1332px] mb-[121px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-start p-2.5 w-[460px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400 w-auto"
                size="txtJockeyOneRegular60"
              >
                Chats
              </Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start p-2.5 w-[116px]">
              <Img
                className="common-pointer md:h-auto h-full object-cover w-full"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
                onClick={() => navigate("/menupagina")}
              />
            </div>
          </div>
          <div className="bg-deep_orange-50 flex flex-col gap-[58px] items-center justify-start py-[21px] rounded-[27px] w-[37%] md:w-full">
            <div className="bg-deep_orange-50 border-[3px] border-black-900 border-solid flex flex-row items-center justify-between p-3 rounded-[27px] w-[92%] md:w-full">
              <Text
                className="text-gray-500 text-xl w-[1000px]"
                size="txtJockeyOneRegular20"
              >
                Zoek hier...
              </Text>
              <Img
                className="h-[30px] md:h-auto mr-[7px] object-cover w-[30px]"
                src="images/img_image5.png"
                alt="imagefive"
              />
            </div>
            <Line className="bg-blue_gray-100_02 h-0.5 mb-[444px] rotate-[180deg] w-full" />
          </div>
        </div>
      </div>
    </>
  );
};

export default ChatPaginaPage;
