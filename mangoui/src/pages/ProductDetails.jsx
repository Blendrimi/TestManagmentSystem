import React, { useState, useEffect } from "react";
import { useParams, useNavigate } from "react-router-dom";

const mockProducts = [
  {
    id: 1,
    title: "Samosa",
    price: 15.0,
    category: "Appetizer",
    description: "Crispy fried pastries with savory filling.",
    image: "https://plus.unsplash.com/premium_photo-1669742928112-19364a33b530?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8ZGVsaWNpb3VzJTIwZm9vZHxlbnwwfHwwfHx8MA%3D%3D",
  },
  {
    id: 2,
    title: "Paneer Tikka",
    price: 13.99,
    category: "Appetizer",
    description: "Grilled paneer cubes in spices.",
    image: "https://plus.unsplash.com/premium_photo-1669742928112-19364a33b530?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8ZGVsaWNpb3VzJTIwZm9vZHxlbnwwfHwwfHx8MA%3D%3D",
  },
  {
    id: 3,
    title: "Sweet Pie",
    price: 10.99,
    category: "Dessert",
    description: "Indian dessert made with milk and carrots.",
    image: "https://plus.unsplash.com/premium_photo-1669742928112-19364a33b530?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8ZGVsaWNpb3VzJTIwZm9vZHxlbnwwfHwwfHx8MA%3D%3D",
  },
];

const ProductDetails = () => {
  const { productId } = useParams();
  const navigate = useNavigate();
  const [quantity, setQuantity] = useState(1);
  const [product, setProduct] = useState(null);

  useEffect(() => {
    const found = mockProducts.find((p) => p.id === parseInt(productId));
    setProduct(found);
  }, [productId]);

  const handleAddToCart = () => {
    alert(`Added ${quantity} of ${product.title} to cart`);
  };

  if (!product) return <div className="text-white p-6">Loading...</div>;

  return (
    <div className="max-w-5xl mx-auto mt-10 bg-gray-800 p-6 rounded-md shadow-md text-white">
      <h2 className="text-3xl font-bold mb-4">{product.title}</h2>
      <div className="grid grid-cols-1 md:grid-cols-2 gap-8 items-start">
        <img
          src={product.image}
          alt={product.title}
          className="rounded-lg shadow object-cover w-full max-w-xs mx-auto"
        />
        <div>
          <span className="inline-block bg-green-700 px-3 py-1 rounded text-xs mb-2">
            {product.category}
          </span>
          <p className="text-sm text-gray-300 mb-4">{product.description}</p>
          <div className="text-orange-400 text-xl font-bold mb-4">
            ${product.price.toFixed(2)}
          </div>

          <input
            type="number"
            min="1"
            className="w-full p-2 rounded text-black mb-6"
            value={quantity}
            onChange={(e) => setQuantity(e.target.value)}
          />

          <div className="flex justify-between gap-4">
            <button
              onClick={() => navigate("/")}
              className="bg-green-500 px-6 py-2 rounded text-white hover:bg-green-600"
            >
              Back to List
            </button>
            <button
              onClick={handleAddToCart}
              className="bg-gray-600 px-6 py-2 rounded text-white hover:bg-gray-700"
            >
              Add to Cart
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default ProductDetails;
