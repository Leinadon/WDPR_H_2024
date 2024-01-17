import React from "react";
import Routes from "./Routes";

import { MsalProvider, AuthenticatedTemplate, useMsal, UnauthenticatedTemplate } from '@azure/msal-react';


function App() {

        const { instance } = useMsal();
        const activeAccount = instance.getActiveAccount();

        return <Routes />;
}

export default App;
