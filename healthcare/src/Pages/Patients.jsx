import React, { useState, useEffect } from "react";
import PatientForm from "../Components/PatientForm";
import PatientTable from "../Components/PatientTable";

function Patients() {
  const [patients, setPatients] = useState([]);
  const [editId, setEditId] = useState(null);

  // Fetch patients initially
  useEffect(() => {
    fetch("http://localhost:5000/patients")
      .then((res) => res.json())
      .then((data) => setPatients(data));
  }, []);

  const handleAddOrUpdate = (formData) => {
    if (editId) {
      // Edit patient
      fetch(`http://localhost:5000/patients/${editId}`, {
        method: "PUT",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(formData),
      })
        .then((res) => res.json())
        .then((updatedPatient) => {
          setPatients((prev) =>
            prev.map((p) => (p.id === editId ? updatedPatient : p))
          );
          setEditId(null);
        });
    } else {
      // Add new patient
      fetch("http://localhost:5000/patients", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(formData),
      })
        .then((res) => res.json())
        .then((newPatient) => {
          setPatients((prev) => [...prev, newPatient]);
        });
    }
  };

  const handleEdit = (id) => {
    const patient = patients.find((p) => p.id === id);
    setEditId(id);
    // Send patient data to form
    return patient;
  };

  const handleDelete = (id) => {
    fetch(`http://localhost:5000/patients/${id}`, {
      method: "DELETE",
    }).then(() =>
      setPatients((prev) => prev.filter((patient) => patient.id !== id))
    );
  };

  return (
    <div className="p-8 bg-gray-100 min-h-screen">
      <PatientForm onSubmit={handleAddOrUpdate} editId={editId} editData={handleEdit(editId)} />
      <PatientTable patients={patients} onEdit={setEditId} onDelete={handleDelete} />
    </div>
  );
}

export default Patients;
