import classes from "./IllnessViewButtons.module.css";

function IllnessViewButtons({showButtons}){
    return(showButtons &&(
        <div className={ classes.buttons }>
            <button className= { classes.editIllnessButton }>
                        Edytuj chorobę
                    </button>
                    <button className= { classes.deleteIllnessButton }>
                        Usuń chorobę
                    </button>
        </div>
    ));
}

export default IllnessViewButtons;