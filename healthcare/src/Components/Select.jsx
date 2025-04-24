import React from "react";

function Select({ name, value, onChange, options, labelKey = "name", valueKey = "id", placeholder }) {
  return (
    <select
      name={name}
      value={value}
      onChange={onChange}
      className="border p-2 rounded"
      required
    >
      <option value="">{placeholder}</option>
      {options.map((item) => (
        <option key={item[valueKey]} value={item[valueKey]}>
          {item[labelKey]}
        </option>
      ))}
    </select>
  );
}

export default Select;
