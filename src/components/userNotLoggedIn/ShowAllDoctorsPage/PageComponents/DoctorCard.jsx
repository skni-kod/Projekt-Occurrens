import classes from "./DoctorCard.module.css";

export default function DoctorCard() {
  return (
    <div className={classes.show}>
      <div className={classes["flip-card"]}>
        <div className={classes["flip-card-inner"]}>
          <div className={classes["flip-card-front"]}>
            <h1>Przód karty</h1>
          </div>
          <div class={classes["flip-card-back"]}>
            <h1>Tył karty</h1>
          </div>
        </div>
      </div>
    </div>
  );
}
