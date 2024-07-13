import styles from "./userDoctor.module.css";
import editPencil from  "../../icons/edit-3-svgrepo-com.svg";

const Offices = () => {
    return ( 
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
     );
}
 
export default Offices;