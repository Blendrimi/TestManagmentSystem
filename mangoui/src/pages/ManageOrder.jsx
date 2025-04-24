import React, { useState } from "react";

const mockOrders = [
  { id: 1017, email: "laura@gmail.com", name: "Laura Stone", phone: "21341231212", status: "Approved", total: 59.98 },
  { id: 1016, email: "admin321@gmail.com", name: "Bhrugen", phone: "2349823749", status: "Approved", total: 32.98 },
  { id: 1015, email: "admin321@gmail.com", name: "Bhrugen", phone: "2349823749", status: "Approved", total: 21.98 },
  { id: 1014, email: "admin321@gmail.com", name: "Bhrugen", phone: "2349823749", status: "Approved", total: 21.98 },
  { id: 1013, email: "admin321@gmail.com", name: "Bhrugen", phone: "2349823749", status: "Approved", total: 21.98 },
  { id: 1012, email: "jess@gmail.com", name: "Jess Stone", phone: "2349823749", status: "Completed", total: 21.98 },
  { id: 14, email: "jess@gmail.com", name: "Jess Stone", phone: "2349823749", status: "Approved", total: 85.94 },
  { id: 13, email: "jess@gmail.com", name: "Jess Stone", phone: "2349823749", status: "Cancelled", total: 85.94 },
  { id: 12, email: "jess@gmail.com", name: "Jess Stone", phone: "2349823749", status: "Cancelled", total: 85.94 },
];

const ManageOrders = () => {
  const [filter, setFilter] = useState("All");
  const [search, setSearch] = useState("");

  const filteredOrders = mockOrders.filter((order) => {
    const matchesStatus = filter === "All" || order.status === filter;
    const matchesSearch = order.email.toLowerCase().includes(search.toLowerCase());
    return matchesStatus && matchesSearch;
  });

  return (
    <div className="max-w-6xl mx-auto mt-10 bg-gray-800 text-white p-6 rounded shadow-md">
      <h2 className="text-2xl font-bold mb-6">Order List</h2>

      {/* Filters */}
      <div className="flex justify-between items-center mb-4">
        <div className="space-x-2">
          {["Approved", "Ready for Pickup", "Cancelled", "All"].map((status) => (
            <button
              key={status}
              onClick={() => setFilter(status)}
              className={`px-3 py-1 border rounded ${
                filter === status ? "bg-gray-700 border-white" : "border-gray-500"
              }`}
            >
              {status}
            </button>
          ))}
        </div>
        <input
          type="text"
          placeholder="Search email..."
          className="bg-gray-700 border border-gray-500 px-3 py-1 rounded text-white"
          value={search}
          onChange={(e) => setSearch(e.target.value)}
        />
      </div>

      {/* Table */}
      <div className="overflow-auto">
        <table className="w-full text-sm text-left text-white border border-gray-600">
          <thead className="bg-gray-700 text-gray-200 uppercase">
            <tr>
              <th className="px-4 py-2">ID</th>
              <th className="px-4 py-2">Email</th>
              <th className="px-4 py-2">Name</th>
              <th className="px-4 py-2">Phone</th>
              <th className="px-4 py-2">Status</th>
              <th className="px-4 py-2">Total</th>
              <th className="px-4 py-2 text-center">Actions</th>
            </tr>
          </thead>
          <tbody>
            {filteredOrders.map((order) => (
              <tr key={order.id} className="border-t border-gray-600 hover:bg-gray-700">
                <td className="px-4 py-2">{order.id}</td>
                <td className="px-4 py-2">{order.email}</td>
                <td className="px-4 py-2">{order.name}</td>
                <td className="px-4 py-2">{order.phone}</td>
                <td className="px-4 py-2">{order.status}</td>
                <td className="px-4 py-2">${order.total.toFixed(2)}</td>
                <td className="px-4 py-2 text-center">
                  <button className="bg-gray-600 hover:bg-gray-500 px-3 py-1 rounded text-white">✏️</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default ManageOrders;
