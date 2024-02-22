import { useState } from "react";
import { useLocation } from "react-router-dom";
import classes from "./LoginPage.module.css";

function LoginPage() {
  const selectedRole = useLocation().state.role;
  console.log(selectedRole);

  const [loginData, setLoginData] = useState({
    email: "",
    password: "",
    remember: false,
    role: selectedRole,
  });

  function updateLoginData(event) {
    const { name, value, type, checked } = event.target;
    setLoginData((prevLoginData) => {
      return {
        ...prevLoginData,
        [name]: type === "checkbox" ? checked : value,
      };
    });
  }

  function submitLoginData(event) {
    event.preventDefault();
    console.log(loginData);
  }

  return (
    <div className={classes.background}>
      <div className={classes.container}>
        <h2 className={classes.title}>ZALOGUJ SIĘ</h2>
        <form onSubmit={submitLoginData} className={classes.form}>
          {loginData.email && (
            <label className={classes.inputLabel}>Adres e-mail</label>
          )}
          <input
            type="email"
            name="email"
            placeholder="Adres e-mail"
            value={loginData.email}
            onChange={updateLoginData}
            className={classes.input}
          />
          {loginData.password && (
            <label className={classes.inputLabel}>Hasło</label>
          )}
          <input
            type="text"
            name="password"
            placeholder="Hasło"
            value={loginData.password}
            onChange={updateLoginData}
            className={classes.input}
          />
          <span className={classes.forgot}>Zapomniałeś hasła?</span>
          <label className={classes.remember}>
            <input
              type="checkbox"
              name="remember"
              checked={loginData.remember}
              onChange={updateLoginData}
              className={classes.rememberInput}
            />
            Zapamiętaj mnie
          </label>
          <button className={classes.loginBtn}>Zaloguj się</button>
        </form>
      </div>
      <p className={classes.registerText}>
        Nie masz konta? Zarejestruj się
        <span className={classes.registerLink}>klikając tutaj</span>
      </p>
    </div>
  );
}

export default LoginPage;
