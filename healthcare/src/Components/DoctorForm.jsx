import React, { useState, useEffect } from "react";

function DoctorForm({ onSave, editingDoctor }) {
  const [formData, setFormData] = useState({
    name: "",
    surname: "",
    age: "",
    specialty: "",
    experience: "",
  });

  useEffect(() => {
    if (editingDoctor) {
      setFormData(editingDoctor);
    }
  }, [editingDoctor]);

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    const payload = {
      ...formData,
      age: Number(formData.age),
      experience: Number(formData.experience),
    };
    onSave(payload);
    setFormData({
      name: "",
      surname: "",
      age: "",
      specialty: "",
      experience: "",
    });
  };

  return (
    <div className="max-w-4xl mx-auto bg-white p-6 rounded-lg shadow-md mt-10">
      <h2 className="text-2xl font-bold mb-6">
        {editingDoctor ? "Edit Doctor" : "Register New Doctor"}
      </h2>
      <form onSubmit={handleSubmit} className="grid grid-cols-1 sm:grid-cols-2 gap-4">
        <input
          name="name"
          value={formData.name}
          onChange={handleChange}
          placeholder="First Name"
          className="border p-2 rounded w-full"
          required
        />
        <input
          name="surname"
          value={formData.surname}
          onChange={handleChange}
          placeholder="Last Name"
          className="border p-2 rounded w-full"
          required
        />
        <input
          name="age"
          type="number"
          value={formData.age}
          onChange={handleChange}
          placeholder="Age"
          className="border p-2 rounded w-full"
          required
        />
        <input
          name="specialty"
          value={formData.specialty}
          onChange={handleChange}
          placeholder="Specialty"
          className="border p-2 rounded w-full"
          required
        />
        <input
          name="experience"
          type="number"
          value={formData.experience}
          onChange={handleChange}
          placeholder="Experience"
          className="border p-2 rounded w-full"
          required
        />

        <div className="sm:col-span-2 text-right mt-2">
          <button
            type="submit"
            className="bg-blue-600 hover:bg-blue-700 text-white px-6 py-2 rounded"
          >
            {editingDoctor ? "Update Doctor" : "Register Doctor"}
          </button>
        </div>
      </form>
    </div>
  );
}

export default DoctorForm;
