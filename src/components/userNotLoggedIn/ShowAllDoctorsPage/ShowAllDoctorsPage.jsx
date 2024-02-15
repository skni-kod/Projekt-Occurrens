import { useEffect, useState } from "react";
import classes from ".//ShowAllDoctorsPage.module.css";
import DoctorCard from "./PageComponents/DoctorCard";
import FindDoctor from "./PageComponents/FindDoctor";
import Pagination from "./PageComponents/Pagination";

export default function ShowAllDoctorsPage() {
  const [doctorsData, setDoctorsData] = useState([]);
  const [howManyDoctors, setHowManyDoctors] = useState(10);

  const fetchData = async (numDoctors) => {
    try {
      const response = await fetch(
        `https://localhost:7052/doctors?PageNumber=1&PageSize=${numDoctors}`
      );
      if (!response.ok) {
        throw new Error("Failed to fetch data");
      }
      const data = await response.json();
      console.log(howManyDoctors);
      setDoctorsData(data);
    } catch (error) {
      console.error("Error fetching data:", error);
    }
  };

  useEffect(() => {
    fetchData(howManyDoctors);
  }, [howManyDoctors]);

  return (
    <div className={classes.background}>
      <div className={classes.container}>
        <FindDoctor />
        <DoctorCard data={doctorsData} />
        <div className={classes.radios}>
          <Pagination howManyDoctors={setHowManyDoctors} />
        </div>
      </div>
    </div>
  );
}
