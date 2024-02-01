import { createContext, useState, useContext, useEffect } from 'react';

const AuthContext = createContext();

export const AuthProvider = ({ children }) => {
    const [auth, setAuth] = useState({ isAuthenticated: false, userRoles: [], token: null });
    const [user, setUser] = useState(null)

    const login = (roles, t, userObj) => {
        setAuth(prev => ({
            ...prev,
            isAuthenticated: true,
            userRoles: roles,
            token: t
        }));

        setUser(userObj);
        localStorage.setItem('user', JSON.stringify(userObj));
        localStorage.setItem('roles', JSON.stringify(roles));
    };



    const logout = () => {
        setAuth({ isAuthenticated: false, userRoles: [] });
        setUser(null);
        localStorage.removeItem('user');
        localStorage.removeItem('roles');
    };

    const getSessionData = () => {
        try {
            const stored = localStorage.getItem('user');
            return stored ? JSON.parse(stored) : null;
        } catch (error) {
            // console.log(storedUser);
            console.error('Error parsing stored data:', error);
            return null;
        }
    };

    useEffect(() => {
        // Check if the user is already logged in when the app loads
        const storedUser = getSessionData();
        if (storedUser) {
            setUser(storedUser);
        }

        // const storedRoles = getSessionData('roles');
        // if (storedRoles) {
        //     setUser(storedRoles);
        // }
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