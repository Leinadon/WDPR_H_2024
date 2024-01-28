import { createContext, useState, useContext } from 'react';

const AuthContext = createContext();

export const AuthProvider = ({ children }) => {
    const [auth, setAuth] = useState({ isAuthenticated: false, userRoles: [] });

    const login = (roles) => {
        setAuth({ isAuthenticated: true, userRoles: roles });
    };

    const logout = () => {
        setAuth({ isAuthenticated: false, userRoles: [] });
    };

    return (
        <AuthContext.Provider value={{ auth, setAuth, login, logout }}>
            {children}
        </AuthContext.Provider>

    )
}

export const useAuth = () => useContext(AuthContext);

export default AuthContext;
























// import { createContext, useState } from 'react';

// const AuthContext = createContext({});

// export const AuthProvider = ({ children }) => {
//     const [auth, setAuth] = useState({});

//     return (
//         <AuthContext.Provider value={{auth, setAuth }}>
//             {children}
//         </AuthContext.Provider>

//     )
// }

// export default AuthContext;