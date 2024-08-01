import styles from "./userDoctor.module.css";
import '../userDoctor/userDoctorPopups/UserDataPopup';
import deleteButton from "../../icons/icons8-delete.svg";


const Specs = () => {
    return ( 
        <div className={`${styles.specs} ${styles.gridBox}`}>
            <h2>
            Specjalizacje &nbsp;
            </h2>
        <div className={styles.specsList}>
            <div className="specName">[specjalizacja 1] <button className="bin"> <img src={ deleteButton } alt="deletebutton" /></button> </div>   
            <div className="specName">[specjalizacja 2] <button className="bin"> <img src={ deleteButton } alt="deletebutton" /></button> </div>   
            <div className="specName">[specjalizacja 3] <button className="bin"> <img src={ deleteButton } alt="deletebutton" /></button> </div>   
            <div className="specName">[specjalizacja 4] <button className="bin"> <img src={ deleteButton } alt="deletebutton" /></button> </div>   
            <div className="specName">[specjalizacja 5] <button className="bin"> <img src={ deleteButton } alt="deletebutton" /></button> </div>   
            <div className="specName">[specjalizacja 6] <button className="bin"> <img src={ deleteButton } alt="deletebutton" /></button> </div>   
            <div className="specName">[specjalizacja 7] <button className="bin"> <img src={ deleteButton } alt="deletebutton" /></button> </div>   
            <div className="specName">[specjalizacja 8] <button className="bin"> <img src={ deleteButton } alt="deletebutton" /></button> </div>   
            <div className="specName">[specjalizacja 9] <button className="bin"> <img src={ deleteButton } alt="deletebutton" /></button> </div>   
            <div className="specName">[specjalizacja 10] <button className="bin"> <img src={ deleteButton } alt="deletebutton" /></button> </div>  
        </div>
        <button className={styles.specAddButton}>Dodaj Specjalizacje</button>
            
    </div>
     );
}
 
export default Specs;