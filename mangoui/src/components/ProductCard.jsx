import React from "react";

function ProductCard({ image, title, price, description, category, onDetails }) {
  return (
    <div className="bg-gray-800 text-white rounded-md shadow-md overflow-hidden w-72 border border-gray-700">
      
      <div className="bg-gray-900 px-4 py-2 border-b border-gray-700 text-center">
        <h3 className="text-lg font-semibold">{title}</h3>
      </div>

      <img src={image} alt={title} className="w-full h-48 object-cover" />

      <div className="p-4">
        <div className="flex justify-between items-center mb-3">
          <p className="text-green-400 font-bold">${price}</p>
          <span className="bg-orange-500 text-xs px-3 py-2 rounded">
            {category}
          </span>
        </div>

        <p className="text-sm text-gray-300 mb-4">{description}</p>
        <button
          onClick={onDetails}
          className="bg-green-400 text-white px-4 py-2 rounded hover:bg-green-500 w-full"
        >
          Details
        </button>
      </div>
    </div>
  );
}

export default ProductCard;
