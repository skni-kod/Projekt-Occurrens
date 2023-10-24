import { RouterProvider, createBrowserRouter } from "react-router-dom";
import MainNavigation from "./components/Nav/MainNavigation";
import MainPage from "./components/MainPage/MainPage";
import About from "./components/MainPage/About";

import "./index.scss";
import FindDoctor from "./components/MainPage/FindDoctor";
import Login from "./components/MainPage/Login/Login";

const router = createBrowserRouter([
  {
    path: "/",
    element: <MainNavigation />,
    id: "root",
    children: [
      { index: true, element: <MainPage /> },
      { path: "o-nas", element: <About /> },
      { path: "lekarze", element: <FindDoctor /> },
    ],
  },
  { path: "logowanie", element: <Login /> },
]);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
