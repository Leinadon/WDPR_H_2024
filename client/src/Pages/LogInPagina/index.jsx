import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, CheckBox, Img, Input, Text } from "components";

const LogInPaginaPage = () => {
  const navigate = useNavigate();

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-inter items-center justify-start mx-auto p-9 sm:px-5 w-full">
        <div className="flex flex-col gap-[41px] items-center justify-start max-w-[1368px] mb-[79px] mt-2 mx-auto md:px-5 w-full">
          <div className="flex flex-col items-center justify-start w-full">
            <div className="flex flex-row font-jockeyone md:gap-10 gap-[885px] h-[104px] md:h-auto items-center justify-start max-w-[1368px] md:pl-10 sm:pl-5 pl-[121px] pr-2.5 py-2.5 w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400 w-auto"
                size="txtJockeyOneRegular60"
              >
                Login
              </Text>
              <Img
                className="md:h-auto h-full object-cover w-[104px]"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
              />
            </div>
            <div className="flex flex-col font-inter items-center justify-start mt-[41px] w-[33%] md:w-full">
              <div className="flex flex-col gap-[17px] h-[119px] md:h-auto items-start justify-center w-[425px] sm:w-full">
                <Text
                  className="text-4xl sm:text-[32px] md:text-[34px] text-white-A700 w-auto"
                  size="txtJockeyOneRegular36"
                >
                  Welkom Terug!
                </Text>
                <Text
                  className="text-base text-white-A700 w-auto"
                  size="txtInterMedium16"
                >
                  Login om verder te gaan
                </Text>
              </div>
              <div className="flex flex-col h-11 md:h-auto items-center justify-start mt-[17px] p-2.5 w-[434px] sm:w-full">
                <Text
                  className="text-white-A700 text-xl"
                  size="txtInterBlack20"
                >
                  Email
                </Text>
              </div>
              <Input
                name="rectangleSix"
                placeholder=""
                className="p-0 placeholder:bg-deep_orange-50 w-full"
                wrapClassName="bg-deep_orange-50 mt-[13px] rounded-[26px] w-full"
              ></Input>
              <div className="flex flex-col h-11 md:h-auto items-center justify-start mt-3.5 p-2.5 w-[434px] sm:w-full">
                <Text
                  className="text-white-A700 text-xl"
                  size="txtInterBlack20"
                >
                  Wachtwoord
                </Text>
              </div>
              <Input
                name="rectangleSeven"
                placeholder=""
                className="p-0 placeholder:bg-deep_orange-50 w-full"
                wrapClassName="bg-deep_orange-50 mt-[23px] rounded-[26px] w-full"
              ></Input>
              <div className="flex sm:flex-col flex-row sm:gap-5 items-start justify-start mt-6 w-[99%] md:w-full">
                <CheckBox
                  className="sm:mt-0 my-1"
                  inputClassName="bg-blue_gray-100 h-5 mr-[5px] rounded-[3px] w-5"
                  name="rectangleFive"
                  id="rectangleFive"
                ></CheckBox>
                <div className="flex flex-col h-[25px] md:h-auto items-center justify-start ml-2 sm:ml-[0] sm:mt-0 mt-1 w-[126px]">
                  <Text
                    className="text-white-A700 text-xl"
                    size="txtInterSemiBold20"
                  >
                    Onthoud mij
                  </Text>
                </div>
                <div className="flex flex-col h-[25px] md:h-auto items-center justify-start mb-1 sm:ml-[0] ml-[39px] p-2.5 w-[252px]">
                  <Text
                    className="text-white-A700 text-xl w-auto"
                    size="txtInterSemiBold20"
                  >
                    Wachtwoord vergeten?
                  </Text>
                </div>
              </div>
            </div>
            <Button
              className="common-pointer cursor-pointer font-black font-inter h-14 leading-[normal] mt-[57px] text-center text-xl w-[456px]"
              onClick={() => navigate("/loginpagina")}
              shape="round"
              color="teal_400"
              size="lg"
              variant="fill"
            >
              Login
            </Button>
          </div>
          <div
            className="common-pointer flex flex-col h-[39px] md:h-auto items-center justify-center p-2.5 w-[446px] sm:w-full"
            onClick={() => navigate("/signuppagina")}
          >
            <Text
              className="text-3xl sm:text-[26px] md:text-[28px] text-center text-white-A700 w-auto"
              size="txtInterSemiBold30"
            >
              <span className="text-white-A700 font-inter font-semibold">
                Nog geen account?{" "}
              </span>
              {/* <a
                href="javascript:"
                className="text-gray-400 font-inter font-black underline"
              >
                Sign Up
              </a> */}
            </Text>
          </div>
        </div>
      </div>
    </>
  );
};

export default LogInPaginaPage;
