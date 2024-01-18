import React from "react";

import { useNavigate } from "react-router-dom";
import { loginRequest } from "../msalConfig";
import { useMsal, MsalProvider } from '@azure/msal-react';

import { Button, CheckBox, Img, Input, Text } from "components";

const LogInPaginaPage = () => {
  const navigate = useNavigate();
  const { instance } = useMsal();

    let activeAccount;

    if (instance) {
        activeAccount = instance.getActiveAccount();
    }
    const handleLoginPopup = () => {
        /**
         * When using popup and silent APIs, we recommend setting the redirectUri to a blank page or a page
         * that does not implement MSAL. Keep in mind that all redirect routes must be registered with the application
         * For more information, please follow this link: https://github.com/AzureAD/microsoft-authentication-library-for-js/blob/dev/lib/msal-browser/docs/login-user.md#redirecturi-considerations
         */
        instance
            .loginPopup({
                ...loginRequest,
                redirectUri: '/MenuPagina',
            })
            .catch((error) => console.log(error));
    };



    const handleLogoutPopup = () => {
        instance
            .logoutPopup({
                mainWindowRedirectUri: '/', // redirects the top level app after logout
                account: instance.getActiveAccount(),
            })
            .catch((error) => console.log(error));
    };

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col justify-start max-w-[1440px] mb-[108px] mx-auto w-full">
          <div className="flex flex-col items-center justify-start w-full">
            <div className="flex flex-row font-jockeyone md:gap-10 gap-[885px] h-[104px] md:h-auto items-center justify-start max-w-[1368px] md:pl-10 sm:pl-5 pl-[121px] pr-2.5 py-2.5 w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400 items-left ml-[-50px]"
                size="txtJockeyOneRegular60"
              >
                Log In 
              </Text>
              <Img
                className="md:h-auto h-full items-right object-cover max-w-[104px]"
                src="images/img_Logo.png"
                alt="Accessibility Logo"
              />
            </div>
          </div>
          <Text
            className="flex flex-col items-left justify-left ml-[410px] mt-[49px] text-4xl sm:text-[32px] md:text-[34px] text-white-A700"
            size="txtJockeyOneRegular36"
          >
            Welkom Terug!
          </Text>
          <Text
            className="flex flex-col items-left justify-left ml-[410px] mt-[20px] text-4xl sm:text-[32px] md:text-[34px] text-white-A700"
            size="txtInterSemiBold20"
            style={{ fontSize: '20px' }}
          >
            Log in om verder te gaan
          </Text>
          <div className="flex flex-col justify-center font-inter w-[600px] ml-[400px] mt-[35px] ">
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Email
              </Text>
            </div>
            <Input
              name="rectanglethree"
              placeholder=""
              className="p-0 placeholder:bg-deep_orange-50 ml-3.5 mr-3.5 mt-2.5 mb-2.5 w-full"
              wrapClassName="flex h-[54px] ml-1 md:ml-[0] mt-1 rounded-[54px]"
              shape="round"
              color="deep_orange_50"
              variant="fill"
              style={{ fontSize: '20px' }}
            ></Input>
            <div className="flex flex-col h-11 md:h-auto items-left justify-start mr-3 p-2.5 mb-1.5 w-[500px] sm:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">
                Wachtwoord
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
              style={{ fontSize: '20px' }}
            ></Input>
              <div>
                <Button
                className="cursor-pointer font-black h-14 leading-[normal] mt-[100px] mr-3 text-center text-xl w-[600px]"
                onClick={() => navigate("/menupagina")}
                shape="round"
                color="teal_400"
                size="lg"
                variant="fill"
                > Log in
                </Button>
              </div>
            <Button
              className="common-pointer bg-transparent cursor-pointer font-semibold h-[39px] leading-[normal] ml-3 md:ml-[0] mt-[47px] text-3xl sm:text-[26px] md:text-[28px] items-center text-center text-white-A700 w-[600px]"
              onClick={() => navigate("/loginpagina")}
              size="xs"
            ></Button>
              <div>
                <Text
                className="flex flex-col items-center justify-center mt-[-60px] text-4xl sm:text-[32px] md:text-[34px] text-white-A700"
                size="text-white-A700 font-inter font-semibold"
                style={{ fontSize: '28px' }}
                >
                Of
                </Text>
              </div>
            <div>
                <Button
                className="cursor-pointer font-black h-14 leading-[normal] mt-[10px] mr-3 text-center text-xl w-[600px]"
                shape="round"
                color="teal_400"
                size="lg"
                variant="fill"
                onClick={handleLoginPopup}
                > Log in met Microsoft
                </Button>
              </div>
            <div
            className="common-pointer flex flex-col h-[39px] md:h-auto items-center ml-[50px] justify-center p-2.5 w-[446px] sm:w-full"
            onClick={() => navigate("/signuppagina")}
          >
            <Text
              className="text-3xl text-right justify-right text-white-A700 mt-[50px] w-full"
              size="txtInterSemiBold30"
            >
              <span className="text-white-A700 font-inter font-semibold">
                Nog geen account?{" "}
              </span>
              <a
                href="javascript:"
                className="text-gray-400 font-inter font-black underline"
              >
                Sign up
              </a>
            </Text>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};  

export default LogInPaginaPage;
