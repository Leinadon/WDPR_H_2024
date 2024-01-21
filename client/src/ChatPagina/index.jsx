import React from "react";

import { useNavigate } from "react-router-dom";

import { Img, Line, Text, Button, Input } from "components";

const ChatPaginaPage = () => {
  const navigate = useNavigate();

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-center mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col justify-center items-center max-w-[1440px] mb-[108px] mx-auto w-full">
          <div className="flex flex-col items-center justify-center w-full">
            <div className="flex flex-row font-jockeyone md:gap-10 gap-[885px] h-[104px] md:h-auto items-center justify-start max-w-[1368px] md:pl-10 sm:pl-5 pl-[121px] pr-2.5 py-2.5 w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400 items-left ml-[-60px]"
                size="txtJockeyOneRegular60"
              >
                Chats
              </Text>
              <Img
                className="md:h-auto h-full items-right object-cover max-w-[104px]"
                src="images/img_Logo.png"
                alt="Logo Accessobility"
                onClick={() => navigate("/menupagina")}
              />
            </div>
          </div>
          <div className="bg-deep_orange-50 flex flex-col gap-[58px] mt-[50px] items-center justify-center py-[21px] rounded-[27px] w-[600px] md:w-full">
            <div className="bg-deep_orange-50 border-[3px] h-[60px] mb-[-30px] border-black-900 border-solid flex flex-row items-center justify-between p-3 rounded-[27px] w-[560px] md:w-full">
              <Input
                name="rectanglethree"
                placeholder="Zoek hier..."
                className="p-0 placeholder:bg-deep_orange-50 w-full"
                wrapClassName="flex w-[450px] h-[30px] ml-1 md:ml-[0] rounded-[54px]"
                shape="round"
                color="deep_orange_50"
                variant="fill"
                style={{ fontSize: '20px' }}
              ></Input>
              <Button
                className=""
                wrapClassName=""
                shape=""
                color=""
                size="lg"
                variant="fill"
              >
                <Img
                  className="h-[30px] md:h-auto mr-[7px] object-cover w-[30px]"
                  src="images/img_Search.png"
                  alt="imagefive"
                />
              </Button>

            </div>
            <Line className="bg-blue_gray-100_02 h-0.5 mb-[480px] rotate-[180deg] w-full" />
          </div>
          <Button
            className="common-pointer cursor-pointer font-black h-14 leading-[normal] mr-2.5 mt-[60px] text-center text-xl w-[600px]"
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

export default ChatPaginaPage;
