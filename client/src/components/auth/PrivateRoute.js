// import { useState, useContext } from "react";
// import { Navigate } from "react-router-dom";
// // import { useAuth } from "../../AuthProvider"; 
// import { useAuth }  from "../../AuthProvider";


// const PrivateRoute = ({ Component }) => {
//   // const { auth } = useContext(AuthContext);
//   const { auth } = useAuth();
//   const [authenticated, setIsAuthenticated] = useState(false);

//   console.log(auth);
//   // setIsAuthenticated(auth.isAuthenticated);

//   return authenticated ? <Component /> : <Navigate to="/login" />;
// };
// export default PrivateRoute;

import { useLocation, Navigate, Outlet } from "react-router-dom";
import useAuth from "../../hooks/useAuth";

const RequireAuth = ({ allowedRoles }) => {
    const { auth } = useAuth();
    const location = useLocation();
    
    return (

      auth?.userRoles.find(role => allowedRoles?.includes(role))
      ? <Outlet />
            : auth?.isAuthenticated
                ? <Navigate to="/unauthorized" state={{ from: location }} replace />
                : <Navigate to="/login" state={{ from: location }} replace />
    );
}

export default RequireAuth;