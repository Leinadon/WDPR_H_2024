import React from "react";
import Routes from "./Routes";
import {AuthProvider} from "./AuthProvider";

import { MsalProvider, AuthenticatedTemplate, useMsal, UnauthenticatedTemplate } from '@azure/msal-react';
import { msalInstance } from "./index";
import "./styles/App.css";

function App() {
        return (
                <MsalProvider instance={msalInstance}>
                        {/* <AuthProvider> */}
                                <Routes />
                        {/* </AuthProvider> */}
                </MsalProvider>
        )
}

export default App;
