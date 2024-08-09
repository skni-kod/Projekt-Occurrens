import React from 'react';
import modules from './AppointmentPage.module.css';
import exit from '../../images/exit-svgrepo-com.svg';
import blankpfp from '../../images/Blank-profile.png';

function AppointmentPage() {
    let name = 'Marek Nowak';
    let date = '20 grudnia 2024';
    let time = '10:00';
    let patientNote ='blank';
    return (
        <div className={modules.background}>
            <div className={modules.window}>
                <div className={modules.upborder}>
                    <button className={modules.exitbutton}>
                        <img className={modules.exitsvg} src={exit} alt="return button" />
                    </button>
                    <div className={modules.appointmentTittle}>
                        <div>Wizyta</div>
                    </div>
                </div>
                <div className={modules.appointmentData}>
                    <div className={modules.namePhoto}>
                        <img className = { modules.pfp} src={ blankpfp } alt="blank profile picture" />
                        { name }
                    </div>
                    <div className={modules.date}>
                        <div>
                            DATA: { date }
                        </div>  
                        <div>
                            GODZINA: { time }
                        </div>
                    </div>
                    <div className={modules.patientMessage}>
                        <div>
                            WIADOMOŚĆ OD PACJENTA:
                        </div>
                        <div>
                            {patientNote}
                        </div>
                    </div>
                </div>
                <div className= { modules.diseases }>
                    <button>
                        <div>
                            choroba 1
                        </div>
                    </button>
                    <button>
                        <div>
                            choroba 2
                        </div>
                    </button>
                    <button>
                        <div>
                            choroba 3
                        </div>
                    </button>
                    <button>
                        <div>
                            choroba 4
                        </div>
                    </button>
                    <button>
                        <div>
                            choroba 5
                        </div>
                    </button>
                    <button>
                        <div>
                            choroba 6
                        </div>
                    </button>
                    <button>
                        <div>
                            choroba 7
                        </div>
                    </button>
                    <button>
                        <div>
                            choroba 8
                        </div>
                    </button>
                    <button>
                        <div className={modules.addDisease}>
                            dodaj chorobe
                        </div>
                    </button>
                </div>
            </div>
        </div>
    );
}

export default AppointmentPage;
