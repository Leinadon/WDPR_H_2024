
import { useContext } from "react";
import { useLocation, Navigate, Outlet } from "react-router-dom";
import AuthContext from "../../AuthProvider";

const RequireAuth = ({ allowedRoles }) => {
    const { logout, login, auth } = useContext(AuthContext);
    const location = useLocation();
    
    console.log(auth);

    return (
      auth?.userRoles.find(role => allowedRoles?.includes(role))
      ? <Outlet />
            : auth?.isAuthenticated
                ? <Navigate to="/unauthorized" state={{ from: location }} replace />
                : <Navigate to="/login" state={{ from: location }} replace />
    );
}

export default RequireAuth;