import { ReactSVG } from "react-svg";
import magnifying from "../../../../images/magnifying.svg";

import classes from "./FindDoctor.module.css"

export default function FindDoctor()
{
    return(
        <div className={classes.finding}>
          <ReactSVG src={magnifying} className={classes.svg} />

          <input
            className={classes.input}
            placeholder="Wyszukaj..."
            type="text"
          />

          <button className={classes.button}>Szukaj</button>
        </div>
    );
}