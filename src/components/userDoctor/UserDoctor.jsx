import styles from "./userDoctor.module.css";
import editPencil from  "../../icons/edit-3-svgrepo-com.svg";

function UserDoctor() {
    
    
    
    return (
    <div className={styles.site}>
        <div className={styles.transparent}>
            <h1>Twój profil</h1>
                <div className={styles.doctorProfile}>
                    <div className={`${styles.userData} ${styles.gridBox}`}><h2>Dane użytkownika <button><img src={editPencil}/></button></h2>
                        
                            <div className={styles.profileData}>
                                <div>Imie:</div>                 <div>a  </div>
                                <div>Drugie Imie:</div>        <div> b </div>
                                <div>Nazwisko:</div>            <div> c </div>
                                <div>E-mail:</div>            <div> d </div>
                                <div>Data urodzenia:</div>            <div> e </div>
                            </div>
                            <div>
                                
                            </div>
                    </div>
                    <div className={`${styles.specs} ${styles.gridBox}`}><h2>Specjalizacje <button><img src={editPencil}/></button></h2>
                        <div className={styles.specsList}>

                        </div>
                            
                    </div>
                    <div className={`${styles.offices} ${styles.gridBox}`}><h2>Gabinety <button><img src={editPencil}/></button></h2>
                    <div className={styles.officesData}>
                                <div>Miasto:</div>                   <div> a </div>
                                <div>Ulica:</div>                    <div> b </div>
                                <div>Numer budynku:</div>            <div> c </div>
                                <div>Numer lokalu:</div>             <div> d </div>
                                <div>Kod pocztowy:</div>             <div> e </div>
                                <h4 className={styles.open}>
                                Godziny otwarcia:</h4>              <div>  </div>
                                <div>Poniedziałek:</div>            <div> e </div>
                                <div>Wtorek:</div>                  <div> e </div>
                                <div>Środa:</div>                   <div> e </div>
                                <div>Czwartek:</div>                <div> e </div>
                                <div>Piątek:</div>                  <div> e </div>
                                <div>Sobota:</div>                  <div> e </div>
                                <div>Niedziela:</div>               <div> e </div>
                            </div>
                            
                    </div>
                </div>
        </div>
    </div>
);
  };
  
  export default UserDoctor;