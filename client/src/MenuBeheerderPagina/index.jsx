import React, { useEffect } from "react";
import { useAuth } from '../AuthProvider';

import { useNavigate } from "react-router-dom";
import { Button, Img, Text } from "components";

const MenuBeheerderPaginaPage = () => {
  const navigate = useNavigate();
  const { auth, logout, user } = useAuth();

  useEffect(() => {
    console.log("print when arrived");
    // navigate("/unauthorized");
  },[])

  const menuClick = (destination) =>{
    console.log(destination);
    navigate(destination);
  };
  
  
  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col md:gap-10 gap-24 items-center justify-start max-w-[1337px] mb-[65px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-center p-2.5 w-[424px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400"
                size="txtJockeyOneRegular60"
              >
                Beheerder
              </Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start p-2.5 w-[116px]">
              <Img
                className="h-[79px] md:h-auto object-cover w-24"
                src="images/img_Logo.png"
                alt="Accessibility logo"
              />
            </div>
          </div>
          <div className="flex flex-col font-inter md:gap-10 gap-[74px] items-center justify-start w-[37%] md:w-full">
            <Button
              className="cursor-pointer flex h-14 items-center justify-center w-[486px]"
              rightIcon={
                <Img
                  className="h-11 ml-2.5"
                  src="images/img_image1.png"
                  alt="Profiel Icoon"
                />
              }
              shape="round"
              color="teal_400"
              size="sm"
              variant="fill"
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Profiel
              </div>
            </Button>
            <Button
              className="cursor-pointer flex h-14 items-center justify-center w-[486px]"
              rightIcon={
                <Img
                  className="h-11 ml-2.5"
                  src="images/img_AddInfoList.png"
                  alt="imageOne"
                />
              }
              shape="round"
              color="teal_400"
              size="md"
              variant="fill"
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Onderzoek Plaatsen
              </div>
            </Button>
            <Button
              className="cursor-pointer flex h-14 items-center justify-center w-[486px]"
              rightIcon={
                <Img
                className="h-11 ml-2.5"
                  src="images/img_barchart2.svg"
                  alt="Onderzoeks database"
                />
              }
              shape="round"
              color="teal_400"
              size="sm"
              variant="fill"
              // onClick={menuClick("/alle_onderzoeken")}
              onClick={() => navigate("/alle_onderzoeken")}
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Onderzoeken database
              </div>
            </Button>
            <Button
              className="cursor-pointer flex h-14 items-center justify-center w-[486px]"
              rightIcon={
                <Img
                className="h-11 ml-2.5"
                  src="images/img_InfoList.png"
                  alt="imageNine"
                />
              }
              shape="round"
              color="teal_400"
              size="sm"
              variant="fill"
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Informatie Lijsten
              </div>
            </Button>
            <Button
              className="cursor-pointer flex h-14 items-center justify-center w-[486px]"
              rightIcon={
                <Img
                className="h-11 ml-2.5"
                  src="images/img_AddCompany.png"
                  alt="imageEleven"
                />
              }
              onClick={() => navigate("/add_company")}
              shape="round"
              color="teal_400"
              size="sm"
              variant="fill"
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Bedrijf Toevoegen
              </div>
            </Button>
            <Button
              className="cursor-pointer flex h-14 items-center justify-center w-[486px]"
              rightIcon={
                <Img
                className="h-11 ml-2.5"
                  src="images/img_RemoveCompany.png"
                  alt="imageEleven_One"
                />
              }
              shape="round"
              color="teal_400"
              size="sm"
              variant="fill"
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Bedrijf Verwijderen
              </div>
            </Button>
            <Button
              className="cursor-pointer flex h-14 items-center justify-center w-[486px]"
              rightIcon={
                <Img
                  className="h-11 ml-2.5"
                  src="images/img_Chat.png"
                  alt="Chat Icoon"
                />
              }
              shape="round"
              color="teal_400"
              size="sm"
              variant="fill"
            >
              <div className="font-black leading-[normal] text-center text-xl">
                Chat
              </div>
            </Button>
          </div>
        </div>
      </div>
    </>
  );
};

export default MenuBeheerderPaginaPage;
