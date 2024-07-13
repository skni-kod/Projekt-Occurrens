import styles from "./userDoctor.module.css";
import editPencil from  "../../icons/edit-3-svgrepo-com.svg";
import UserData from "./UserData";
import Specs from "./Specs";
import Offices from "./Offices";

const DoctorProfile = () => {
    return ( 
        <div className={styles.doctorProfile}>
        <UserData/>
        <Specs/>
        <Offices/>
    </div>

     );
}
 
export default DoctorProfile;