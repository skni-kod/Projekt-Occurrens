import { RouterProvider, createBrowserRouter } from "react-router-dom";
import NotLoggedNav from "./components/userNotLoggedIn/navigation/NotLoggedNav";
import MainPage from "./components/userNotLoggedIn/mainPage/MainPage";
import AboutPage from "./components/userNotLoggedIn/aboutPage/AboutPage";
import ShowAllDoctorsPage from "./components/userNotLoggedIn/ShowAllDoctorsPage/ShowAllDoctorsPage";
import KindOfLoginPage from "./components/userNotLoggedIn/kindOfLoginPage/KindOfLoginPage";
import ForgotPassowrd from "./components/userNotLoggedIn/ForgotPassword/ForgotPassword";
import EmailSent from "./components/userNotLoggedIn/emailSent/EmailSent";
import PasswordReset from "./components/userNotLoggedIn/passwordReset/PasswordReset";

const router = createBrowserRouter([
  {
    path: "/",
    element: <NotLoggedNav />,
    id: "main",
    children: [
      { index: true, element: <MainPage /> },
      { path: "forgotPassword", element: <ForgotPassowrd /> },
      { path: "doctors", element: <ShowAllDoctorsPage /> },
      { path: "login", element: <KindOfLoginPage /> },
      { path: "forgotPassword/emailSent", element: <EmailSent />}
    ],
  },
]);

function App() {
  return <RouterProvider router={router} />;
}

export default App;


//notLoggedin Nav zmienione about na forgotPassword