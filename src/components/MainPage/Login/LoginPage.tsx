import { Link, useLocation, useNavigate } from "react-router-dom";
import classes from "./LoginPage.module.scss";

import BackButton from "../../utility/BackButton";

const LoginPage: React.FC = () => {
  const location = useLocation();
  const currentPath = location.pathname;
  const navigate = useNavigate();

  const handleRegistrationLink = () => {
    if (currentPath === "/logowanie/lekarz") {
      navigate("/rejestracja/lekarz");
    } else if (currentPath === "/logowanie/pacjent") {
      navigate("/rejestracja/pacjent");
    }
  };

  return (
    <div className={classes.container1}>
      <BackButton navTo="/logowanie" />

      <div className={classes.box}>
        <div className={classes.form}>
          <h2>Zaloguj się</h2>

          <label className={classes.inputBox}>
            <input type="text" required />
            <span>PESEL</span>
            <i></i>
          </label>

          <label className={classes.inputBox}>
            <input type="password" required />
            <span>Hasło</span>
            <i></i>
          </label>

          <div className={classes.links}>
            <Link to="/odzyskiwanie" className={classes.links_l}>
              Zapomniałem hasła
            </Link>
            <button
              onClick={handleRegistrationLink}
              className={classes.links_l}
            >
              Zarejestruj się
            </button>
          </div>
          <input type="submit" value="Zaloguj" />
        </div>
      </div>
    </div>
  );
};

export default LoginPage;
