import React from "react";

function DoctorTable({ doctors, onEdit, onDelete }) {
  return (
    <div className="max-w-6xl mx-auto mt-10 p-4">
      <h2 className="text-2xl font-bold mb-4">Doctor List</h2>
      <table className="min-w-full border border-gray-300 text-center rounded-md overflow-hidden">
        <thead className="bg-gray-100">
          <tr>
            <th className="border p-2">Name</th>
            <th className="border p-2">Surname</th>
            <th className="border p-2">Age</th>
            <th className="border p-2">Specialty</th>
            <th className="border p-2">Experience</th>
            <th className="border p-2">Actions</th>
          </tr>
        </thead>
        <tbody>
          {doctors.map((d) => (
            <tr key={d.id} className="hover:bg-gray-50">
              <td className="border p-2">{d.name}</td>
              <td className="border p-2">{d.surname}</td>
              <td className="border p-2">{d.age}</td>
              <td className="border p-2">{d.specialty}</td>
              <td className="border p-2">{d.experience}</td>
              <td className="border p-2 space-x-2">
                <button
                  onClick={() => onEdit(d)}
                  className="bg-yellow-400 hover:bg-yellow-500 text-white px-3 py-1 rounded"
                >
                  Edit
                </button>
                <button
                  onClick={() => onDelete(d.id)}
                  className="bg-red-500 hover:bg-red-600 text-white px-3 py-1 rounded"
                >
                  Delete
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default DoctorTable;
