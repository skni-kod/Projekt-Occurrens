import styles from "./userDoctor.module.css";
import editPencil from  "../../icons/edit-3-svgrepo-com.svg";
import OfficessPopup from "./userDoctorPopups/OfficesPopup";
import { useState } from "react";

const Offices = () => {
    const [officesButtonPopup, setofficesTrigger] = useState(false);
    return ( 
        <div className={`${styles.offices} ${styles.gridBox}`}>
            <OfficessPopup trigger= { officesButtonPopup } setTrigger = { setofficesTrigger }>
                <div className={`${styles.officesPopupFlex}`}>
                    <div>Miasto:</div>                  <input/>      
                    <div>Ulica:</div>                   <input/>
                    <div>Numer budynku:</div>           <input/>
                    <div>Numer lokalu:</div>            <input/>
                    <div>Kod pocztowy:</div>            <input/>
                    <h4>
                    Godziny otwarcia:
                    </h4>              
                    <div>Poniedziałek:</div>            <input/>
                    <div>Wtorek:</div>                  <input/>
                    <div>Środa:</div>                   <input/>
                    <div>Czwartek:</div>                <input/>
                    <div>Piątek:</div>                  <input/>
                    <div>Sobota:</div>                  <input/>
                    <div>Niedziela:</div>               <input/>
                    <button>SAVE</button>
                </div>
            </OfficessPopup>
            <h2>Gabinety &nbsp; 
            <button onClick={ () => { setofficesTrigger(true) } }>
                <img src={ editPencil } alt="edit pencil"/>
            </button>
            </h2>
        <div className={styles.officesData}>
                    <div>Miasto:</div>                   <div> a </div>
                    <div>Ulica:</div>                    <div> b </div>
                    <div>Numer budynku:</div>            <div> c </div>
                    <div>Numer lokalu:</div>             <div> d </div>
                    <div>Kod pocztowy:</div>             <div> e </div>
                    <h4 className={styles.open}>
                    Godziny otwarcia:</h4>              <div>   </div>
                    <div>Poniedziałek:</div>            <div> e </div>
                    <div>Wtorek:</div>                  <div> e </div>
                    <div>Środa:</div>                   <div> e </div>
                    <div>Czwartek:</div>                <div> e </div>
                    <div>Piątek:</div>                  <div> e </div>
                    <div>Sobota:</div>                  <div> e </div>
                    <div>Niedziela:</div>               <div> e </div>
                </div>
                
        </div>
     );
}
 
export default Offices;