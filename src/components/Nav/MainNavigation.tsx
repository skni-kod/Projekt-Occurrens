import { NavLink, Outlet } from "react-router-dom";
import { motion } from "framer-motion"; // Import Framer Motion
import classes from "./MainNavigation.module.scss";

const MainNavigation: React.FC = () => {
  return (
    <>
      <motion.div // Użyj motion.div zamiast zwykłego div
        initial={{ y: -100 }} // Rozpocznij animację przesunięcia menu o -100px w górę
        animate={{ y: 0 }} // Zakończ animację przesunięcia w pozycji 0
        transition={{ duration: 0.5 }} // Określenie czasu trwania animacji
        style={{
          position: "fixed", // Przypnij menu do górnej krawędzi ekranu
          top: 0,
          left: 0,
          right: 0,
          zIndex: 999, // Ustaw z-index, aby menu było na wierzchu
        }}
      >
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
      </motion.div>
      <Outlet />
    </>
  );
};

export default MainNavigation;
