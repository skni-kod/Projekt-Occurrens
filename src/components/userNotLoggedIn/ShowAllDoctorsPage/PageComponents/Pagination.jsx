import classes from "./Pagination.module.css";

export default function Pagination() {
  return (
    <>
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
    </>
  );
}
