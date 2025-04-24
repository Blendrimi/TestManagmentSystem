import { NavLink } from 'react-router-dom';
import logo from '../assets/logo.png'; // Ensure path is correct

function Header() {
  return (
    <header className="bg-[#02174e] text-white fixed w-full top-0 left-0 z-50 shadow-md">
      <div className="container mx-auto flex justify-between items-center p-4">
        <div className="flex items-center gap-2">
          <img src={logo} alt="Logo" className="w-10 h-10" />
          <h1 className="text-2xl font-bold">HealthCare</h1>
        </div>
        <nav className="flex gap-6 text-lg">
          <NavLink to="/" className="hover:text-green-400">Home</NavLink>
          <NavLink to="/register-patient" className="hover:text-blue-500">Register Patient</NavLink>
          <NavLink to="/register-doctor" className="hover:text-blue-500">
  Register Doctor
</NavLink>
          <NavLink to="/about-us" className="hover:text-green-400">About-us</NavLink>
          <NavLink to="/contact-us" className="hover:text-green-400">Contact-us</NavLink>
        </nav>
      </div>
    </header>
  );
}

export default Header;
