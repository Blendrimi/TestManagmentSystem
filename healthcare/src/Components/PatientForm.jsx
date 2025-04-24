import React, { useState, useEffect } from "react";
import Input from "../Components/Input";
import Select from "../Components/Select";
import Button from "../Components/Button";
import Form from "../Components/Form";
import Table from "../Components/Table";

function PatientForm() {
  const [formData, setFormData] = useState({
    name: "",
    surname: "",
    age: "",
    doctorId: "",
    diagnosisId: "",
  });

  const [patients, setPatients] = useState([]);
  const [doctors, setDoctors] = useState([]);
  const [diagnoses, setDiagnoses] = useState([]);
  const [editingId, setEditingId] = useState(null);

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    const id = typeof editingId === "string" ? Number(editingId) : editingId;
    const method = editingId ? "PUT" : "POST";
    const url = editingId
      ? `http://localhost:5000/patients/${id}`
      : "http://localhost:5000/patients";

    const payload = {
      name: formData.name,
      surname: formData.surname,
      age: Number(formData.age),
      doctorId: Number(formData.doctorId),
      diagnosisId: Number(formData.diagnosisId),
    };

    fetch(url, {
      method,
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(payload),
    })
      .then((res) => res.json())
      .then((data) => {
        if (editingId) {
          setPatients((prev) =>
            prev.map((p) => (Number(p.id) === id ? { ...p, ...payload } : p))
          );
        } else {
          setPatients((prev) => [...prev, data]);
        }

        setFormData({
          name: "",
          surname: "",
          age: "",
          doctorId: "",
          diagnosisId: "",
        });
        setEditingId(null);
      })
      .catch((err) => console.error("Failed to save patient", err));
  };

  const handleEdit = (patient) => {
    setFormData({
      name: patient.name,
      surname: patient.surname,
      age: patient.age,
      doctorId: String(patient.doctorId),
      diagnosisId: String(patient.diagnosisId),
    });
    setEditingId(patient.id);
  };

  const handleDelete = (id) => {
    fetch(`http://localhost:5000/patients/${id}`, {
      method: "DELETE",
    }).then(() => setPatients((prev) => prev.filter((p) => p.id !== id)));
  };

  useEffect(() => {
    fetch("http://localhost:5000/patients")
      .then((res) => res.json())
      .then((data) => setPatients(data));

    fetch("http://localhost:5000/doctors")
      .then((res) => res.json())
      .then((data) => setDoctors(data));

    fetch("http://localhost:5000/diagnoses")
      .then((res) => res.json())
      .then((data) => setDiagnoses(data));
  }, []);

  const getDoctorName = (id) =>
    doctors.find((d) => String(d.id) === String(id))?.name || "—";

  const getDiagnosisName = (id) =>
    diagnoses.find((d) => String(d.id) === String(id))?.name || "—";

  return (
    <div className="max-w-6xl mx-auto p-6 mt-6">
      <h2 className="text-2xl font-bold mb-4">
        {editingId ? "Edit Patient" : "Register New Patient"}
      </h2>
      <Form onSubmit={handleSubmit} className="grid grid-cols-2 gap-4">
        <Input
          name="name"
          value={formData.name}
          onChange={handleChange}
          placeholder="First Name"
          required
        />
        <Input
          name="surname"
          value={formData.surname}
          onChange={handleChange}
          placeholder="Last Name"
          required
        />
        <Input
          name="age"
          type="number"
          value={formData.age}
          onChange={handleChange}
          placeholder="Age"
          required
        />
        <Select
          name="doctorId"
          value={formData.doctorId}
          onChange={handleChange}
          options={doctors}
          placeholder="Select Doctor"
          required
        />
        <Select
          name="diagnosisId"
          value={formData.diagnosisId}
          onChange={handleChange}
          options={diagnoses}
          placeholder="Select Diagnosis"
          required
        />
        <div className="col-span-2 text-right">
          <Button
            type="submit"
            className="bg-green-600 hover:bg-green-700"
          >
            {editingId ? "Update" : "Register"}
          </Button>
        </div>
      </Form>

      <h3 className="text-xl font-semibold mt-10 mb-2">Patient List</h3>
      <Table
        columns={["name", "surname", "age", "doctor", "diagnosis"]}
        data={patients.map((p) => ({
            name: p.name,
            surname: p.surname,
            age: p.age,
            doctor: getDoctorName(p.doctorId),
            diagnosis: getDiagnosisName(p.diagnosisId),
            id: p.id,  
            raw: p,    
        }))}
        actions={(row) => (
            <>
            <button
                onClick={() => handleEdit(row.raw)}
                className="bg-yellow-400 hover:bg-yellow-500 text-white px-3 py-1 rounded"
            >
                Edit
            </button>
            <button
                onClick={() => handleDelete(row.id)}
                className="bg-red-500 hover:bg-red-600 text-white px-3 py-1 rounded"
            >
                Delete
            </button>
            </>
            )}
      />

    </div>
  );
}

export default PatientForm;
