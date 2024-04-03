import { NavLink, Outlet } from "react-router-dom";
import classes from "./DoctorNavigation.module.css";

function DoctorNavigation() {
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
                to="profile"
                className={({ isActive }) => (isActive ? classes.active : classes.notactive)}
              >
                Profil
              </NavLink>
            </li>
            <li className={classes.li}>
              <NavLink
                to="visits"
                className={({ isActive }) => (isActive ? classes.active : classes.notactive)}
              >
                Wizyty
              </NavLink>
            </li>
            <li className={classes.li}>
              <NavLink
                to="login"
                className={({ isActive }) => (isActive ? classes.active : classes.notactive)}
              >
                Wyloguj się
              </NavLink>
            </li>
          </ul>
        </div>
      </nav>
      <Outlet />
    </>
  );
}

export default DoctorNavigation;
