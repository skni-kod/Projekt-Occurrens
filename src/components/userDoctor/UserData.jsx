import styles from "./userDoctor.module.css";
import editPencil from  "../../icons/edit-3-svgrepo-com.svg";
import UserDataPopup from "./userDoctorPopups/UserDataPopup";
import { useState } from "react";


const UserData = () => {
    const [userDataButtonPopup, setUserDataPopup] = useState(false);
    return ( 
        <div className={`${styles.userData} ${styles.gridBox}`}>
            <UserDataPopup trigger = { userDataButtonPopup } setTrigger = { setUserDataPopup }>
                        <form className="edit-user-form">
                            <div className="form-group">
                                <label>Imię:</label>
                                <input/>
                            </div>
                            <div className="form-group">
                                <label>Drugie Imie:</label>
                                <input/>
                            </div>
                            <div className="form-group">
                                <label>Nazwisko:</label>
                                <input/>
                            </div>
                            <div className="form-group">
                                <label>E-mail:</label>
                                <input/>
                            </div>
                            <div className="form-group">
                                <label>Data Urodzenia:(DD.MM.YYYY)</label>
                                <input/>
                            </div>
                        </form>
            </UserDataPopup>
            <h2>Dane użytkownika 
            <button onClick={ () => setUserDataPopup(true) }>
                <img src={editPencil} alt="edit button"/>
            </button>
            </h2>
                <div className={styles.profileData}>
                    <div>Imie:</div>                 <div> a </div>
                    <div>Drugie Imie:</div>          <div> b </div>
                    <div>Nazwisko:</div>             <div> c </div>
                    <div>E-mail:</div>               <div> d </div>
                    <div>Data urodzenia:</div>       <div> e </div>
                </div>
                <div>
                    
                </div>
        </div>
     );
}
 
export default UserData;