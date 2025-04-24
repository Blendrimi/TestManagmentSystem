import React, { useEffect, useState } from "react";

function PatientTable() {
  const [patients, setPatients] = useState([]);
  const [doctors, setDoctors] = useState([]);
  const [diagnoses, setDiagnoses] = useState([]);

  const fetchPatients = () => {
    fetch("http://localhost:5000/patients")
      .then((res) => res.json())
      .then((data) => setPatients(data));
  };

  useEffect(() => {
    fetchPatients();

    // Also fetch doctors and diagnoses
    fetch("http://localhost:5000/doctors")
      .then((res) => res.json())
      .then((data) => setDoctors(data));

    fetch("http://localhost:5000/diagnoses")
      .then((res) => res.json())
      .then((data) => setDiagnoses(data));
  }, []);

  const getDoctorName = (id) => {
    const doctor = doctors.find((d) => Number(d.id) === Number(id));
    return doctor ? doctor.name : "Unknown";
  };
  
  const getDiagnosisName = (id) => {
    const diagnosis = diagnoses.find((d) => Number(d.id) === Number(id));
    return diagnosis ? diagnosis.name : "Unknown";
  };
  

  return (
    <div className="max-w-5xl mx-auto mt-10 p-4">
      <h2 className="text-2xl font-bold mb-4">Patient List</h2>

      <table className="min-w-full border border-gray-300 text-center rounded-md overflow-hidden">
        <thead className="bg-gray-100">
          <tr>
            <th className="border p-2">First Name</th>
            <th className="border p-2">Last Name</th>
            <th className="border p-2">Age</th>
            <th className="border p-2">Doctor</th>
            <th className="border p-2">Diagnosis</th>
            <th className="border p-2">Actions</th>
          </tr>
        </thead>
        <tbody>
          {patients.map((p) => (
            <tr key={p.id} className="hover:bg-gray-50">
              <td className="border p-2">{p.name}</td>
              <td className="border p-2">{p.surname}</td>
              <td className="border p-2">{p.age}</td>
              <td className="border p-2">
                {p.doctor || getDoctorName(p.doctorId)}
              </td>
              <td className="border p-2">
                {p.diagnosis || getDiagnosisName(p.diagnosisId)}
              </td>
              <td className="border p-2 space-x-2">
                {/* Your edit/delete buttons here */}
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default PatientTable;
