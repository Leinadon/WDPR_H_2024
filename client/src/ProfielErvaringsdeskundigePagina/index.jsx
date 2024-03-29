import React, { useState, useEffect } from "react";

import axios from "axios";

import { useNavigate } from "react-router-dom";

import { Button, Img, Text, Input } from "components";

const ProfielErvaringsdeskundigePaginaPage = () => {
  const [jsonData, setJsonData] = useState({});
  const [selectedProfile, setSelectedProfile] = useState(null);
  const [showModal, setShowModal] = useState(false);
  const profilePictures = [
    "image1.png", "image2.png", "image3.png","image4.png", "image5.png",  
  ];
  const handleProfileClick = (profile) => {
    setSelectedProfile(profile);
  };
  const handleToggleModal = () => {
    setShowModal(!showModal);
  };
  const handleConfirm = () => {
    setShowModal(false);
  };
  const defaultProfile = "image_StockPicture.png";
  const navigate = useNavigate();

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get("https://accessibilityh.azurewebsites.net/api/users/6");
        const data = await response.data;
        setJsonData(data);
      } catch (error) {
        console.error("Error fetching JSON data:", error);
        console.log("Server Response:", error.response); // Log the response for more details
      }
    };

    fetchData();
  }, []);

  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col justify-start max-w-[1440px] mb-[108px] mx-auto w-full">
          <div className="flex flex-col items-center justify-start w-full">
            <div className="flex flex-row font-jockeyone md:gap-10 gap-[885px] h-[104px] md:h-auto items-center justify-start max-w-[1368px] md:pl-10 sm:pl-5 pl-[121px] pr-2.5 py-2.5 w-full">
              <Text
                className="md:text-5xl text-6xl text-teal-400 items-left ml-[-64.5px]"
                size="txtJockeyOneRegular60"
              >
                Profiel
              </Text>
              <Img
                className="md:h-auto h-full items-right object-cover ml-[80px] max-w-[104px]"
                src="images/img_Logo.png"
                alt="Logo Accessability"
                onClick={() => navigate("/menupagina")}
              />
            </div>
            <div className="flex flex-col font-inter items-center justify-start w-[600px] mt-[60px] md:w-full ">
              <div className="md:h-[150px] h-[291px] relative w-full">
                <div className="absolute bottom-[19%] h-[119px] md:h-[42px] inset-x-[0] mx-auto w-full">
                  <div className="absolute flex flex-col h-[65px] md:h-auto items-center justify-center p-2.5 right-[0%] top-[0] w-60">
                    <Button
                      className="bg-transparent cursor-pointer font-black leading-[normal] min-w-[220px] mt-[12px] text-base text-center text-white-A700 underline"
                      onClick={handleToggleModal}
                    >
                      Verander Profiel afbeelding
                    </Button>
                  </div>
                  <div className="absolute bottom-[0] flex flex-col h-[61px] md:h-auto inset-x-[0] items-left justify-center mx-auto p-2.5 w-[600px] sm:w-full">
                    <label
                      htmlFor="myInput"
                      className="mt-[40px]"
                      style={{
                        color: "white",
                        fontSize: "20px",
                        fontWeight: "bold",
                      }}
                    >
                      Naam:{" "}
                    </label>
                    <Input
                      className="text-lg text-white-A700 w-auto ml-[-12px] mt-[2px]"
                      size="txtInterBlack18"
                      style={{ color: "white", fontSize: "18px" }}
                      value={`${jsonData.firstName || ""} ${
                        jsonData.lastName || ""
                      }`}
                    ></Input>
                  </div>
                </div>
                <div className="absolute bottom-[0] flex flex-col h-[61px] md:h-auto inset-x-[0] items-left justify-center mb-[-30px] mx-auto p-2.5 w-[600px] sm:w-full">
                  <label
                    htmlFor="myInput"
                    className="mt-[40px]"
                    style={{
                      color: "white",
                      fontSize: "20px",
                      fontWeight: "bold",
                    }}
                  >
                    Email:{" "}
                  </label>
                  <Input
                    className="text-lg text-white-A700 w-auto ml-[-12px] mt-[2px]"
                    size="txtInterBlack18"
                    style={{ color: "white", fontSize: "18px" }}
                    value={jsonData.email}
                  ></Input>
                </div>
                {showModal && (
                  <div className="modal flex-direction: column justify-content -center">
                    <div className="modal-content mt-[-30px] ml-[12px]">
                      <h2 style={{ color: "white", fontSize: "20px", fontWeight: "bold",}}>Selecteer Profiel Afbeelding:</h2>
                      <div className="profile-container" style={{ display: "flex", justifyContent: "space-between",alignItems: "flex-start",}}>
                        {profilePictures.map((profile, index) => (
                          <img
                            key={index}
                            src={`./profile_images/${profile}`}
                            alt={`image ${index + 1}`}
                            className={`profile-image ${
                              selectedProfile === profile ? "selected" : ""
                            }`}
                            style={{cursor: "pointer",}}
                            onClick={() => handleProfileClick(profile)}
                          />
                        ))}
                      </div>
                      <button className="confirm-button mt-[20px] ml-[-2px]" style={{ color: 'white', fontSize: "20px", fontWeight: "bold", textDecoration: 'underline', }} onClick={handleToggleModal}>Bevestig</button>
                    </div>
                  </div>
                )}

                {(selectedProfile || showModal) && !showModal && (
                  <div>
                    <img
                      src={`./profile_images/${
                        selectedProfile || defaultProfile
                      }`}
                      alt="Selected Profile"
                      className="selected-profile-image mt-[-48px] ml-[6px]"
                      style={{ width: "200px", height: "200px",}}
                    />
                  </div>
                )}

                {!selectedProfile && !showModal && (
                  <div>
                    <img
                      src={`./profile_images/${defaultProfile}`}
                      alt="Default Profile"
                      className="default-profile-image mt-[-48px] ml-[6px]"
                      style={{ width: "200px", height: "200px",}}
                      onClick={handleToggleModal}
                    />
                  </div>
                )}
              </div>
              <div className="flex flex-col h-[117px] md:h-auto items-left justify-center mt-[15px] p-2.5 w-[600px] mt-[30px] sm:w-full">
                <label
                  htmlFor="myInput"
                  className="mt-[40px]"
                  style={{
                    color: "white",
                    fontSize: "20px",
                    fontWeight: "bold",
                  }}
                >
                  Geboortedatum:{" "}
                </label>
                <Input
                  className="text-lg text-white-A700 w-auto ml-[-12px] mt-[2px]"
                  size="txtInterBlack18"
                  style={{ color: "white", fontSize: "18px" }}
                  value={jsonData.birthDate}
                ></Input>
              </div>
              <div className="flex flex-col h-[115px] md:h-auto items-left justify-center p-2.5 w-[600px] mt-[-30px] sm:w-full">
                <label
                  htmlFor="myInput"
                  className="mt-[40px]"
                  style={{
                    color: "white",
                    fontSize: "20px",
                    fontWeight: "bold",
                  }}
                >
                  Telefoonnummer:{" "}
                </label>
                <Input
                  className="text-lg text-white-A700 w-auto ml-[-12px] mt-[2px]"
                  size="txtInterBlack18"
                  style={{ color: "white", fontSize: "18px" }}
                  value={jsonData.phone}
                ></Input>
              </div>
              <Button
                className="cursor-pointer flex h-[60px] items-center justify-center mt-[15px] w-[600px]"
                onClick={() => navigate("/profielpagina")}
                rightIcon={
                  <Img
                    className="md:h-auto h-full object-cover w-[50px]"
                    src="images/img_EditProfile.png"
                    alt="EditProfile"
                  />
                }
                shape="round"
                color="teal_400"
                size="md"
                variant="fill"
              >
                <div className="font-black leading-[normal] text-center text-xl">
                  Gegevens aanpassen
                </div>
              </Button>
              <Button
                className="cursor-pointer font-black h-[60px] leading-[normal] mt-[72px] text-center text-xl w-[600px]"
                shape="round"
                color="blue_gray_100_01"
                size="lg"
                variant="fill"
                onClick={() => navigate("/menupagina")}
              >
                Terug naar Menu
              </Button>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default ProfielErvaringsdeskundigePaginaPage;
