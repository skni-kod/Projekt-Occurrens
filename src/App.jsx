import { RouterProvider, createBrowserRouter } from "react-router-dom";
import NotLoggedNav from "./components/userNotLoggedIn/navigation/NotLoggedNav";
import MainPage from "./components/userNotLoggedIn/mainPage/MainPage";
import AboutPage from "./components/userNotLoggedIn/aboutPage/AboutPage";
import ShowAllDoctorsPage from "./components/userNotLoggedIn/ShowAllDoctorsPage/ShowAllDoctorsPage";
import KindOfLoginPage from "./components/userNotLoggedIn/kindOfLoginPage/KindOfLoginPage";
import LoginPage from "./components/userNotLoggedIn/loginPage/LoginPage";
import RegisterPage from "./components/userNotLoggedIn/registerPage/RegisterPage";
import ForgotPasswordPage from "./components/userNotLoggedIn/forgotPasswordPage/ForgotPasswordPage";
import ResetPasswordPage from "./components/userNotLoggedIn/forgotPasswordPage/resetPasswordPage/ResetPasswordPage";

const router = createBrowserRouter([
  {
    path: "/",
    element: <NotLoggedNav />,
    id: "main",
    children: [
      { index: true, element: <MainPage /> },
      { path: "about", element: <AboutPage /> },
      { path: "doctors", element: <ShowAllDoctorsPage /> },
      { path: "login-role", element: <KindOfLoginPage /> },
      { path: "login", element: <LoginPage /> },
      { path: "register", element: <RegisterPage /> },
      { path: "login/forgot-password", element: <ForgotPasswordPage /> },
      { path: "reset-password", element: <ResetPasswordPage /> },
    ],
  },
]);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
