import { NavLink, Outlet } from "react-router-dom";
import classes from "./NotLoggedNav.module.css";

function NotLoggedNav() {
  return (
    <>
      <nav className={classes.navigation}>
        <div className={classes.image}>Occurrens</div>
        <div className={classes.links}>
          <ul className={classes.ul}>
            <li className={classes.li}>
              <NavLink
                to="/"
                className={({ isActive }) => (isActive ? classes.active : classes.notactive)}
              >
                Strona Główna
              </NavLink>
            </li>
            <li className={classes.li}>
              <NavLink
                to="about"
                className={({ isActive }) => (isActive ? classes.active : classes.notactive)}
              >
                O nas
              </NavLink>
            </li>
            <li className={classes.li}>
              <NavLink
                to="doctors"
                className={({ isActive }) => (isActive ? classes.active : classes.notactive)}
              >
                Nasi lekarze
              </NavLink>
            </li>
            <li className={classes.li}>
              <NavLink
                to="login"
                className={({ isActive }) => (isActive ? classes.active : classes.notactive)}
              >
                Zaloguj się
              </NavLink>
            </li>
          </ul>
        </div>
      </nav>
      <Outlet />
    </>
  );
}

export default NotLoggedNav;
