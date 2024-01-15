import React from 'react';

import { BrowserRouter, Routes, Route } from "react-router-dom";
import './App.css';

import Contact from "./Pages/Contact";
import Menu from "./Pages/Menu";
import PageNonExist from "./Pages/PageNonExist"

// Figma pages
import ChatsOfUser from "./Pages/ChatsOfUser";
import HomePage from "./Pages/HomePagina";
import Login from "./Pages/Login";
import SignUp from "./Pages/SignUpPagina";
import DeskunidgeProfiel from "./Pages/PortalDeskundige/Profiel_Deskundige";


function App() {
  return (
    <BrowserRouter>
      <Routes>
          <Route index element={<HomePage />} />
          <Route path="ChatsOfUser" element={<ChatsOfUser />} />
          <Route path="login" element={<Login />} />
          <Route path="signup" element={<SignUp />} />
          <Route path="profiel" element={<DeskunidgeProfiel />} />
          <Route path="menu" element={<Menu />} />
          <Route path="*" element={<PageNonExist />} />
        
      </Routes>
    </BrowserRouter>
  );
}
export default App;
