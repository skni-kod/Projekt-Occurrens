import classes from "./IllnessView.module.css";

function IllnessView(showButtonEditIllness, showButtonDeleteIllness) {
    return(
        <div className= { classes.bcg }>
            <div className= { classes.maingrid }>
                <div className={ classes.info }>
                    <div className= { classes.label }>Informacje:</div>
                </div>
                <div className= { classes.description }>
                    <div className= { classes.label }>
                        Opis Choroby:
                    </div>
                </div>
                <div className= { classes.history}>
                    <div className= { classes.label }>
                        Historia Choroby:
                    </div>
                </div>
                <div className= { classes.meds }>
                    <div className= { classes.label }>
                        Leki:
                    </div>
                </div>
            </div>
        </div>
    )
    };
    
    export default IllnessView;