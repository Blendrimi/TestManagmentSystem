import React from "react";
import { FaTrash } from "react-icons/fa";

const CartItem = ({ item, onRemove }) => {
  return (
    <div className="flex items-center gap-4 py-4 border-b border-gray-600">
      <img src={item.image} alt={item.title} className="w-24 h-24 object-cover rounded" />
      <div className="flex-1">
        <h3 className="font-semibold text-white">{item.title}</h3>
        <p className="text-sm text-gray-400">{item.description}</p>
      </div>
      <div className="text-white font-bold">${item.price.toFixed(2)}</div>
      <div className="text-white">x{item.count}</div>
      <button onClick={() => onRemove(item.id)} className="text-red-400 hover:text-red-600">
        <FaTrash />
      </button>
    </div>
  );
};

export default CartItem;
