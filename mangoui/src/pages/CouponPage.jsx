import React, { useState } from "react";
import { FaTrash, FaPlus } from "react-icons/fa";

const CouponPage = () => {
  const [coupons, setCoupons] = useState([
    { code: "10OFF", discount: 10, minimum: 30 },
    { code: "20OFF", discount: 20, minimum: 50 },
  ]);

  const handleDelete = (code) => {
    setCoupons((prev) => prev.filter((c) => c.code !== code));
  };

  return (
    <div className="max-w-3xl mx-auto mt-10 bg-gray-800 p-6 rounded shadow text-white">
      <div className="flex justify-between items-center mb-4 border-b border-gray-600 pb-2">
        <h2 className="text-2xl font-semibold">Coupons List</h2>
        <button className="flex items-center gap-2 px-3 py-1 bg-gray-700 hover:bg-gray-600 text-sm rounded">
          <FaPlus /> Create New Coupon
        </button>
      </div>

      <div className="overflow-x-auto">
        <table className="w-full text-left text-sm">
          <thead className="bg-gray-700 text-gray-200 uppercase">
            <tr>
              <th className="px-4 py-2">Coupon Code</th>
              <th className="px-4 py-2">Discount Amount</th>
              <th className="px-4 py-2">Minimum Amount</th>
              <th className="px-4 py-2 text-center">Action</th>
            </tr>
          </thead>
          <tbody>
            {coupons.map((coupon) => (
              <tr key={coupon.code} className="border-t border-gray-600 hover:bg-gray-700">
                <td className="px-4 py-2">{coupon.code}</td>
                <td className="px-4 py-2">${coupon.discount.toFixed(2)}</td>
                <td className="px-4 py-2">${coupon.minimum.toFixed(2)}</td>
                <td className="px-4 py-2 text-center">
                  <button
                    onClick={() => handleDelete(coupon.code)}
                    className="bg-red-500 hover:bg-red-600 text-white px-3 py-1 rounded"
                  >
                    <FaTrash />
                  </button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default CouponPage;
