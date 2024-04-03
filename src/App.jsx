import { RouterProvider, createBrowserRouter } from "react-router-dom";
import NotLoggedNav from "./components/userNotLoggedIn/navigation/NotLoggedNav";
import MainPage from "./components/userNotLoggedIn/mainPage/MainPage";
import AboutPage from "./components/userNotLoggedIn/aboutPage/AboutPage";
import ShowAllDoctorsPage from "./components/userNotLoggedIn/ShowAllDoctorsPage/ShowAllDoctorsPage";
import KindOfLoginPage from "./components/userNotLoggedIn/kindOfLoginPage/KindOfLoginPage";
import DoctorNavigation from "./components/userDoctor/navigation/DoctorNavigation";
import StartingPage from "./components/userDoctor/startingPage/StartingPage";
import KindOfDoctorVisits from "./components/userDoctor/visits/DoctorVisits";

const router = createBrowserRouter([
  {
    path: "/",
    element: <NotLoggedNav />,
    id: "main",
    children: [
      { index: true, element: <MainPage /> },
      { path: "about", element: <AboutPage /> },
      { path: "doctors", element: <ShowAllDoctorsPage /> },
      { path: "login", element: <KindOfLoginPage /> }
    ],
  },
  {
    path: "/doctor",  
    element: <DoctorNavigation />,
    id: "doctor",
    children: [
      {index: true, element: <StartingPage />},
      {path: "profile", element: <KindOfDoctorVisits/>},
      {path: "visits", element: <KindOfDoctorVisits/>}
    ]
  }
]);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
