/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./src/**/*.{js,jsx,ts,tsx}",
  ],
  theme: {
    extend: {
      colors: {
        teal: { 400: "#1ca883" },
        deep_orange: { 50: "#f8f0e5" },
        gray: { 400: "#c3c3c3", 500: "#979898" },
        blue_gray: {
          100: "#d9d9d9",
          900: "#102c57",
          "100_01": "#cbcbcb",
          "100_02": "#d3d3d3",
          "900_01": "#122541",
        },
        black: { 900: "#000000" },
        white: { A700: "#ffffff" },
      },
      fontFamily: { inter: "Inter", jockeyone: "Jockey One" },
    },
  },
  plugins: [require("@tailwindcss/forms")],
}

