import React, { useEffect, useState } from "react";

import axios from "axios";

import { useNavigate } from "react-router-dom";

import { Button, CheckBox, Img, Input, Text, TextArea } from "components";

const OnderzoekPlaatsenBedrijfPaginaPage = () => {
  const [knopNederlands, setNederlands] = useState('#CCCCCC');
  const [knopEngels, setEngels] = useState('#CCCCCC');

  
  const navigate = useNavigate();
  const selectedColor = '#1ca883';
  
  const [title, setTitle] = useState();
  const [english, setLanguage] = useState(false);
  const [description, setDescription] = useState();
  const [startdate, setStartdate] = useState();
  const [location, setLocation] = useState();
  const [reward, setReward] = useState();
  const [disabilityType, setDisability] = useState();
  
  
  const handleButtonClick = (state) => {
    if (state) {
      
      setEngels(selectedColor);
      setNederlands('#CCCCCC');
    } else {
      
      setNederlands(selectedColor);
      setEngels('#CCCCCC');
    }
  };
  useEffect(() => {
    console.log("research in english: "+english)
    handleButtonClick(english);
  }, [english])


  function CreateResearch() {
    console.log(startdate)
    console.log(disabilityType)

    fetch("https://accessibilityh.azurewebsites.net/api/research/interview/", {

      method: "POST",
      mode: "cors",
      headers: {
        'Access-Control-Allow-Origin': '*',
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({
        "title": title,
        "description": description,
        "startDate": startdate,
        "reward": reward,
        "status": "Open",

        "companyId": 2, //AANPASSEN

        "english": english,
        "disabilityTypeId": disabilityType,
        
        "disabilityType": {
          "id": disabilityType,
          "type": "disability",
          "details": "details"
        }
      })
    }
    ).then(response => response.json())
      .then(data => console.log(data));
  }


  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col justify-start max-w-[1440px] mb-[108px] mx-auto w-full">
          <div className="flex flex-col items-center justify-start w-full">
            <div className="flex flex-row font-jockeyone md:gap-10 gap-[885px] h-[104px] md:h-auto items-center justify-start max-w-[1368px]  md:pl-10 sm:pl-5 pl-[121px] pr-2.5 py-2.5 w-full">
                <Text
                  className="md:text-5xl text-6xl text-teal-400 items-left ml-[-60px]"
                  size="txtJockeyOneRegular60"
                > Onderzoek
                </Text>
                <Img
                className="md:h-auto h-full items-right object-cover ml-[-20px] max-w-[104px]"
                src="images/img_Logo.png"
                alt="Logo Accessability"
                onClick={() => navigate("/bedrijfmenupagina")}
              />
            </div>
          </div>
          <div className="flex flex-col justify-center font-inter w-[600px] ml-[420px] mt-[35px]">
            <Text className="mt-[22px] text-white-A700 text-xl" size="txtInterBlack20">Titel van het onderzoek</Text>
            <Input name="researchTitle" placeholder="Titel van het onderzoek" className="p-0 w-full" wrapClassName="flex h-[54px] mt-[17px] w-full" shape="round" color="deep_orange_50" variant="fill"
              id="title"
              data-testid ="title"
              value={title}
              // value=""
              // onChange={handleChange}
              onChange={
                (e) => setTitle(e.target.value)
              }
            ></Input>


            <Text className="mt-[22px] text-white-A700 text-xl" size="txtInterBlack20">Datum</Text>
            <Input name="datepicker" type="date" placeholder="" className="p-0 w-full" wrapClassName="flex h-[54px] mt-3.5 w-full" shape="round" color="deep_orange_50" variant="fill"
              value={startdate}
              onChange={
                (e) => setStartdate(e.target.value)
              }
            ></Input>



            <Text className="text-white-A700 text-xl mt-[20px]" size="txtInterBlack20">Soort onderzoek</Text>
            <div className="flex sm:flex-col flex-row gap-[33px] items-center justify-between mt-4 w-full">
              <Button className="cursor-pointer font-black h-14 leading-[normal] text-base text-center w-[280px]" shape="round" color="teal_400" size="xl" variant="fill">Vragenlijst</Button>
              <Button className="cursor-pointer font-black h-14 leading-[normal] text-base text-center w-[280px]" shape="round" color="teal_400" size="xl" variant="fill">Uitnodigingen</Button>
            </div>

            <Button className="cursor-pointer font-black h-14 leading-[normal] mt-[19px] text-base text-center w-[280px]" shape="round" color="teal_400" size="xl" variant="fill">Online Opdracht</Button>

            <Text className="mt-[33px] text-white-A700 text-xl" size="txtInterBlack20">Taal</Text>
            <div className="flex sm:flex-col flex-row gap-[33px] items-center justify-between mt-3.5 w-full">
              <Button className="cursor-pointer font-black h-14 leading-[normal] text-base text-center underline w-[280px]" shape="round" color="teal_400" size="xl" variant="fill"
                onClick={() => setLanguage(false)}
                style={{ backgroundColor: knopNederlands}}>Nederlands</Button>
              <Button className="cursor-pointer font-black h-14 leading-[normal] text-base text-center underline w-[280px]" shape="round" color="teal_400" size="xl" variant="fill"
                onClick={() => setLanguage(true)} 
                style={{ backgroundColor: knopEngels}}>Engels</Button>
            </div>

            <Text className="mt-5 text-white-A700 text-xl" size="txtInterBlack20">Type Beperking</Text>
            <div className="flex flex-row gap-[63px] items-start justify-start mt-4 w-[30%] md:w-full">
              <input type="radio" className="my-0.5 h-5 mr-[5px] rounded-[3px] w-5"  name="disabilities" id="FysiekBox" data-testid="FysiekBox" shape="round" color="blue_gray_100" variant="fill"
                onChange={() => setDisability(1)}>
              </input>

              <Text className="text-white-A700 text-xl" size="txtInterSemiBold20">Fysiek</Text>
            </div>

            <div className="flex flex-row gap-[63px] items-center justify-start mt-[19px] w-2/5 md:w-full">
              <input type="radio" className="my-0.5 h-5 mr-[5px] rounded-[3px] w-5" name="disabilities" id="ZintuigelijkBox" data-testid="ZintuigelijkBox" shape="round" color="blue_gray_100" variant="fill"
                onChange={() => setDisability(2)}>
              </input>

              <Text className="text-white-A700 text-xl" size="txtInterSemiBold20">Auditief</Text>
            </div>

            <div className="flex flex-row gap-[63px] items-center justify-start mt-[19px] w-[36%] md:w-full">
              <input type="radio" className="my-0.5 h-5 mr-[5px] rounded-[3px] w-5" name="disabilities" id="CognitiefBox" data-testid="CognitiefBox" shape="round" color="blue_gray_100" variant="fill"
                onChange={() => setDisability(3)}>
              </input>
              <Text className="text-white-A700 text-xl" size="txtInterSemiBold20">Visueel</Text>
            </div>

            <div className="flex flex-row gap-[63px] items-center justify-start mt-[19px] w-[44%] md:w-full">
              <input type="radio" className="my-0.5 h-5 mr-[5px] rounded-[3px] w-5" name="disabilities" id="NeurologischBox" shape="round" color="blue_gray_100" variant="fill"
                onChange={() => setDisability(4)}>
              </input>
              <Text className="text-white-A700 text-xl" size="txtInterSemiBold20">Ontwikkeling</Text>
            </div>

            <div className="flex flex-row gap-[63px] items-center justify-start mt-[19px] w-[70%] md:w-full">
              <input type="radio" className="my-0.5 h-5 mr-[5px] rounded-[3px] w-5" name="disabilities" id="OntwikkelingBox" shape="round" color="blue_gray_100" variant="fill"
                onChange={() => setDisability(5)}>
              </input>
              <Text className="text-white-A700 text-xl" size="txtInterSemiBold20">Cognitief of neurologisch</Text>
            </div>



            <Text className="mt-[31px] text-white-A700 text-xl" size="txtInterBlack20">Beschrijving Opdracht</Text>
            <TextArea className="bg-deep_orange-50 h-[188px] mt-[15px] rounded-[27px] w-full"
              id="description"
              data-testid ="description"
              value={description}
              onChange={
                (e) => setDescription(e.target.value)
              }
            ></TextArea>


            <Text className="mt-[31px] text-white-A700 text-xl" size="txtInterBlack20">Beloning</Text>
            <TextArea className="bg-deep_orange-50 h-[112px] mt-[15px] rounded-[27px] w-full"
              id="reward"
              rows={2}
              value={reward}
              onChange={
                (e) => setReward(e.target.value)
              }
            ></TextArea>

            <Text className="mt-[20px] mb-[15px] text-white-A700 text-xl" size="txtInterBlack20" >Upload Bestand</Text>
            <Input name="uploadFile" type="file" placeholder=""  className="p-0 w-full mx-auto" variant="fill" ></Input>

            <Button className="cursor-pointer font-black h-14 leading-[normal] mt-[70px]  mr-3 text-center text-xl w-[600px]" shape="round" color="teal_400" size="md" variant="fill"
              type="submit" id="submitbutton" value="Submit" onClick={() => CreateResearch()}
            >
              Onderzoek Plaatsen
            </Button>
            <Button className="cursor-pointer font-black h-14 leading-[normal] mt-[57px] text-center text-xl w-[600px]" shape="round" color="blue_gray_100_01" size="lg" variant="fill" onClick={() => navigate("/bedrijfmenupagina")}>Annuleren</Button>
          </div>
        </div>
      </div>
    </>
  );
};


export default OnderzoekPlaatsenBedrijfPaginaPage;
