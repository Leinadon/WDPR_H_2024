import React from 'react';
import { Link } from "react-router-dom";

import '../App.css';

function Home() {
  return (
    <div className="index">
      <div className="background">
        <div className="title-frame">
          <div className="title">Accessibility</div>
        </div>
        <div className="reshot-illustration-wrapper">
          <img
            className="image-wrapper"
            alt="Logo van Stichting Accessibility"
            src="https://cdn.animaapp.com/projects/659f1e6cded76ea0d1a6c9c6/releases/659f1ef882905d4b48062a41/img/reshot-illustration-website-development-5qs97cjh2a-9f9a1-1.png"
          />
        </div>
        <div className="div-wrapper">
          <div className="welcome-div">
            <div className="text-wrapper">Hallo, Welkom !</div>
          </div>
          <div className="message-frame">
            <p className="p">Welkom bij de testpanel Accessibility</p>
          </div>
          <button className="button-frame">
            <Link className="text-wrapper-inter" to="/login">Login</Link>
            {/* <div className="text-wrapper-inter">Login</div> */}
          </button>
          <button className="button-frame">
            <Link className="text-wrapper-inter" to="/signup">Sign Up</Link>
          </button>
        </div>
      </div>
    </div>
  );
}

export default Home;
