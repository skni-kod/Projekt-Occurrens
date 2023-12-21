import { useEffect } from "react";
import classes from ".//ShowAllDoctorsPage.module.css";
import DoctorCard from "./PageComponents/DoctorCard";
import FindDoctor from "./PageComponents/FindDoctor";
import Pagination from "./PageComponents/Pagination";
import { useState } from "react";

function ShowAllDoctorsPage() {
  const [doctorsData, setDoctorsData] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch(
          "https://localhost:7052/doctors?PageNumber=1&PageSize=30"
        );
        if (!response.ok) {
          throw new Error("Failed to fetch data");
        }
        const data = await response.json();
        setDoctorsData(data);
        console.log("Fetched data:", data);
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    };

    fetchData();
  }, []);

  return (
    <div className={classes.background}>
      <div className={classes.container}>
        <FindDoctor />
        <DoctorCard data={doctorsData} />

        <div className={classes.radios}>
          <Pagination />
        </div>
      </div>
    </div>
  );
}

export default ShowAllDoctorsPage;
