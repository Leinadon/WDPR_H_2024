import React, { useEffect, useState } from "react";
import axios from "axios";

import { Button, CheckBox, Img, Input, Text, TextArea } from "components";

const OnderzoekPlaatsenBedrijfPaginaPage = () => {
  const [title, setTitle] = useState();
  const [english, setLanguage] = useState(false);
  const [description, setDescription] = useState();
  const [startdate, setStartdate] = useState();
  const [location, setLocation] = useState();
  const [reward, setReward] = useState("60 euro");
  const [categories, setCategories] = useState({
    FysiekBox: false,
    ZintuigelijkBox: false,
    CognitiefBox: false,
    NeurologischBox: false,
    OntwikkelingBox: false,
  });
  
  console.log(startdate)
  
  const CheckboxChange = (category) => {
    setCategories((prevCategories) => ({
      ...prevCategories,
      [`${category}Box`]: !prevCategories[`${category}Box`],
    }));
  };


  function CreateResearch() {
    fetch("https://localhost:7258/api/research/interview/", {

      method: "POST",
      mode: "cors",
      headers: {
        'Access-Control-Allow-Origin': '*',
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({
        "title": title,
        "description": description,
        "Location": location,
        "categories": categories,
        "Reward": reward,
        "English": english,
        "Status": "open",
        "companyId": 1
      })
    }
    ).then(response => response.json())
      .then(data => console.log(data));
  }


  return (
    <>
      <div className="bg-blue_gray-900 flex flex-col font-jockeyone items-center justify-start mx-auto p-[43px] md:px-10 sm:px-5 w-full">
        <div className="flex flex-col gap-[18px] items-center justify-start max-w-[1337px] mb-[19px] mx-auto w-full">
          <div className="flex sm:flex-col flex-row md:gap-10 items-center justify-between w-full">
            <div className="flex sm:flex-1 flex-col h-[104px] md:h-auto items-center justify-center p-2.5 w-[445px] sm:w-full">
              <Text className="md:text-5xl text-6xl text-teal-400" size="txtJockeyOneRegular60">Onderzoek</Text>
            </div>
            <div className="flex flex-col h-[100px] md:h-auto items-center justify-start p-2.5 w-[116px]">
              <Img className="md:h-auto h-full object-cover w-full" src="images/img_reshotillustra.png" alt="reshotillustra" />
            </div>
          </div>


          <div className="flex flex-col font-inter items-start justify-start w-[37%] md:w-full">
            <Text className="mt-[22px] text-white-A700 text-xl" size="txtInterBlack20">Titel</Text>
            <Input name="researchTitle" placeholder="Titel van het onderzoek" className="p-0 w-full" wrapClassName="flex h-[54px] mt-[17px] w-full" shape="round" color="deep_orange_50" variant="fill"
              id="title"
              value={title}
              // value=""
              // onChange={handleChange}
              onChange={
                (e) => setTitle(e.target.value)
              }
            ></Input>


            <Text className="mt-[22px] text-white-A700 text-xl" size="txtInterBlack20">Datum</Text>
            <Input name="datepicker" type="datetime-local" placeholder="" className="p-0 w-full" wrapClassName="flex h-[54px] mt-3.5 w-full" shape="round" color="deep_orange_50" variant="fill"
            value={startdate}
            onChange={
              (e) => setStartdate(e.target.value)
            }
            ></Input>



            <Text className="text-white-A700 text-xl" size="txtInterBlack20">Soort onderzoek</Text>
            <div className="flex sm:flex-col flex-row gap-[33px] items-center justify-between mt-4 w-full">
              <Button className="cursor-pointer font-black h-14 leading-[normal] text-base text-center w-[226px]" shape="round" color="teal_400" size="xl" variant="fill">Vragenlijst</Button>
              <Button className="cursor-pointer font-black h-14 leading-[normal] text-base text-center w-[226px]" shape="round" color="teal_400" size="xl" variant="fill">Uitnodigingen</Button>
            </div>

            <Button className="cursor-pointer font-black h-14 leading-[normal] mt-[19px] text-base text-center w-[226px]" shape="round" color="teal_400" size="xl" variant="fill">Online Opdracht</Button>

            <Text className="mt-[33px] text-white-A700 text-xl" size="txtInterBlack20">Taal (language)</Text>
            <div className="flex sm:flex-col flex-row gap-[33px] items-center justify-between mt-3.5 w-full">
              <Button className="cursor-pointer font-black h-14 leading-[normal] text-base text-center underline w-[226px]" shape="round" color="teal_400" size="xl" variant="fill"
                onClick={() => setLanguage(false)}
              >Nederlands</Button>
              <Button className="cursor-pointer font-black h-14 leading-[normal] text-base text-center underline w-[226px]" shape="round" color="teal_400" size="xl" variant="fill"
                onClick={() => setLanguage(true)}>English</Button>
            </div>

            <Text className="mt-5 text-white-A700 text-xl" size="txtInterBlack20">Type Beperking</Text>
            <div className="flex flex-row gap-[63px] items-start justify-start mt-4 w-[30%] md:w-full">
              {/* <CheckBox name="rectanglefive" placeholder="" className="p-0 w-full" wrapClassName="flex h-5 my-0.5 rounded-[3px] w-5" color="blue_gray_100" variant="fill" id=""></CheckBox> */}
              <CheckBox className="my-0.5" inputClassName="h-5 mr-[5px] rounded-[3px] w-5" name="FysiekBox" id="FysiekBox" shape="round" color="blue_gray_100" variant="fill"
                checked={categories.FysiekBox}
                onChange={() => CheckboxChange('Fysiek')}>
              </CheckBox>

              <Text className="text-white-A700 text-xl" size="txtInterSemiBold20">Fysiek</Text>
            </div>

            <div className="flex flex-row gap-[63px] items-center justify-start mt-[19px] w-2/5 md:w-full">
              <CheckBox className="my-0.5" inputClassName="h-5 mr-[5px] rounded-[3px] w-5" name="ZintuigelijkBox" id="ZintuigelijkBox" shape="round" color="blue_gray_100" variant="fill"
                checked={categories.ZintuigelijkBox}
                onChange={() => CheckboxChange('Zintuigelijk')}>
              </CheckBox>

              <Text className="text-white-A700 text-xl" size="txtInterSemiBold20">Zintuigelijk</Text>
            </div>

            <div className="flex flex-row gap-[63px] items-center justify-start mt-[19px] w-[36%] md:w-full">
              <CheckBox className="my-0.5" inputClassName="h-5 mr-[5px] rounded-[3px] w-5" name="CognitiefBox" id="CognitiefBox" shape="round" color="blue_gray_100" variant="fill"
                checked={categories.CognitiefBox}
                onChange={() => CheckboxChange('Cognitief')}>
              </CheckBox>
              <Text className="text-white-A700 text-xl" size="txtInterSemiBold20">Cognitief</Text>
            </div>

            <div className="flex flex-row gap-[63px] items-center justify-start mt-[19px] w-[44%] md:w-full">
              <CheckBox className="my-0.5" inputClassName="h-5 mr-[5px] rounded-[3px] w-5" name="NeurologischBox" id="NeurologischBox" shape="round" color="blue_gray_100" variant="fill"
                checked={categories.NeurologischBox}
                onChange={() => CheckboxChange('Neurologisch')}>
              </CheckBox>
              <Text className="text-white-A700 text-xl" size="txtInterSemiBold20">Neurologisch</Text>
            </div>

            <div className="flex flex-row gap-[63px] items-center justify-start mt-[19px] w-[43%] md:w-full">
              <CheckBox className="my-0.5" inputClassName="h-5 mr-[5px] rounded-[3px] w-5" name="OntwikkelingBox" id="OntwikkelingBox" shape="round" color="blue_gray_100" variant="fill"
                checked={categories.OntwikkelingBox}
                onChange={() => CheckboxChange('Ontwikkeling')}>
              </CheckBox>
              <Text className="text-white-A700 text-xl" size="txtInterSemiBold20">Ontwikkeling</Text>
            </div>


            {/* <div className="flex flex-row items-center justify-between mt-[31px] w-[83%] md:w-full">
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">Min. Leeftijd</Text>
              <Text className="text-white-A700 text-xl" size="txtInterBlack20">Max. Leeftijd</Text>
              </div>
            <div className="flex sm:flex-col flex-row sm:gap-[51px] items-center justify-between mt-[18px] w-full">
              <Input name="rectangleeleven" placeholder="" className="p-0 w-full" wrapClassName="flex sm:flex-1 h-[54px] sm:w-full" shape="round" color="deep_orange_50" variant="fill"></Input>
              <Input name="rectangletwelve" placeholder="" className="p-0 w-full" wrapClassName="flex sm:flex-1 h-[54px] sm:w-full" shape="round" color="deep_orange_50" variant="fill"></Input>
            </div> */}


            <Text className="mt-[31px] text-white-A700 text-xl" size="txtInterBlack20">Beschrijving Opdracht</Text>
            <TextArea className="bg-deep_orange-50 h-[188px] mt-[15px] rounded-[27px] w-full"
              id="description"
              value={description}
              // value=""
              // onChange={handleChange}
              onChange={
                (e) => setDescription(e.target.value)
              }
            ></TextArea>


            <Text className="mt-[31px] text-white-A700 text-xl" size="txtInterBlack20">Beloning</Text>
            <TextArea className="bg-deep_orange-50 h-[188px] mt-[15px] rounded-[27px] w-full"
              id="description"
              rows={2}
              value={reward}
              // value=""
              // onChange={handleChange}
              onChange={
                (e) => setReward(e.target.value)
              }
            ></TextArea>

            <Text className="mt-9 text-center text-white-A700 text-xl" size="txtInterBlack20">Postcode</Text>
            <Input name="rectangleten" placeholder="" className="p-0 w-full" wrapClassName="flex h-[54px] mt-[19px] w-full" shape="round" color="deep_orange_50" variant="fill"
              id="title"
              value={location}
              // value=""
              // onChange={handleChange}
              onChange={
                (e) => setLocation(e.target.value)
              }
            ></Input>

            <Text className="mt-10 text-white-A700 text-xl" size="txtInterBlack20">Upload Bestand</Text>
            <Input name="rectanglefiftee" placeholder="" className="p-0 w-full" wrapClassName="flex h-[54px] mt-3.5 w-full" shape="round" color="deep_orange_50" variant="fill"></Input>

            <Button className="cursor-pointer font-black h-12 leading-[normal] mt-[72px] rounded-[24px] text-center text-xl w-[486px]" color="teal_400" size="md" variant="fill"
              type="submit" id="submitbutton" value="Submit" onClick={() => CreateResearch()}
            >
              Onderzoek Plaatsen
            </Button>
            <Button className="cursor-pointer font-black h-14 leading-[normal] mt-[57px] text-center text-xl w-[486px]" shape="round" color="blue_gray_100_01" size="lg" variant="fill">Annuleren</Button>
          </div>
        </div>
      </div>
    </>
  );
};


export default OnderzoekPlaatsenBedrijfPaginaPage;
