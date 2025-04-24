import React, { useState } from "react";
import { FaShoppingCart } from "react-icons/fa";
import CartItem from "../components/CartItem";

const ShoppingCart = () => {
  const [cartItems, setCartItems] = useState([
    {
      id: 1,
      title: "Paneer Tikka",
      price: 13.99,
      count: 1,
      image: "https://plus.unsplash.com/premium_photo-1669742928112-19364a33b530?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8ZGVsaWNpb3VzJTIwZm9vZHxlbnwwfHwwfHx8MA%3D%3D",
      description: "Grilled marinated paneer cubes with spices.",
    },
    {
      id: 2,
      title: "Sweet Pie",
      price: 10.99,
      count: 1,
      image: "https://plus.unsplash.com/premium_photo-1669742928112-19364a33b530?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8ZGVsaWNpb3VzJTIwZm9vZHxlbnwwfHwwfHx8MA%3D%3D",
      description: "Sweet pie made with milk, carrots, and nuts.",
    },
  ]);
  const [coupon, setCoupon] = useState("");
  const total = cartItems.reduce((sum, item) => sum + item.price * item.count, 0).toFixed(2);

  const handleRemove = (id) => {
    setCartItems(cartItems.filter((item) => item.id !== id));
  };

  return (
    <div className="max-w-4xl mx-auto mt-10 bg-gray-800 p-6 rounded-md shadow-md text-white">
      <div className="flex items-center justify-between mb-4">
        <h2 className="text-2xl font-bold flex items-center gap-2 text-green-400">
          <FaShoppingCart /> Shopping Cart
        </h2>
        <button className="text-sm px-3 py-1 border border-yellow-400 text-yellow-400 hover:bg-yellow-400 hover:text-black rounded">
          Continue Shopping
        </button>
      </div>

      <div className="border-b border-gray-600 pb-2 mb-2 text-sm text-gray-300 uppercase">
        <div className="grid grid-cols-12 gap-2">
          <div className="col-span-5">Product Details</div>
          <div className="col-span-3">Price</div>
          <div className="col-span-2">Count</div>
          <div className="col-span-2"></div>
        </div>
      </div>

      {cartItems.map((item) => (
        <CartItem key={item.id} item={item} onRemove={handleRemove} />
      ))}

      <div className="mt-4 flex items-center gap-2">
        <label className="text-white">Coupon:</label>
        <input
          type="text"
          value={coupon}
          onChange={(e) => setCoupon(e.target.value)}
          className="bg-gray-700 border border-gray-500 px-3 py-1 rounded"
        />
        <button className="bg-green-500 px-3 py-1 rounded text-white hover:bg-green-600">Apply</button>
      </div>

      <div className="text-right text-red-400 font-bold mt-4 text-lg">
        Order Total: ${total}
      </div>

      <div className="mt-6 flex justify-between items-center">
        <button className="border border-red-400 text-red-400 px-4 py-2 rounded hover:bg-red-500 hover:text-white">
          Email Cart
        </button>
        <button className="bg-green-500 text-white px-4 py-2 rounded hover:bg-green-600">
          Looks Good?
        </button>
      </div>
    </div>
  );
};

export default ShoppingCart;
