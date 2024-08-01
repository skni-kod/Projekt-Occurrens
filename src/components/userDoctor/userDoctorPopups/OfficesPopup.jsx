import React from "react";
import './OfficesPopup';
import closeButton from '../../../icons/icons8-close.svg';

function OfficessPopup(props){
    return(props.trigger) ? (
        <div className="popup">
            <div className="popup-inner">
                <button className="close-button" onClick={ () => props.setTrigger(false) }>
                    <button>
                        <img src= { closeButton } alt="closebutton" />
                    </button>
                </button>
                { props.children }
            </div>
        </div>
    ) : '';
}
export default OfficessPopup;