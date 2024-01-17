import React from "react";
import Routes from "./Routes";

import { MsalProvider, AuthenticatedTemplate, useMsal, UnauthenticatedTemplate } from '@azure/msal-react';
import { msalConfig } from './msalConfig';
import { AppContent } from './AppContent'; // Your main application component


function App() {

      
        return <Routes />;
      
    

}

const pca = new PublicClientApplication(msalConfig);
export default App;
