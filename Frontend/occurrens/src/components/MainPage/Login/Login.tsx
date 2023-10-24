import React from "react";

import classes from "./Login.module.scss";
import { NavLink } from "react-router-dom";

const Login: React.FC = () => {
  return (
    <div className={classes.container}>
      <h1 className={classes.container_loginHeader}>Wybierz opcję logowania</h1>

      <NavLink to="/" className={classes.backButton}>
        <span className={classes.backButton__Arrow}>&larr;</span>
      </NavLink>

      <NavLink
        to="/logowanie/lekarz"
        className={`${classes.img} ${classes.img1}`}
      ><h2 className={classes.img1_text}>Jestem lekarzem!</h2></NavLink>

      <NavLink
        to="/logowanie/pacjent"
        className={`${classes.img} ${classes.img2}`}
      >
        <h2 className={classes.img2_text}>Jestem pacjentem!</h2>
      </NavLink>
      <p className={classes.container__paragraph}>
        Jeżeli nie masz jeszcze konta to{" "}
        <NavLink to="/rejestracja" className={classes.container__paragraph_nav}>Kliknij tutaj!</NavLink>
      </p>
    </div>
  );
};

export default Login;
