import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Header from "./components/Header";
import ProductList from "./components/ProductList";
import ShoppingCart from "./pages/ShoppingCart";  
import ProductDetails from "./pages/ProductDetails";
import ManageOrders from "./pages/ManageOrder";
import CouponPage from './pages/CouponPage';
import ProductPage from "./pages/ProductPage";

function App() {
  return (
    <Router>
      <div className="bg-gray-900 min-h-screen text-white">
        <Header />
        <Routes>
          <Route path="/" element={<ProductList />} />
          <Route path="/cart" element={<ShoppingCart />} />
          <Route path="/product/:productId" element={<ProductDetails />} />
          <Route path="/orders" element={<ManageOrders />} />
          <Route path="/coupon" element={<CouponPage />} />
          <Route path="/products" element={<ProductPage />} />
          <Route path="/product-management" element={<ProductPage />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
