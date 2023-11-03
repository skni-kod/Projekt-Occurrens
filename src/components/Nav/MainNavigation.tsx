import { NavLink, Outlet } from "react-router-dom";

import classes from "./MainNavigation.module.scss";

const MainNavigation: React.FC = () => {
  return (
    <div>
      <nav className={classes.navigation}>
        <ul className={classes.navigation_list}>
          <li>
            <NavLink to="/" end>
              Strona Główna
            </NavLink>
          </li>
          <li>
            <NavLink to="/o-nas">O Nas</NavLink>
          </li>
          <li>
            <NavLink to="/lekarze">Nasi Lekarze</NavLink>
          </li>
          <li>
            <NavLink to="/logowanie">Logowanie</NavLink>
          </li>
        </ul>
      </nav>
      <Outlet />
    </div>
  );
};

export default MainNavigation;
