import classes from ".//ShowAllDoctorsPage.module.css";
import DoctorCard from "./PageComponents/DoctorCard";
import FindDoctor from "./PageComponents/FindDoctor";
import Pagination from "./PageComponents/Pagination";

function ShowAllDoctorsPage() {

  return (
    <div className={classes.background}>
      <div className={classes.container}>
        <FindDoctor />
        <DoctorCard />

        <div className={classes.radios}>
          <Pagination/>
        </div>
      </div>
    </div>
  );
}

export default ShowAllDoctorsPage;
