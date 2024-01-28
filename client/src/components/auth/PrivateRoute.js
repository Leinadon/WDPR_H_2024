import { useState } from "react";
import { Navigate } from "react-router-dom";
// import { useAuth } from "../../AuthProvider"; 


const PrivateRoute = ({ Component }) => {

  const [isAuthenticated, setIsAuthenticated] = useState(false);

  // Your authentication logic goes here...
  

  return isAuthenticated ? <Component /> : <Navigate to="/login" />;
};
export default PrivateRoute;