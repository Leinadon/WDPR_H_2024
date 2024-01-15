import React from "react";

import { useNavigate } from "react-router-dom";

import { Button, Img, Text } from "../components";

const HomePaginaPage = () => {
  const navigate = useNavigate();

  return (
    <div className="chats-bedrijf">
      <div className="div">
        <div className="text-wrapper">Chats</div>
        <img
          className="reshot-illustration"
          alt="Reshot illustration"
          src="reshot-illustration-website-development-5qs97cjh2a-9f9a1-2.png"
        />
        <div className="overlap-group">
          <div className="overlap">
            <img className="image" alt="Image" src="image-4.png" />
            <div className="text-wrapper-2">Zoek hier...</div>
          </div>
          <div className="overlap-2">
            <div className="rectangle" />
            <div className="rectangle-2" />
            <div className="text-wrapper-4">Kevin Chan</div>
            <div className="text-wrapper-5">Martin Koop</div>
            <div className="ellipse" />
            <div className="text-wrapper-6">2</div>
            <img className="download-modified" alt="Download modified" src="download-7-modified-1.png" />
            <img className="img" alt="Download modified" src="download-8-modified-1.png" />
            <div className="rectangle-3" />
            <img className="download-modified-2" alt="Download modified" src="download-9-modified-2.png" />
            <div className="text-wrapper-7">Jan van Dijk (Beheerder)</div>
            <p className="text-wrapper-8">Bedankt voor het reageren op mijn ber...</p>
          </div>
        </div>
        <div className="frame">
          <div className="text-wrapper-9">Terug naar Menu</div>
        </div>
      </div>
    </div>
  );
};

export default HomePaginaPage;
