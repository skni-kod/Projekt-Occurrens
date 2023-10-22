import { NavLink, Outlet } from "react-router-dom";

const MainNavigation: React.FC = () => {
  return (
    <>
      <nav>
        <ul>
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
    </>
  );
};

export default MainNavigation;
