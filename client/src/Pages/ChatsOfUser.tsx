// ChatsOfUser.js

import React, { useState, useEffect } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { Button, Img, Text } from "../components";
import { getChatsOfUser, getUser } from "./ApiServices";
import '../styles/ChatsOfUser.css';

interface ChatsOfUserProps {
  userId1: string;
  

}
interface Chat {
  id: string;
  user1Id: string;
  user2Id: string;
  // Add more properties as needed
}

const ChatsOfUser: React.FC<ChatsOfUserProps> = ({ userId1 }) => {
  const [chats, setChats] = useState<Chat[] | null>(null);

  

  useEffect(() => {
    const fetchChats = async (userId1: string) => {
      try {
        const data = await getChatsOfUser(userId1);
        setChats(data as Chat[]);
      } catch (error) {
        console.error('Error fetching chats:', error);
      }
    };

    if (userId1) {
      fetchChats(userId1);
    }
  },[userId1]);
    

  return (
    <div className="chats-bedrijf">
    {/* Your component JSX */}
    {/* ... */}
    <div className="overlap-2">
      {chats?.map((chat) => (
        <div key={chat.id} className="chat-item">
          {/* Render chat details */}
          <p className="text-wrapper-3">{chat.user1Id}</p>
          <div className="text-wrapper-4">{chat.user2Id}</div>
          {/* Add more details as needed */}
        </div>
      ))}
    </div>
    {/* ... */}
  </div>
  );
};

export default ChatsOfUser;