import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, Img, Text } from "components";

const MenuPaginaPage = () => {
  const navigate = useNavigate();

  return (
    <>
       <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col justify-start max-w-[1440px] mb-[108px] mx-auto w-full">
          <div className="flex flex-col items-center justify-start w-full">
            <div className="flex flex-row font-jockeyone md:gap-10 gap-[885px] h-[104px] md:h-auto items-center justify-start max-w-[1368px] md:pl-10 sm:pl-5 pl-[121px] pr-2.5 py-2.5 w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400 items-left"
                size="txtJockeyOneRegular60"
              >
                Menu
              </Text>
              <Img
                className="md:h-auto h-full items-right object-cover w-[104px]"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
              />
            </div>
          </div>
        <div className="flex flex-col font-inter md:gap-10 gap-[74px] items-center justify-start mt-[60px] mb-[228px] md:px-5 w-[100%] md:w-full">
          <Button
            className="common-pointer cursor-pointer flex h-14 items-center justify-center w-[486px]"
            onClick={() => navigate("/profielpagina")}
            rightIcon={
              <Img
                className="h-[46px] ml-2.5 mr-[177px]"
                src="images/img_image1.png"
                alt="imageOne"
              />
            }
            shape="round"
            color="teal_400"
            size="sm" 
            variant="fill"
          >
            <div className="font-black leading-[normal] text-center ml-[180px] text-xl">
              Profiel
            </div>
          </Button>
          <Button
            className="common-pointer cursor-pointer flex h-14 items-center justify-center w-[486px]"
            onClick={() => navigate("/onderzoekpagina")}
            rightIcon={
              <Img
                className="h-[47px] ml-2.5 mr-[142px]"
                src="images/img_reading.png"
                alt="reading"
              />
            }
            shape="round"
            color="teal_400"
            size="sm"
            variant="fill"
          >
            <div className="font-black leading-[normal] text-center ml-[140px] text-xl">
              Onderzoeken
            </div>
          </Button>
          <Button
            className="common-pointer cursor-pointer flex h-14 items-center justify-center w-[486px]"
            onClick={() => navigate("/ondersteuningpagina")}
            rightIcon={
              <Img
                className="h-[47px] ml-2.5 mr-[142px]"
                src="images/img_image2.png"
                alt="imageTwo"
              />
            }
            shape="round"
            color="teal_400"
            size="sm"
            variant="fill"
          >
            <div className="font-black leading-[normal] text-center text-xl ml-[140px]">
              Ondersteuning
            </div>
          </Button>
          <Button
            className="common-pointer cursor-pointer flex h-14 items-center justify-center w-[486px]"
            onClick={() => navigate("/chatpagina")}
            rightIcon={
              <Img
                className="h-[47px] ml-2.5 mr-[142px]"
                src="images/img_image2_44x46.png"
                alt="imageTwo_One"
              />
            }
            shape="round"
            color="teal_400"
            size="sm"
            variant="fill"
          >
            <div className="font-black leading-[normal] text-center text-xl ml-[140px]">
              Chats
            </div>
          </Button>
        </div>
      </div>
      </div>
    </>
  );
};

export default MenuPaginaPage;
