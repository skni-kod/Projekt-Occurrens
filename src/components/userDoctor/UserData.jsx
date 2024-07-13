import styles from "./userDoctor.module.css";
import editPencil from  "../../icons/edit-3-svgrepo-com.svg";

const UserData = () => {
    return ( 
        <div className={`${styles.userData} ${styles.gridBox}`}><h2>Dane użytkownika <button><img src={editPencil}/></button></h2>
            
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