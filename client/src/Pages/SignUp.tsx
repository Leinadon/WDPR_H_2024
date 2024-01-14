import React from 'react';
import '../App.css';
import { Button, Grid, Segment } from 'semantic-ui-react';

import { useWindowWidth } from "../breakpoints";

function SignUp() {
  const screenWidth = useWindowWidth();


  return (
    <div className="index">

      <Grid stackable columns={3}>
        <Grid.Row>
          <Grid.Column>
          </Grid.Column>

          <Grid.Column width={10}>
            <Grid columns={2}>
              <Grid.Row>

                <Grid.Column>
                  <div className="title-green">Sign Up</div>
                </Grid.Column>
                <Grid.Column>
                  <img
                    className="img"
                    alt="Logo van Stichting Accessibility"
                    src="https://cdn.animaapp.com/projects/659f1e6cded76ea0d1a6c9c6/releases/659fb98398cbfac555cbd188/img/reshot-illustration-website-development-5qs97cjh2a-9f9a1-3@2x.png"
                  />
                </Grid.Column>
              </Grid.Row>
            </Grid>

            <div className="div  text-white text-lg">Maak een account aan!</div>

            <label className="signup-text-wrapper">Voornaam</label><br />
            <input type="text" className="text-input" />

            <label className="signup-text-wrapper">Achternaam</label><br />
            <input type="text" className="text-input" />

            <label className="signup-text-wrapper">Geboortedatum</label><br />
            <input type="text" className="text-input" />

            <label className="signup-text-wrapper">Telefoonnummer</label><br />
            <input type="text" className="text-input" />

            <label className="signup-text-wrapper">Postcode</label><br />
            <input type="text" className="text-input" />

            <label className="signup-text-wrapper">Email</label><br />
            <input type="text" className="text-input" />

            <label className="signup-text-wrapper">Wachtwoord</label><br />
            <input type="text" className="text-input" />

            <label className="signup-text-wrapper">Type beperking</label><br />

            <p className="p">
              <input type="checkbox" id="disability1" name="disability1" value="Fysiek" />
              <label htmlFor="disability1" className="checkbox-text">Fysiek</label><br />
            </p>

            <p className="p">
              <input type="checkbox" id="disability2" name="disability2" value="Zintuigelijk" />
              <label htmlFor="disability2" className="checkbox-text">Zintuigelijk</label><br />
            </p>

            <p className="p">
              <input type="checkbox" id="disability3" name="disability3" value="Cognitief" />
              <label htmlFor="disability3" className="checkbox-text">Cognitief</label><br />
            </p>

            <p className="p">
              <input type="checkbox" id="disability4" name="disability4" value="Neurologisch" />
              <label htmlFor="disability4" className="checkbox-text">Neurologisch</label><br />
            </p>

            <p className="p">
              <input type="checkbox" id="disability5" name="disability5" value="Ontwikkeling" />
              <label htmlFor="disability5" className="checkbox-text">Ontwikkeling</label><br />
            </p>

            <label className="signup-text-wrapper">Voogd</label><br />
            <button className="button-frame">
              <b className="text-wrapper-inter">Ik heb geen voogd</b>
            </button>

            <label className="signup-text-wrapper">Hulpmiddelen</label><br />
            <input type="text" className="text-input hulpmiddelen" />

            <p className="p">
              <span className="span">Al een account? </span>
              <Button className="text-wrapper-13">Log In</Button>
            </p>
          </Grid.Column>

          <Grid.Column>
          </Grid.Column>
        </Grid.Row>
      </Grid>
    </div>
  );
}

export default SignUp;
