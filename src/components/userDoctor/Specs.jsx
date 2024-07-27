import styles from "./userDoctor.module.css";
import editPencil from  "../../icons/edit-3-svgrepo-com.svg";
import { useState } from "react";
import SpecsPopup from './userDoctorPopups/SpecsPopup';
import '../userDoctor/userDoctorPopups/UserDataPopup';


const Specs = () => {
    const [specsButtonPopup, setSpecsTrigger] = useState(false); 
    return ( 
        <div className={`${styles.specs} ${styles.gridBox}`}>
            <SpecsPopup trigger = { specsButtonPopup } setTrigger = { setSpecsTrigger }>
                <p>ELO</p>
            </SpecsPopup>
            <h2>
            Specjalizacje 
            <button onClick={() => { setSpecsTrigger(true)}}>
                <img src={editPencil} alt="edit button"/>
            </button>
            </h2>
        <div className={styles.specsList}>

        </div>
            
    </div>
     );
}
 
export default Specs;