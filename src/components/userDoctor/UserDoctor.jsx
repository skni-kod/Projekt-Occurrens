import styles from "./userDoctor.module.css";
import DoctorProfile from "./DoctorProfile";

function UserDoctor() {
    
    
    
    return (
    <div className={styles.site}>
        <div className={styles.transparent}>
            <h1>Twój profil</h1>
            <DoctorProfile/>
        </div>
    </div>
);
  };
  
  export default UserDoctor;