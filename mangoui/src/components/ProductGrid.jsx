import React from "react";
import ProductCard from "./ProductCard";
import { useNavigate } from "react-router-dom";

const ProductGrid = ({ products }) => {
  const navigate = useNavigate();  

  return (
<div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 xl:grid-cols-5 gap-4 p-4">
      {products.map((product) => (
        <ProductCard
          key={product.id}
          title={product.title}
          image={product.image}
          price={product.price}
          description={product.description}
          category={product.category}
          onDetails={() => navigate(`/product/${product.id}`)}  
        />
      ))}
    </div>
  );
};

export default ProductGrid;
