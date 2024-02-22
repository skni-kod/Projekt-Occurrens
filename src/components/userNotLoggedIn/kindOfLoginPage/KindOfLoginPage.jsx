import classes from "./KindOfLoginPage.module.css";

function KindOfLoginPage() {
  return (
    <div className={classes.background}>
      <div className={classes.container}>
        <div className={`${classes.card} ${classes.doctor}`}>
          <div className={classes.textContainer}>
            <h3 className={classes.loginText}>
              Zaloguj się jako
              <span className={classes.loginRole}>lekarz</span>
            </h3>
            <button className={classes.loginBtn}>Zaloguj się</button>
          </div>
        </div>
        <p className={classes.registerText}>
          Nie masz konta? Zarejestruj się jako lekarz
          <span className={classes.registerLink}>klikając tutaj</span>
        </p>
        <div className={classes.cardBackground}></div>
      </div>
      <div className={classes.container}>
        <div className={`${classes.card} ${classes.patient}`}>
          <div className={classes.textContainer}>
            <h3 className={classes.loginText}>
              Zaloguj się jako
              <span className={classes.loginRole}>pacjent</span>
            </h3>
            <button className={classes.loginBtn}>Zaloguj się</button>
          </div>
        </div>
        <p className={classes.registerText}>
          Nie masz konta? Zarejestruj się jako pacjent
          <span className={classes.registerLink}>klikając tutaj</span>
        </p>
        <div className={classes.cardBackground}></div>
      </div>
    </div>
  );
}

export default KindOfLoginPage;
