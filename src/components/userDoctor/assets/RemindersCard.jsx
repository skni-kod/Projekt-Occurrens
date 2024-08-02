import classes from "./RemindersCard.module.css";

function RemindersCard(props) {
    const {classNameProps, logo, description, onClick, buttonText} = props;

    return (
        <div className = {classes.card}>
            <img src={logo} className ={classes.logo}/>
            <div className={classes.components}>
                <p className={classes.information}>{description}</p>
                <button className = {[classes.button, classNameProps].join(' ')} onClick={onClick}><p className={classes.buttonTextStyle}>{buttonText}</p></button>
            </div>
        </div>
    );
}

export default RemindersCard;