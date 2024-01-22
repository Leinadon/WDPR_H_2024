import React, { useState } from 'react';

const ClickLogger = () => {
  const [startTime, setStartTime] = useState(null);

  const handleClick = (event) => {
    const clickTime = Date.now() - startTime;
    const clickPosition = {
      x: event.clientX,
      y: event.clientY
    };

    console.log(`Tijd tot klik: ${clickTime}ms, Klikpositie: x=${clickPosition.x}, y=${clickPosition.y}`);

    // Hier kun je de data opslaan of naar een server sturen
    // Voor nu loggen we het gewoon naar de console
  };

  const handlePageLoad = () => {
    setStartTime(Date.now());
  };

  useEffect(() => {
    handlePageLoad();
    document.addEventListener('click', handleClick);
    
    // Voeg een clean-up toe om event listeners te verwijderen bij het unmounten van het component
    return () => {
      document.removeEventListener('click', handleClick);
    };
  }, []); // Lege afhankelijkheidsarray zorgt ervoor dat het effect alleen wordt uitgevoerd bij montage en demontage van het component

  return (
    // JSX voor je component hier, bijvoorbeeld een leeg <div>
    <div></div>
  );
};

export default ClickLogger;
