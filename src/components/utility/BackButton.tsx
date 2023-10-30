import { Link } from "react-router-dom";

import classes from "./BackButton.module.scss"

interface BackButtonProps {
    navTo: string
}

const BackButton: React.FC<BackButtonProps> = (props) => {
  return (
    <Link to={props.navTo} className={classes.backButton}>
      <span className={classes.backButton__Arrow}>&larr;</span>
    </Link>
  );
};

export default BackButton;