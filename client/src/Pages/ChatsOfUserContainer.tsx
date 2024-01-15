import React from 'react';
import { useParams } from 'react-router-dom';
import ChatsOfUser from './ChatsOfUser';

const ChatsOfUserContainer: React.FC = () => {
  const { id } = useParams<{ id: string }>();
  
  // Render ChatsOfUser component with the retrieved id
  return <ChatsOfUser userId1={id || ''} />;
};

export default ChatsOfUserContainer;