import { useState, useEffect } from "react";
import CustomerService from "../servives/CustomerService";

export type Customer = {
  id: string;
  companyName: string;
  contactName: string;
  contactTitle: string;
  address: string;
  city: string;
  region: string | null;
  postalCode: string;
  country: string;
  phone: string;
  fax: string | null;
};

const CustomerList = () => {
  const [customers, setCustomers] = useState([]);

  useEffect(() => {
    CustomerService.getAll().then((data) => setCustomers(data));
  }, []);
  return (
    <>
      <h2 style={{ textAlign: "center", margin: "20px 0" }}>Customers</h2>
      <div
        style={{
          display: "grid",
          gridTemplateColumns: "repeat(auto-fill, minmax(250px, 1fr))",
          gap: "20px",
          padding: "0 20px",
        }}
      >
        {customers.map((customer: Customer) => (
          <div
            key={customer.id}
            style={{
              border: "1px solid #ddd",
              borderRadius: "10px",
              padding: "15px",
              boxShadow: "0 2px 8px rgba(0,0,0,0.1)",
              backgroundColor: "#fff",
              transition: "transform 0.2s",
            }}
            onMouseEnter={(e) =>
              (e.currentTarget.style.transform = "scale(1.03)")
            }
            onMouseLeave={(e) => (e.currentTarget.style.transform = "scale(1)")}
          >
            <h3 style={{ marginBottom: "5px", color: "#2c3e50" }}>
              {customer.companyName}
            </h3>
            <p>
              <strong>Contact:</strong> {customer.contactName} (
              {customer.contactTitle})
            </p>
            <p>
              <strong>Address:</strong> {customer.address}, {customer.city}{" "}
              {customer.postalCode}
            </p>
            {customer.region && (
              <p>
                <strong>Region:</strong> {customer.region}
              </p>
            )}
            <p>
              <strong>Country:</strong> {customer.country}
            </p>
            <p>
              <strong>Phone:</strong> {customer.phone}
            </p>
            {customer.fax && (
              <p>
                <strong>Fax:</strong> {customer.fax}
              </p>
            )}
          </div>
        ))}
      </div>
    </>
  );
};

export default CustomerList;
