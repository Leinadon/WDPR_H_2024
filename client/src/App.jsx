import React from "react";
import Routes from "./Routes";
import { PublicClientApplication } from '@azure/msal-browser';
import { MsalProvider } from '@azure/msal-react';
import { msalConfig } from './msalConfig';
import { MsalAuthenticationTemplate } from './MsalAuthenticationTemplate';
import { AppContent } from './AppContent'; // Your main application component


function App() {
  return (
    <MsalProvider instance={msalInstance} >
      <MsalAuthenticationTemplate>
        <AppContent />
      </MsalAuthenticationTemplate>
    </MsalProvider>
  );
}

const pca = new PublicClientApplication(msalConfig);
export default App;
