import classes from "./RemindersCard.module.css";

function RemindersCard(props) {
    const {logo, description, } = props;

    return (
        <div className = {classes.card}>{props.children}</div>
    );
}

export default RemindersCard;