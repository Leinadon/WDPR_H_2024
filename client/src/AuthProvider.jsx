import { createContext, useState, useContext, useEffect } from 'react';

const AuthContext = createContext();

export const AuthProvider = ({ children }) => {
    const [auth, setAuth] = useState({ isAuthenticated: false, userRoles: [], token: null });
    const [user, setUser] = useState(null)

    const login = (roles, t, userObj) => {
        setAuth({ isAuthenticated: true, userRoles: roles, token: t });
        setUser(userObj);
        localStorage.setItem('user', JSON.stringify(userObj));
    };

    useEffect(() => {

    }, [auth]); // Include auth in the dependency array

    const logout = () => {
        setAuth({ isAuthenticated: false, userRoles: [] });
        setUser(null);
        localStorage.removeItem('user');
    };

    const getSessionData = () => {

        console.log("going to check");
        const storedUser = localStorage.getItem('user');

        // console.log(storedUser);
        return storedUser ? JSON.parse(storedUser) : null;
    };

    useEffect(() => {
        // Check if the user is already logged in when the app loads
        const storedUser = getSessionData();
        if (storedUser) {
            setUser(storedUser);
        }
    }, []);

    return (
        <AuthContext.Provider value={{ auth, setAuth, login, logout, user }}>
            {children}
        </AuthContext.Provider>

    )
}

export const useAuth = () => {
    return useContext(AuthContext);
}

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