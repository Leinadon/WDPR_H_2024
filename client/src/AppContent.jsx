
import { useMsal, useMsalAuthentication } from '@azure/msal-react';

export const AppContent = () => {
  const { accounts, inProgress } = useMsal();
  const { login } = useMsalAuthentication();

  if (inProgress === 'login') {
    return <div>Logging in...</div>;
  }

  if (!accounts || accounts.length === 0) {
    return <button onClick={() => login()}>Log in</button>;
  }

  // Render your authenticated content here

  return (
    <div>
      <p>Welcome, {accounts[0].username}</p>
      <button onClick={() => msalInstance.logout()}>Log out</button>
    </div>
  );
};
