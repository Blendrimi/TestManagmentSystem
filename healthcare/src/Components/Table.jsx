import React from "react";

function Table({ columns = [], data = [], actions }) {
    return (
      <table className="min-w-full border border-gray-300 text-center rounded-md overflow-hidden">
        <thead className="bg-gray-100">
          <tr>
            {columns.map((col) => (
              <th key={col} className="border p-2">{col}</th>
            ))}
            {actions && <th className="border p-2">Actions</th>}
          </tr>
        </thead>
        <tbody>
          {data.map((row, i) => (
            <tr key={i} className="hover:bg-gray-50">
              {columns.map((col) => (
                <td key={col} className="border p-2">{row[col]}</td>
              ))}
              {actions && (
                <td className="border p-2 space-x-2">
                  {actions(row)}
                </td>
              )}
            </tr>
          ))}
        </tbody>
      </table>
    );
  }
  

export default Table;
