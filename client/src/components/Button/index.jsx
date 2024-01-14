import React from "react";
import PropTypes from "prop-types";

const shapes = { round: "rounded-[27px]" };
const variants = {
  fill: {
    blue_gray_100_01: "bg-blue_gray-100_01 text-black-900",
    teal_400: "bg-teal-400 text-black-900",
  },
};
const sizes = {
  xs: "p-0.5",
  sm: "p-[5px]",
  md: "p-2.5",
  lg: "p-[15px]",
  xl: "p-[18px]",
};

const Button = ({
  children,
  className = "",
  leftIcon,
  rightIcon,
  shape = "",
  size = "lg",
  variant = "",
  color = "",
  ...restProps
}) => {
  return (
    <button
      className={`${className} ${(shape && shapes[shape]) || ""} ${
        (size && sizes[size]) || ""
      } ${(variant && variants[variant]?.[color]) || ""}`}
      {...restProps}
    >
      {!!leftIcon && leftIcon}
      {children}
      {!!rightIcon && rightIcon}
    </button>
  );
};

Button.propTypes = {
  className: PropTypes.string,
  children: PropTypes.node,
  shape: PropTypes.oneOf(["round"]),
  size: PropTypes.oneOf(["xs", "sm", "md", "lg", "xl"]),
  variant: PropTypes.oneOf(["fill"]),
  color: PropTypes.oneOf(["blue_gray_100_01", "teal_400"]),
};

export { Button };
