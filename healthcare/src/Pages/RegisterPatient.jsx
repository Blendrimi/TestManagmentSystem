import React from 'react';
import PatientForm from '../Components/PatientForm';

function RegisterPatient() {
  const handlePatientSubmit = (data) => {
    console.log("Registered patient:", data);
    // Optional: Save to local state or backend
  };

  return (
    <div className="bg-gray-100 min-h-screen p-4">
      <PatientForm onSubmit={handlePatientSubmit} />
    </div>
  );
}

export default RegisterPatient;
