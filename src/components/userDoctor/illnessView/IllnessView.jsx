import classes from "./IllnessView.module.css";

function IllnessView(showButtonEditIllness, showButtonDeleteIllness) {
    return(
        <div className= { classes.background }>
            <div className= { classes.maingrid }>
                <div className={ classes.info }>
                    <div className= { classes.label }>
                        Informacje:
                    </div>
                    <div className= { classes.infodata }>
                        <div className= { classes.patientNameSurname }>
                            Imię i nazwisko pacjenta:
                        </div>
                        <div className= { classes.patientNameSurnameData }>
                            
                        </div>
                        <div className= { classes.doctorNameSurname }>
                            Imię i nazwisko lekarza:
                        </div>
                        <div className= { classes.doctorNameSurnameData }>
                            
                        </div>
                        <div className= { classes.illness }>
                            Choroba:
                        </div>
                        <div className= { classes.illnessData }>
                            
                        </div>
                        <div className= { classes.dateOfAddingTheIllness }>
                            Data dodania choroby:
                        </div>
                        <div className= { classes.dateOfAddingTheIllnessData }>
                            
                        </div>
                    </div>
                    
                </div>
                <div className= { classes.description }>
                    <div className= { classes.label }>
                        Opis Choroby:
                    </div>
                    <div className= { classes.illnessDesctription }>
                        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
                    </div>
                </div>
                <div className= { classes.history}>
                    <div className= { classes.label }>
                        Historia Choroby:
                    </div>
                    <div className= { classes.illnessHistory }>
                        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
                    </div>
                </div>
                <div className= { classes.meds }>
                    <div className= { classes.label }>
                        Leki:
                    </div>
                    <div className= { classes.medsData }>
                        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
                    </div>
                    <button className= { classes.editIllnessButton }>
                        Edytuj chorobę
                    </button>
                    <button className= { classes.deleteIllnessButton }>
                        Usuń chorobę
                    </button>
                </div>
            </div>
        </div>
    )
    };
    
    export default IllnessView;