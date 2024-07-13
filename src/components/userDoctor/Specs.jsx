import styles from "./userDoctor.module.css";
import editPencil from  "../../icons/edit-3-svgrepo-com.svg";
const Specs = () => {
    return ( 
        <div className={`${styles.specs} ${styles.gridBox}`}><h2>Specjalizacje <button><img src={editPencil}/></button></h2>
        <div className={styles.specsList}>

        </div>
            
    </div>
     );
}
 
export default Specs;