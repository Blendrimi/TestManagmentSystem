import React, { useEffect, useState } from "react";
import DoctorForm from "../Components/DoctorForm";
import DoctorTable from "../Components/DoctorTable";

function RegisterDoctor() {
  const [doctors, setDoctors] = useState([]);
  const [editingDoctor, setEditingDoctor] = useState(null);

  const fetchDoctors = () => {
    fetch("http://localhost:5000/doctors")
      .then((res) => res.json())
      .then((data) => setDoctors(data));
  };

  useEffect(() => {
    fetchDoctors();
  }, []);

  const handleSaveDoctor = (doctor) => {
    const isEdit = doctor.id !== undefined;

    const url = isEdit
      ? `http://localhost:5000/doctors/${doctor.id}`
      : "http://localhost:5000/doctors";

    const method = isEdit ? "PUT" : "POST";

    fetch(url, {
      method,
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(doctor),
    })
      .then((res) => res.json())
      .then((data) => {
        if (isEdit) {
          setDoctors((prev) =>
            prev.map((d) => (d.id === data.id ? data : d))
          );
        } else {
          setDoctors((prev) => [...prev, data]);
        }
        setEditingDoctor(null);
      });
  };

  const handleDeleteDoctor = (id) => {
    fetch(`http://localhost:5000/doctors/${id}`, {
      method: "DELETE",
    }).then(() => {
      setDoctors((prev) => prev.filter((d) => d.id !== id));
    });
  };

  return (
    <div className="p-8 bg-gray-100 min-h-screen">
      <DoctorForm onSave={handleSaveDoctor} editingDoctor={editingDoctor} />
      <DoctorTable
        doctors={doctors}
        onEdit={setEditingDoctor}
        onDelete={handleDeleteDoctor}
      />
    </div>
  );
}

export default RegisterDoctor;
