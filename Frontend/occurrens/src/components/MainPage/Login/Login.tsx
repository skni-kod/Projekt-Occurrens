import React from "react";

import classes from "./Login.module.scss";
import { NavLink } from "react-router-dom";

const Login: React.FC = () => {
  return (
    <div className={classes.container}>
      <NavLink
        to="/logowanie/lekarz"
        className={`${classes.img} ${classes.img1}`}
      ></NavLink>

      <NavLink
        to="/logowanie/pacjent"
        className={`${classes.img} ${classes.img2}`}
      ></NavLink>
    </div>
  );
};

export default Login;
