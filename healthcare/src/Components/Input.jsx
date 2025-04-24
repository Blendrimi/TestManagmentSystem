import React from "react";

function Input({ name, value, onChange, placeholder, type = "text", required = false }) {
  return (
    <input
      name={name}
      value={value}
      onChange={onChange}
      placeholder={placeholder}
      type={type}
      required={required}
      className="border p-2 rounded w-full"
    />
  );
}

export default Input;
