import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, Img, List, Slider, Text } from "../components";

const LogInPaginaPage = () => {
  const navigate = useNavigate();

  const sliderRef = React.useRef(null);
  const [sliderState, setsliderState] = React.useState(0);

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col items-center justify-start max-w-[1332px] mb-[115px] mt-[43px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-start p-2.5 w-[460px] sm:w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400 w-auto"
                size="txtJockeyOneRegular60"
                as= "div"
              >
                Log In
              </Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-start justify-start p-2.5 w-[116px]">
              <Img
                className="h-[79px] md:h-auto object-cover w-24 sm:w-full"
                src="images/img_reshotillustra.png"
                alt="reshotillustra"
              />
            </div>
          </div>
          <div className="flex flex-col gap-[17px] h-[119px] md:h-auto items-start justify-center md:ml-[0] ml-[441.8px] mt-[42px] w-[425px] sm:w-full">
            <Text
              className="text-4xl sm:text-[32px] md:text-[34px] text-white-A700 w-auto"
              size="txtJockeyOneRegular36"
              as= "div"
            >
              Welkom Terug!
            </Text>
            <Text
              className="text-base text-white-A700 w-auto"
              size="txtInterMedium16"
              as= "div"
            >
              Login om verder te gaan
            </Text>
          </div>
          <div className="flex flex-col font-inter items-center justify-start md:ml-[0] ml-[427px] mt-[17px] w-[35%] md:w-full">
            <List
              className="flex flex-col gap-[17px] items-center w-full"
              orientation="vertical"
            >
              <div className="h-[107px] my-0 relative w-full">
                <div className="flex flex-col h-11 md:h-auto items-center justify-start mb-[-9.55px] ml-[5.8px] mr-[26.2px] p-2.5 w-[434px] sm:w-full z-[1]">
                  <Text
                    className="text-white-A700 text-xl"
                    size="txtInterBlack20"
                    as= "div"
                  >
                    Email
                  </Text>
                </div>
                {/* <Slider
                  activeIndex={sliderState}
                  responsive={{
                    0: { items: 1 },
                    550: { items: 1 },
                    1050: { items: 1 },
                  }}
                  onSlideChanged={(e) => {
                    setsliderState(e?.item);
                  }}
                  ref={sliderRef}
                  className="cursor-pointer mt-[34px] w-full"
                  items={[...Array(3)].map(() => (
                    <React.Fragment key={Math.random()}>
                      <Img
                        className="h-[73px] mx-2.5"
                        src="images/img_frame21.svg"
                        alt="frameTwentyOne"
                      />
                    </React.Fragment>
                  ))}
                /> */}
              </div>
              <div className="h-[117px] my-0 relative w-full">
                <div className="flex flex-col h-11 md:h-auto items-center justify-start mb-[-0.36px] ml-[5.8px] mr-[26.2px] p-2.5 w-[434px] sm:w-full z-[1]">
                  <Text
                    className="text-white-A700 text-xl"
                    size="txtInterBlack20"
                    as= "div"
                  >
                    Wachtwoord
                  </Text>
                </div>
                {/* <Img
                  className="cursor-pointer h-[73px] mb-[0.36px] mt-auto mx-auto w-[466px]"
                  src="images/img_frame21.svg"
                  alt="frameTwentyTwo"
                  onClick={() => sliderRef.current?.slideNext?.()}
                /> */}
              </div>
            </List>
            <div className="h-7 md:h-[66px] md:ml-[0] ml-[18.8px] mt-7 relative w-[94%] sm:w-full">
              <div className="absolute bottom-[0] flex flex-row gap-[9px] h-[25px] md:h-auto items-center justify-start left-[0] right-[55%] top-[11%] w-[197px]">
                <div className="bg-blue_gray-100 h-5 rounded-[3px] w-[21px]"></div>
                <Text
                  className="flex-1 text-white-A700 text-xl"
                  size="txtInterSemiBold20"
                  as= "div"
                >
                  Onthoud mij
                </Text>
              </div>
              <div className="absolute bottom-[11%] flex flex-col h-[25px] md:h-auto items-center justify-start left-[42%] p-2.5 right-[0] top-[0] w-[252px]">
                <Text
                  className="text-white-A700 text-xl w-auto"
                  size="txtInterSemiBold20"
                  as= "div"
                >
                  Wachtwoord vergeten?
                </Text>
              </div>
            </div>
            <Button
              className="common-pointer cursor-pointer font-black h-14 leading-[normal] md:ml-[0] ml-[4.91px] mr-[5.09px] mt-[58.29px] text-center text-xl w-[456px]"
              onClick={() => navigate("/loginpagina")}
              shape="round"
              color="teal_400"
              variant="fill"
              leftIcon
              rightIcon
            >
              Login
            </Button>
            <Button
              className="common-pointer bg-transparent cursor-pointer font-semibold h-[39px] leading-[normal] md:ml-[0] ml-[9.8px] mt-[40.71px] text-3xl sm:text-[26px] md:text-[28px] text-center text-white-A700 w-[446px]"
              onClick={() => navigate("/signuppagina")}
              size="xs"
              leftIcon
              rightIcon
            >
              Nog geen account? Sign Up
            </Button>
          </div>
        </div>
      </div>
    </>
  );
};

export default LogInPaginaPage;
