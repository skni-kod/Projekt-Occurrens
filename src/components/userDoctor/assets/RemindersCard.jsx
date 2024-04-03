import classes from "./RemindersCard.module.css";

export default function RemindersCard(props) {
    return (
        <div className = {classes.card}>{props.children}</div>
    );
}
