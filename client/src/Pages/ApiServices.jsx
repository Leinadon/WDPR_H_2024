// ApiService.js

const BASE_URL = "https://localhost:7258/api/";

export const getChatsOfUser = async (userId) => {
  try {
    const response = await fetch(`${BASE_URL}/chats/users/{userId}`);
    const data = await response.json();
    return data;
  } catch (error) {
    console.error("Error fetching chat data:", error);
    throw error; // Rethrow the error for handling in the component
  }
};

export const getUser = async (userID) => {
    try {
        const response = await fetch(`${BASE_URL}/users/{userId}`);
        const data = await response.json();
        return data;

    } catch(error){
        console.error("Error fetching user data: ", error);
        throw error;

    }
};
