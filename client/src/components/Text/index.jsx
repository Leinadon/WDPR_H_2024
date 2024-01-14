import React from "react";

const sizeClasses = {
  txtInterMedium24: "font-inter font-medium",
  txtInterMedium16: "font-inter font-medium",
  txtJockeyOneRegular36: "font-jockeyone font-normal",
  txtInterBlack14: "font-black font-inter",
  txtInterBlack20Black900: "font-black font-inter",
  txtInterBlack20: "font-black font-inter",
  txtInterSemiBold20: "font-inter font-semibold",
  txtJockeyOneRegular28: "font-jockeyone font-normal",
  txtJockeyOneRegular60: "font-jockeyone font-normal",
  txtJockeyOneRegular32: "font-jockeyone font-normal",
  txtInterBlack18: "font-black font-inter",
  txtInterBlack16: "font-black font-inter",
  txtJockeyOneRegular20: "font-jockeyone font-normal",
};

const Text = ({ children, className = "", size, as, ...restProps }) => {
  const Component = as || "p";

  return (
    <Component
      className={`text-left ${className} ${size && sizeClasses[size]}`}
      {...restProps}
    >
      {children}
    </Component>
  );
};

export { Text };
