import classes from "./DoctorCard.module.css";

export default function DoctorCard() {
  return (
    <div className={classes.show}>
      <div className={classes["flip-card"]}>
        <div className={classes.personalInfo}>
          <h1>Jakub Jucha</h1>
          <h2>Ginekolog</h2>
          <h3>Tel: 123456789</h3>
        </div>

        <div className={classes.openInfo}>
          <div className={classes.addressInfo}>
            <p>Ulica:</p>
            <p>Numer domu:</p>
            <p>Numer lokalu:</p>
            <p>Kod pocztowy:</p>
            <p>Miasto:</p>
          </div>

          <div className={classes.daysInfo}>
            <p>Poniedziałek:</p>
            <p>Wtorek:</p>
            <p>Środa:</p>
            <p>Czwartek:</p>
            <p>Piątek:</p>
            <p>Sobota:</p>
            <p>Niedziela:</p>
          </div>
        </div>
      </div>
    </div>
  );
}
