import classes from "./RemindersCard.module.css";

function RemindersCard(props) {
    const {classNameProps, logo, description, method, buttonText} = props;

    return (
        <div className = {classes.card}>
            <img src={logo} className ={classes.logo}/>
            <p className={classes.information}>{description}</p>
            <button className = {[classes.button, classNameProps].join(' ')} onClick={method}><p className={classes.buttonTextStyle}>{buttonText}</p></button>
        </div>
    );
}

export default RemindersCard;