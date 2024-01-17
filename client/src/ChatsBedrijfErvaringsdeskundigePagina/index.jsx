import React from "react";

import { Button, Img, Input, Line, Text } from "components";

const ChatsBedrijfErvaringsdeskundigePaginaPage = () => {
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
                Chats
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
          <div className="flex flex-col gap-[50px] items-center justify-start w-[37%] md:w-full">
            <div className="bg-deep_orange-50 flex flex-col font-jockeyone gap-11 items-center justify-start py-[35px] rounded-[27px] w-full">
              <Input
                name="rowzoekhier"
                placeholder="Zoek hier..."
                className="!placeholder:text-gray-500 !text-gray-500 leading-[normal] p-0 text-left text-xl w-full"
                wrapClassName="flex outline outline-[3px] outline-black-900 w-[92%]"
                suffix={
                  <Img
                    className="h-[30px] mr-2 my-px"
                    src="images/img_image5.png"
                    alt="imageFour"
                  />
                }
                shape="round"
                color="deep_orange_50"
                size="xs"
                variant="fill"
              ></Input>
              <Line className="bg-blue_gray-100_02 h-0.5 mb-[430px] rotate-[180deg] w-full" />
            </div>
            <Button
              className="cursor-pointer font-black font-inter h-14 leading-[normal] text-center text-xl w-[486px]"
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

export default ChatsBedrijfErvaringsdeskundigePaginaPage;
