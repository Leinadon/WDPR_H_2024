import React from "react";
import { BrowserRouter as Router, Routes, Route, Redirect, Switch } from "react-router-dom";
import PrivateRoute from "./components/auth/PrivateRoute";
import AuthProvider from "./AuthProvider";
import NotFound from "NotFound";
import InformatieLijstenBeheerderPaginaPage from "InformatieLijstenBeheerderPagina";

const ProfielBeheerderPagina = React.lazy(
  () => import("ProfielBeheerderPagina"),
);
const ProfielPaginaBeheerder = React.lazy(
  () => import("ProfielPaginaBeheerder"),
);
const MenuBeheerderPagina = React.lazy(
  () => import("MenuBeheerderPagina"),
);
const ChatBedrijfErvaringsdeskundigePagina = React.lazy(
  () => import("ChatBedrijfErvaringsdeskundigePagina"),
);
const ChatsBedrijfErvaringsdeskundigePagina = React.lazy(
  () => import("ChatsBedrijfErvaringsdeskundigePagina"),
);
const OnderzoekResultatenBedrijfPagina = React.lazy(
  () => import("OnderzoekResultatenBedrijfPagina"),
);
const ProfielBedrijfPagina = React.lazy(
  () => import("ProfielBedrijfPagina"),
);
const OnderzoekPlaatsenBedrijfPagina = React.lazy(
  () => import("OnderzoekPlaatsenBedrijfPagina"),
);
const ProfielPaginaBedrijven = React.lazy(
  () => import("ProfielPaginaBedrijven"),
);
const BedrijfMenuPagina = React.lazy(() => import("BedrijfMenuPagina"));
const ChatErvaringsdeskundigeBedrijfPagina = React.lazy(
  () => import("ChatErvaringsdeskundigeBedrijfPagina"),
);
const ChatPagina = React.lazy(() => import("ChatPagina"));
const ChatPaginaBedrijfPage = React.lazy(() => import("ChatPaginaBedrijf"));
const ChatPaginaBeheerderPage = React.lazy(() => import("ChatPaginaBeheerder"));
const OndersteuningPagina = React.lazy(
  () => import("OndersteuningPagina"),
);
const OnderzoekPagina = React.lazy(() => import("OnderzoekPagina"));
const OnderzoekDoenErvaringsdeskundigePagina = React.lazy(
  () => import("OnderzoekDoenErvaringsdeskundigePagina"),
);
const ProfielErvaringsdeskundigePagina = React.lazy(
  () => import("ProfielErvaringsdeskundigePagina"),
);
const OnderzoekOverzicht = React.lazy(() => import("OnderzoekOverzicht"));
const ProfielPagina = React.lazy(() => import("ProfielPagina"));
const MenuPagina = React.lazy(() => import("MenuPagina"));
const SignUpPagina = React.lazy(() => import("SignUpPagina")); //OLD ONE
const SignUp = React.lazy(() => import("SignUp"));
const LogInPagina = React.lazy(() => import("LogInPagina"));
const HomePagina = React.lazy(() => import("HomePagina"));


const ProjectRoutes = () => {
  return (
    <React.Suspense fallback={<>Loading...</>}>
      <Router>
        <Routes>
          <Route path="/" element={<HomePagina />} />
          <Route path="*" element={<NotFound />} />
          <Route path="/signup" element={<SignUp />} />

          <Route path="/login" element={<LogInPagina />} />
          <Route path="/signuppagina" element={<SignUpPagina />} />
          <Route path="/menupagina" element={<MenuPagina />} />
          <Route path="/profielpagina" element={<ProfielPagina />} />
          <Route path="/alle_onderzoeken" element={<OnderzoekOverzicht />} />

          <Route path="/admin" element={<PrivateRoute Component={MenuBeheerderPagina} />}  />



    {/* ################## */}
          <Route
            path="/profielervaringsdeskundigepagina"
            element={<ProfielErvaringsdeskundigePagina />}
          />
          <Route
            path="/onderzoekdoenervaringsdeskundigepagina"
            element={<OnderzoekDoenErvaringsdeskundigePagina />}
          />
          <Route path="/onderzoekpagina" element={<OnderzoekPagina />} />
          <Route
            path="/ondersteuningpagina"
            element={<OndersteuningPagina />}
          />
          <Route path="/chatpagina" element={<ChatPagina />} />
          <Route path="/chatpaginabedrijf" element={<ChatPaginaBedrijfPage />} />
          <Route path="/chatpaginabeheerder" element={<ChatPaginaBeheerderPage />} />
          <Route
            path="/chatervaringsdeskundigebedrijfpagina"
            element={<ChatErvaringsdeskundigeBedrijfPagina />}
          />
          <Route path="/bedrijfmenupagina" element={<BedrijfMenuPagina />} />
          <Route
            path="/profielpaginabedrijven"
            element={<ProfielPaginaBedrijven />}
          />
          <Route
            path="/onderzoekplaatsenbedrijfpagina"
            element={<OnderzoekPlaatsenBedrijfPagina />}
          />
          <Route
            path="/profielbedrijfpagina"
            element={<ProfielBedrijfPagina />}
          />
          <Route
            path="/onderzoekresultatenbedrijfpagina"
            element={<OnderzoekResultatenBedrijfPagina />}
          />
          <Route
            path="/chatsbedrijfervaringsdeskundigepagina"
            element={<ChatsBedrijfErvaringsdeskundigePagina />}
          />
          <Route
            path="/chatbedrijfervaringsdeskundigepagina"
            element={<ChatBedrijfErvaringsdeskundigePagina />}
          />
          <Route
            path="/profielpaginabeheerder"
            element={<ProfielPaginaBeheerder />}
          />
          <Route
            path="/profielbeheerderpagina"
            element={<ProfielBeheerderPagina />}
          />
          <Route
            path="/informatielijstenbeheerder"
            element={<InformatieLijstenBeheerderPaginaPage />}
          />
        </Routes>
      </Router>
    </React.Suspense>
  );
};
export default ProjectRoutes;
