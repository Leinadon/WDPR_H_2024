import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Home from "pages/Home";
import NotFound from "pages/NotFound";
const ProfielBeheerderPagina = React.lazy(
  () => import("pages/ProfielBeheerderPagina"),
);
const ProfielPaginaBeheerder = React.lazy(
  () => import("pages/ProfielPaginaBeheerder"),
);
const MenuBeheerderPagina = React.lazy(
  () => import("pages/MenuBeheerderPagina"),
);
const ChatBedrijfErvaringsdeskundigePagina = React.lazy(
  () => import("pages/ChatBedrijfErvaringsdeskundigePagina"),
);
const ChatsBedrijfErvaringsdeskundigePagina = React.lazy(
  () => import("pages/ChatsBedrijfErvaringsdeskundigePagina"),
);
const OnderzoekResultatenBedrijfPagina = React.lazy(
  () => import("pages/OnderzoekResultatenBedrijfPagina"),
);
const ProfielBedrijfPagina = React.lazy(
  () => import("pages/ProfielBedrijfPagina"),
);
const OnderzoekPlaatsenBedrijfPagina = React.lazy(
  () => import("pages/OnderzoekPlaatsenBedrijfPagina"),
);
const ProfielPaginaBedrijven = React.lazy(
  () => import("pages/ProfielPaginaBedrijven"),
);
const BedrijfMenuPagina = React.lazy(() => import("pages/BedrijfMenuPagina"));
const ChatErvaringsdeskundigeBedrijfPagina = React.lazy(
  () => import("pages/ChatErvaringsdeskundigeBedrijfPagina"),
);
const ChatPagina = React.lazy(() => import("pages/ChatPagina"));
const OndersteuningPagina = React.lazy(
  () => import("pages/OndersteuningPagina"),
);
const OnderzoekPagina = React.lazy(() => import("pages/OnderzoekPagina"));
const OnderzoekDoenErvaringsdeskundigePagina = React.lazy(
  () => import("pages/OnderzoekDoenErvaringsdeskundigePagina"),
);
const ProfielErvaringsdeskundigePagina = React.lazy(
  () => import("pages/ProfielErvaringsdeskundigePagina"),
);
const ProfielPagina = React.lazy(() => import("pages/ProfielPagina"));
const MenuPagina = React.lazy(() => import("pages/MenuPagina"));
const SignUpPagina = React.lazy(() => import("pages/SignUpPagina"));
const LogInPagina = React.lazy(() => import("pages/LogInPagina"));
const HomePagina = React.lazy(() => import("pages/HomePagina"));
const ProjectRoutes = () => {
  return (
    <React.Suspense fallback={<>Loading...</>}>
      <Router>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="*" element={<NotFound />} />
          <Route path="/homepagina" element={<HomePagina />} />
          <Route path="/loginpagina" element={<LogInPagina />} />
          <Route path="/signuppagina" element={<SignUpPagina />} />
          <Route path="/menupagina" element={<MenuPagina />} />
          <Route path="/profielpagina" element={<ProfielPagina />} />
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
            path="/menubeheerderpagina"
            element={<MenuBeheerderPagina />}
          />
          <Route
            path="/profielpaginabeheerder"
            element={<ProfielPaginaBeheerder />}
          />
          <Route
            path="/profielbeheerderpagina"
            element={<ProfielBeheerderPagina />}
          />
        </Routes>
      </Router>
    </React.Suspense>
  );
};
export default ProjectRoutes;
