import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import NotFound from "Pages/NotFound";
const ProfielBeheerderPagina = React.lazy(
  () => import("Pages/ProfielBeheerderPagina"),
);
const ProfielPaginaBeheerder = React.lazy(
  () => import("Pages/ProfielPaginaBeheerder"),
);
const MenuBeheerderPagina = React.lazy(
  () => import("Pages/MenuBeheerderPagina"),
);
const ChatBedrijfErvaringsdeskundigePagina = React.lazy(
  () => import("Pages/ChatBedrijfErvaringsdeskundigePagina"),
);
const ChatsBedrijfErvaringsdeskundigePagina = React.lazy(
  () => import("Pages/ChatsBedrijfErvaringsdeskundigePagina"),
);
const OnderzoekResultatenBedrijfPagina = React.lazy(
  () => import("Pages/OnderzoekResultatenBedrijfPagina"),
);
const ProfielBedrijfPagina = React.lazy(
  () => import("Pages/ProfielBedrijfPagina"),
);
const OnderzoekPlaatsenBedrijfPagina = React.lazy(
  () => import("Pages/OnderzoekPlaatsenBedrijfPagina"),
);
const ProfielPaginaBedrijven = React.lazy(
  () => import("Pages/ProfielPaginaBedrijven"),
);
const BedrijfMenuPagina = React.lazy(() => import("Pages/BedrijfMenuPagina"));
const ChatErvaringsdeskundigeBedrijfPagina = React.lazy(
  () => import("Pages/ChatErvaringsdeskundigeBedrijfPagina"),
);
const ChatPagina = React.lazy(() => import("Pages/ChatPagina"));
const OndersteuningPagina = React.lazy(
  () => import("Pages/OndersteuningPagina"),
);
const OnderzoekPagina = React.lazy(() => import("Pages/OnderzoekPagina"));
const OnderzoekDoenErvaringsdeskundigePagina = React.lazy(
  () => import("Pages/OnderzoekDoenErvaringsdeskundigePagina"),
);
const ProfielErvaringsdeskundigePagina = React.lazy(
  () => import("Pages/ProfielErvaringsdeskundigePagina"),
);
const ProfielPagina = React.lazy(() => import("Pages/ProfielPagina"));
const MenuPagina = React.lazy(() => import("Pages/MenuPagina"));
const SignUpPagina = React.lazy(() => import("Pages/SignUpPagina"));
const LogInPagina = React.lazy(() => import("Pages/LogInPagina"));
const HomePagina = React.lazy(() => import("Pages/HomePagina"));
const ProjectRoutes = () => {
  return (
    <React.Suspense fallback={<>Loading...</>}>
      <Router>
        <Routes>
          <Route path="/" element={<HomePagina />} />
          <Route path="*" element={<NotFound />} />
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
