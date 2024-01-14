import React from "react";
import { useNavigate } from "react-router-dom";
import { Button, Img, Text } from "../components";

import '../styles/ChatsOfUser.css';

const ChatsOfUser = () => {
    const navigate = useNavigate();
  return (
    <div className="chat-pagina">
      <div className="div">
        <div className="frame">
          <div className="text-wrapper">Chats</div>
        </div>
        <div className="reshot-illustration-wrapper">
          <Img
            className="reshot-illustration"
            alt="Reshot illustration"
            src="reshot-illustration-website-development-5qs97cjh2a-9f9a1-2.png"
          />
        </div>
        <div className="overlap-group">
          <Img className="line" alt="Line" src="line-3.svg" />
          <div className="overlap">
            <div className="text-wrapper-2">Zoek hier...</div>
            <Img className="image" alt="Image" src="image-5.png" />
          </div>
        </div>
      </div>
    </div>
  );
};
export default ChatsOfUser;
