import React from "react";
import { Link, useNavigate } from "react-router-dom";
import { FaShoppingCart } from "react-icons/fa";

const Header = () => {
  const navigate = useNavigate();
  const userEmail = "admin@gmail.com";  

  return (
    <header className="bg-gray-800 text-white px-6 py-3 flex justify-between items-center shadow-md">
      
      {/* Left side: Logo and navigation */}
      <div className="flex items-center space-x-6">
        <div className="text-xl font-bold">Mango.Web</div>
        <nav className="flex items-center space-x-4">
          <Link to="/">Home</Link>

          {/* Dropdown placeholder */}
          <div className="relative group">
            <span className="cursor-pointer hover:text-yellow-400">
              Content Management ▾
            </span>
            <div className="absolute hidden group-hover:block bg-gray-700 mt-2 rounded shadow z-10">
              <Link to="/coupon" className="block px-4 py-2 hover:bg-gray-600">Coupon</Link>
              <Link to="/product-management" className="block px-4 py-2 hover:bg-gray-600">Product</Link>
            </div>
          </div>

          <Link to="/orders">Manage Order</Link>
          <FaShoppingCart
            onClick={() => navigate("/cart")}
            className="cursor-pointer hover:text-yellow-400"
          />
        </nav>
      </div>

      {/* Right side: Email + Logout */}
      <div className="flex items-center space-x-4">
        <span className="text-sm">Hello {userEmail}</span>
        <button
          onClick={() => alert("Logged out")} // Replace with your actual logout logic
          className="bg-gray-600 hover:bg-gray-500 text-white px-3 py-1 rounded text-sm"
        >
          Logout
        </button>
      </div>
    </header>
  );
};

export default Header;
