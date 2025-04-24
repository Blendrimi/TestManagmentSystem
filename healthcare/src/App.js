import { Routes, Route } from "react-router-dom";
import Header from "./Components/Header";
import HomePage from "./Pages/HomePage";
import About from "./Pages/About";
import Contact from "./Pages/Contact";
import RegisterPatient from "./Pages/RegisterPatient";
import RegisterDoctor from "./Pages/RegisterDoctor"; 
import Doctors from "./Pages/Doctors";

function App() {
  return (
    <>
      <Header />
      <div className="pt-[100px]">
        <Routes>
          <Route path="/" element={<HomePage />} />
          <Route path="/register-doctor" element={<RegisterDoctor />} /> 
          <Route path="/doctors" element={<Doctors />} />
          <Route path="/about-us" element={<About />} />
          <Route path="/contact-us" element={<Contact />} />
          <Route path="/register-patient" element={<RegisterPatient />} />  
        </Routes>
      </div>
    </>
  );
}
export default App;
