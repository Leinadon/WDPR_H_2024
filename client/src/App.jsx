import React from "react";
import Routes from "./Routes";

import { MsalProvider, AuthenticatedTemplate, useMsal, UnauthenticatedTemplate } from '@azure/msal-react';
import "./styles/App.css";

function App() {

        const { instance } = useMsal();
        const activeAccount = instance.getActiveAccount();

        return <Routes />;
}

export default App;
