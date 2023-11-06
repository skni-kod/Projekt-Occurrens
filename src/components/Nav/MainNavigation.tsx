import { NavLink, Outlet } from "react-router-dom";

import classes from "./MainNavigation.module.scss";

const MainNavigation: React.FC = () => {
  return (
    <div>
      <nav className={classes.navigation}>
        <ul className={classes.navigation_list}>
          <li>
            <NavLink
              to="/"
              end
              className={({ isActive }) =>
                isActive ? classes.active : classes.notactive
              }
            >
              Strona Główna
            </NavLink>
          </li>
          <li>
            <NavLink
              to="/o-nas"
              className={({ isActive }) =>
                isActive ? classes.active : classes.notactive
              }
            >
              O Nas
            </NavLink>
          </li>
          <li>
            <NavLink
              to="/lekarze"
              className={({ isActive }) =>
                isActive ? classes.active : classes.notactive
              }
            >
              Nasi Lekarze
            </NavLink>
          </li>
          <li>
            <NavLink
              to="/logowanie"
              className={({ isActive }) =>
                isActive ? classes.active : classes.notactive
              }
            >
              Logowanie
            </NavLink>
          </li>
        </ul>
      </nav>
      <Outlet />
    </div>
  );
};

export default MainNavigation;
