import React from "react";
import ProductGrid from "./ProductGrid";

const ProductList = () => {
    const products = [
        {
          id: 1,
          title: "Samosa",
          price: 15.0,
          category: "Appetizer",
          description: "Crispy fried pastries filled with spicy potatoes and peas.",
          image: "https://plus.unsplash.com/premium_photo-1669742928112-19364a33b530?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8ZGVsaWNpb3VzJTIwZm9vZHxlbnwwfHwwfHx8MA%3D%3D",
        },
        {
          id: 2,
          title: "Paneer Tikka",
          price: 13.99,
          category: "Appetizer",
          description: "Marinated paneer cubes grilled with spices and veggies.",
          image: "https://plus.unsplash.com/premium_photo-1669742928112-19364a33b530?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8ZGVsaWNpb3VzJTIwZm9vZHxlbnwwfHwwfHx8MA%3D%3D",
        },
        {
          id: 3,
          title: "Sweet Pie",
          price: 10.99,
          category: "Dessert",
          description: "A rich and sweet pie made with milk, carrots, and nuts.",
          image: "https://plus.unsplash.com/premium_photo-1669742928112-19364a33b530?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8ZGVsaWNpb3VzJTIwZm9vZHxlbnwwfHwwfHx8MA%3D%3D",
        },

        {
            id: 4,
            title: "Sweet Pie",
            price: 10.99,
            category: "Dessert",
            description: "A rich and sweet pie made with milk, carrots, and nuts.",
            image: "https://plus.unsplash.com/premium_photo-1669742928112-19364a33b530?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8ZGVsaWNpb3VzJTIwZm9vZHxlbnwwfHwwfHx8MA%3D%3D",
          },

          {
            id: 5,
            title: "Sweet Pie",
            price: 10.99,
            category: "Dessert",
            description: "A rich and sweet pie made with milk, carrots, and nuts.",
            image: "https://plus.unsplash.com/premium_photo-1669742928112-19364a33b530?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8ZGVsaWNpb3VzJTIwZm9vZHxlbnwwfHwwfHx8MA%3D%3D",
          },
      ];
      

  return <ProductGrid products={products} />;
};

export default ProductList;
