import { useEffect } from "react";
import classes from ".//ShowAllDoctorsPage.module.css";
import DoctorCard from "./PageComponents/DoctorCard";
import FindDoctor from "./PageComponents/FindDoctor";
import Pagination from "./PageComponents/Pagination";
import { useDispatch, useSelector } from "react-redux";
import { fetchDoctors } from "../../../httpRequests/showAllDoctorsRequest";
import { useState } from "react";

function ShowAllDoctorsPage() {
  /*const dispatch = useDispatch();

  useEffect(()=>{
    dispatch(fetchDoctors);
  },[]);

  const doctorsData = useSelector(state => state.showAllDoctors.items);

  console.log(doctorsData);*/
  const [doctorsData, setDoctorsData] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch("https://localhost:7052/doctors?PageNumber=1&PageSize=30");
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
  }, []); // The empty dependency array ensures that this effect runs only once, similar to componentDidMount


  return (
    <div className={classes.background}>
      <div className={classes.container}>
        <FindDoctor />
        <DoctorCard />

        <div className={classes.radios}>
          <Pagination />
        </div>
      </div>
    </div>
  );
}

export default ShowAllDoctorsPage;
