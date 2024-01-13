import React from 'react';
// import '../App.css';
import './css/SignUp.css';

import { useWindowWidth } from "../breakpoints";

function SignUp() {
  const screenWidth = useWindowWidth();


  return (
    <div className="index">
      <div
        className="signup-pagina"
        style={{
          height: screenWidth < 1440 ? "1842px" : screenWidth >= 1440 ? "2022px" : undefined,
          width: screenWidth < 1440 ? "430px" : screenWidth >= 1440 ? "1440px" : undefined,
        }}
      >
        {screenWidth < 1440 && <div className="div">Maak een Account!</div>}

        {screenWidth >= 1440 && (
          <>
            <div className="reshot-illustration-wrapper">
              <img
                className="reshot-illustration"
                alt="Reshot illustration"
                src="https://cdn.animaapp.com/projects/659f1e6cded76ea0d1a6c9c6/releases/659fb98398cbfac555cbd188/img/reshot-illustration-website-development-5qs97cjh2a-9f9a1-3@2x.png"
              />
            </div>
            <div className="div-wrapper">
              <div className="text-wrapper-2">Sign Up</div>
            </div>
            {/* <StateNietGekozenWrapper className="frame-9" stateProp="niet-gekozen" /> */}
            <div className="text-wrapper-3">Hulpmiddelen</div>
          </>
        )}

        <div
          className="rectangle"
          style={{
            height: screenWidth < 1440 ? "49px" : screenWidth >= 1440 ? "54px" : undefined,
            left: screenWidth < 1440 ? "54px" : screenWidth >= 1440 ? "494px" : undefined,
            top: screenWidth < 1440 ? "287px" : screenWidth >= 1440 ? "1562px" : undefined,
            width: screenWidth < 1440 ? "330px" : screenWidth >= 1440 ? "466px" : undefined,
          }}
        />
        {screenWidth >= 1440 && (
          <>
            <div className="text-wrapper-4">Voogd</div>
            <div className="text-wrapper-5">Type Beperking</div>
            <div className="text-wrapper-6">Fysiek</div>
            <div className="text-wrapper-7">Zintuigelijk</div>
            <div className="text-wrapper-8">Cognitief</div>
            <div className="text-wrapper-9">Neurologisch</div>
            <div className="text-wrapper-10">Ontwikkeling</div>

            <div className="rectangle-12" />
            <div className="rectangle-8-1" />
            <div className="property-1-default" />
            <div className="rectangle-12-instance" />
            <div className="rectangle-8-1-instance" />

            <div className="text-wrapper-11">Maak een Account ahaan!</div>
            <div className="frame-2">
              <div className="text-wrapper-12">Voornaam</div>
            </div>
          </>
        )}

        <div
          className="rectangle-2"
          style={{
            left: screenWidth < 1440 ? "54px" : screenWidth >= 1440 ? "492px" : undefined,
            top: screenWidth < 1440 ? "624px" : screenWidth >= 1440 ? "328px" : undefined,
            width: screenWidth < 1440 ? "330px" : screenWidth >= 1440 ? "466px" : undefined,
          }}
        />
        {screenWidth >= 1440 && (
          <div className="frame-3">
            <div className="text-wrapper-12">Achternaam</div>
          </div>
        )}

        <div
          className="rectangle-3"
          style={{
            left: screenWidth < 1440 ? "54px" : screenWidth >= 1440 ? "492px" : undefined,
            top: screenWidth < 1440 ? "852px" : screenWidth >= 1440 ? "436px" : undefined,
            width: screenWidth < 1440 ? "330px" : screenWidth >= 1440 ? "466px" : undefined,
          }}
        />
        {screenWidth >= 1440 && (
          <>
            <div className="frame-4">
              <div className="text-wrapper-12">Geboortedatum</div>
            </div>
            <div className="rectangle-4" />
            <div className="frame-5">
              <div className="text-wrapper-12">Email</div>
            </div>
            <div className="rectangle-5" />
            <div className="frame-6">
              <div className="text-wrapper-12">Telefoonnummer</div>
            </div>
            <div className="rectangle-6" />
            <div className="frame-7">
              <div className="text-wrapper-12">Postcode</div>
            </div>
            <div className="rectangle-7" />
            <div className="al-een-account-log-wrapper">
              <p className="al-een-account-log">
                <span className="span">Al een account? </span>
                <span className="text-wrapper-13">Log In</span>
              </p>
            </div>
            <div className="frame-8">
              <div className="text-wrapper-12">Wachtwoord</div>
            </div>
            <div className="rectangle-8" />
            {/* <Frame className="frame-instance" divClassName="frame-2-instance" state="default" /> */}
          </>
        )}

        {screenWidth < 1440 && (
          <>
            <div className="text-wrapper-14">Voornaam</div>
            <div className="text-wrapper-15">Email</div>
            <div className="rectangle-9" />
            <div className="text-wrapper-16">Telefoonnummer</div>
            <div className="rectangle-10" />
            <div className="text-wrapper-17">Achternaam</div>
            <div className="text-wrapper-18">Wachtwoord</div>
            <div className="rectangle-11" />
            <div className="text-wrapper-19">Postcode</div>
            <p className="p">
              <span className="span">Al een account? </span>
              <span className="text-wrapper-13">Log In</span>
            </p>
            {/* <Frame className="instance-node" divClassName="frame-10" state="default" /> */}
            <img
              className="img"
              alt="Reshot illustration"
              src="https://cdn.animaapp.com/projects/659f1e6cded76ea0d1a6c9c6/releases/659fb98398cbfac555cbd188/img/reshot-illustration-website-development-5qs97cjh2a-9f9a1-3@2x.png"
            />
            <div className="text-wrapper-20">Sign Up</div>
            <div className="text-wrapper-21">Voogd</div>
            {/* <StateNietGekozenWrapper className="frame-9-instance" stateProp="niet-gekozen" /> */}
            <div className="rectangle-13" />
            <div className="text-wrapper-22">Geboortedatum</div>
            <div className="text-wrapper-23">Hulpmiddelen</div>
            <div className="rectangle-14" />

            <div className="section-frame">Type Beperking</div>
            <input type="checkbox" className="rectangle-19" />
            <div className="text-wrapper-25">Fysiek</div>

            <input type="checkbox" className="rectangle-18" />
            <div className="text-wrapper-26">Zintuigelijk</div>

            <input type="checkbox" className="rectangle-17" />
            <div className="text-wrapper-27">Cognitief</div>

            <input type="checkbox" className="rectangle-16" />
            <div className="text-wrapper-28">Neurologisch</div>

            <input type="checkbox" className="rectangle-15" />
            <div className="text-wrapper-29">Ontwikkeling</div>

          </>
        )}
      </div>
    </div>
  );
}

export default SignUp;
