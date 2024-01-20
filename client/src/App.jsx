import React from "react";
import Routes from "./Routes";

import { MsalProvider, AuthenticatedTemplate, useMsal, UnauthenticatedTemplate } from '@azure/msal-react';
import { msalInstance } from "./index";
import "./styles/App.css";

function App() {

        

        return (
                <MsalProvider instance={msalInstance}>
                        <Routes />
                </MsalProvider>
        )
        
        
}

export default App;
