import { RouterProvider, createBrowserRouter } from "react-router-dom";
import MainNavigation from "./components/Nav/MainNavigation";
import MainPage from "./components/MainPage/MainView/MainPage";
import About from "./components/MainPage/About";

import "./index.scss";
import FindDoctor from "./components/MainPage/DisplayDoctors/FindDoctor";
import KindOfLogin from "./components/MainPage/Login/KindOfLogin";
import LoginPage from "./components/MainPage/Login/LoginPage";

const router = createBrowserRouter([
  {
    path: "/",
    element: <MainNavigation />,
    id: "root",
    children: [
      { index: true, element: <MainPage /> },
      { path: "/o-nas", element: <About /> },
      { path: "/lekarze", element: <FindDoctor /> },
    ],
  },
  {
    path: "/logowanie",
    element: <KindOfLogin />,
  },
  {
    path: "/logowanie/lekarz",
    element: <LoginPage />,
  },
  {
    path: "/logowanie/pacjent",
    element: <LoginPage />,
  },
]);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
