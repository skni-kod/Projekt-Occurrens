import React from "react";
import { Link } from "react-router-dom";

import BackButton from "../../utility/BackButton";

import classes from "./KindOfLogin.module.scss";


const KindOfLogin: React.FC = () => {
  return (
    <div className={classes.container}>
      <h1 className={classes.container_loginHeader}>Wybierz opcję logowania</h1>

      <BackButton navTo="/" />

      <Link to="/logowanie/lekarz" className={`${classes.img} ${classes.img1}`}>
        <h2 className={classes.img1_text}>Jestem lekarzem!</h2>
      </Link>

      <Link
        to="/logowanie/pacjent"
        className={`${classes.img} ${classes.img2}`}
      >
        <h2 className={classes.img2_text}>Jestem pacjentem!</h2>
      </Link>
      <p className={classes.container__paragraph}>
        Jeżeli nie masz jeszcze konta to{" "}
        <Link to="/rejestracja" className={classes.container__paragraph_nav}>
          Kliknij tutaj!
        </Link>
      </p>
    </div>
  );
};

export default KindOfLogin;
