import React from "react";

function Form({ onSubmit, children, className = "" }) {
  return (
    <form onSubmit={onSubmit} className={`bg-white p-6 rounded shadow ${className}`}>
      {children}
    </form>
  );
}

export default Form;
