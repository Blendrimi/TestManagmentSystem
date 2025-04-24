import React from "react";

function Button({ type = "button", children, onClick, variant = "primary" }) {
  const base = "px-4 py-2 rounded text-white";
  const styles = {
    primary: "bg-blue-600 hover:bg-blue-700",
    warning: "bg-yellow-400 hover:bg-yellow-500",
    danger: "bg-red-500 hover:bg-red-600",
  };

  return (
    <button
      type={type}
      onClick={onClick}
      className={`${base} ${styles[variant]}`}
    >
      {children}
    </button>
  );
}

export default Button;
