import React, { useState } from "react";
import classes from "./IllnessView.module.css";
import IllnessViewButtons from "./IllnessViewButtons";

function IllnessView({ showButtons }) {
    showButtons = false;
    return (
        <div className={classes.background}>
            <div className={classes.maingrid}>
                <div className={classes.info}>
                    <div className={classes.label}>Informacje:</div>
                    <div className={classes.infodata}>
                        <div className={classes.patientNameSurname}>
                            Imię i nazwisko pacjenta:
                        </div>
                        <div className={classes.patientNameSurnameData}></div>
                        <div className={classes.doctorNameSurname}>
                            Imię i nazwisko lekarza:
                        </div>
                        <div className={classes.doctorNameSurnameData}></div>
                        <div className={classes.illness}>Choroba:</div>
                        <div className={classes.illnessData}></div>
                        <div className={classes.dateOfAddingTheIllness}>
                            Data dodania choroby:
                        </div>
                        <div className={classes.dateOfAddingTheIllnessData}></div>
                    </div>
                </div>
                <div className={classes.description}>
                    <div className={classes.label}>Opis Choroby:</div>
                    <div className={classes.illnessDesctription}>
                        {/* Zawartość */}
                    </div>
                </div>
                <div className={classes.history}>
                    <div className={classes.label}>Historia Choroby:</div>
                    <div className={classes.illnessHistory}>
                        {/* Zawartość */}
                    </div>
                </div>
                <div className={classes.meds}>
                    <div className={classes.label}>Leki:</div>
                    <div
                        className={`${classes.medsData} ${
                            !showButtons ? classes.expanded : ""
                        }`}
                    >
                        {/* Zawartość */}
                    </div>

                    {/* Przekazujemy showButtons do komponentu IllnessViewButtons */}
                    <IllnessViewButtons showButtons={showButtons} />
                </div>
            </div>
        </div>
    );
}

export default IllnessView;
