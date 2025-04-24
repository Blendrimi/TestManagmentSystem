import React, { useState } from "react";
import { FaEdit, FaTrash, FaPlus } from "react-icons/fa";

const ProductPage = () => {
  const [products, setProducts] = useState([
    { id: 1, name: "Samosa", category: "Appetizer", price: 15.0 },
    { id: 2, name: "Paneer Tikka", category: "Appetizer", price: 13.99 },
    { id: 3, name: "Sweet Pie", category: "Dessert", price: 10.99 },
    { id: 4, name: "Malai Kofta", category: "Entree", price: 15.0 },
  ]);

  const handleDelete = (id) => {
    setProducts((prev) => prev.filter((p) => p.id !== id));
  };

  return (
    <div className="max-w-4xl mx-auto mt-10 bg-gray-800 text-white p-6 rounded shadow-md">
      <div className="flex justify-between items-center border-b border-gray-600 pb-3 mb-4">
        <h2 className="text-2xl font-semibold">Products List</h2>
        <button className="flex items-center gap-2 bg-gray-700 hover:bg-gray-600 px-4 py-2 rounded text-sm">
          <FaPlus /> Create New Product
        </button>
      </div>

      <table className="w-full text-left text-sm">
        <thead className="bg-gray-700 text-gray-300 uppercase">
          <tr>
            <th className="px-4 py-2">Name</th>
            <th className="px-4 py-2">Category Name</th>
            <th className="px-4 py-2">Price</th>
            <th className="px-4 py-2 text-center">Actions</th>
          </tr>
        </thead>
        <tbody>
          {products.map((product) => (
            <tr key={product.id} className="border-t border-gray-600 hover:bg-gray-700">
              <td className="px-4 py-2">{product.name}</td>
              <td className="px-4 py-2">{product.category}</td>
              <td className="px-4 py-2">${product.price.toFixed(2)}</td>
              <td className="px-4 py-2 text-center space-x-2">
                <button className="bg-green-500 hover:bg-green-600 px-3 py-1 rounded text-white">
                  <FaEdit />
                </button>
                <button
                  onClick={() => handleDelete(product.id)}
                  className="bg-red-500 hover:bg-red-600 px-3 py-1 rounded text-white"
                >
                  <FaTrash />
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default ProductPage;
