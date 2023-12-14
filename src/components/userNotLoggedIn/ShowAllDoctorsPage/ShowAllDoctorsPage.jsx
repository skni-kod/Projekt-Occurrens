import { ReactSVG } from "react-svg";
import magnifying from "../../../images/magnifying.svg";

import classes from "./ShowAllDoctorsPage.module.css";

function ShowAllDoctorsPage() {
  return (
    <div className={classes.background}>
      <div className={classes.container}>
        <div className={classes.finding}>
          <ReactSVG src={magnifying} className={classes.svg} />

          <input
            className={classes.input}
            placeholder="Wyszukaj..."
            type="text"
          />

          <button className={classes.button}>Szukaj</button>
        </div>

        <div className={classes.show}></div>

        <div className={classes.radios}>
          <div className={classes.radio1}>siema</div>
          <div className={classes.radio2}>
            <p className={classes.p1}>Ilu Lekarzy chcesz wyświetlić?</p>
            <label className={classes.label}>
              <input
                className={classes.input2}
                type="radio"
                id="option1"
                name="options"
                value="10"
                checked
              />
              <span className={classes.span}>10</span>
            </label>
            <label className={classes.label}>
              <input
                className={classes.input2}
                type="radio"
                id="option2"
                name="options"
                value="20"
                checked
              />
              <span className={classes.span}>20</span>
            </label>
            <label className={classes.label}>
              <input
                className={classes.input2}
                type="radio"
                id="option3"
                name="options"
                value="30"
                checked
              />
              <span className={classes.span}>30</span>
            </label>
          </div>
        </div>
      </div>
    </div>
  );
}

export default ShowAllDoctorsPage;
