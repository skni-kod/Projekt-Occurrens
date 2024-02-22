import { useLocation } from "react-router-dom";
import { useState } from "react";
import classes from "./RegisterPage.module.css";

function RegisterPage() {
  const roleChoice = useLocation().state.role;
  console.log(roleChoice);

  const [registerData, setRegisterData] = useState({
    role: roleChoice,
    pesel: "",
    firstName: "",
    secondName: "",
    lastName: "",
    phoneNumber: "",
    email: "",
    password: "",
    passwordConfirm: "",
    birthDate: "",
    acception: false,
  });

  function updateRegisterData(event) {
    const { name, value, type, checked } = event.target;
    setRegisterData((prevRegisterData) => {
      return {
        ...prevRegisterData,
        [name]: type === "checkbox" ? checked : value,
      };
    });
  }

  function submitRegisterData(event) {
    event.preventDefault();
    console.log(registerData);
  }

  return (
    <div className={classes.background}>
      <div className={classes.container}>
        <h2 className={classes.title}>REJESTRACJA</h2>
        <form onSubmit={submitRegisterData} className={classes.form}>
          {registerData.pesel && (
            <label className={classes.inputLabel}>Pesel</label>
          )}
          {registerData.role === 2 && (
            <input
              type="text"
              name="pesel"
              placeholder="Pesel"
              value={registerData.pesel}
              onChange={updateRegisterData}
              className={classes.input}
            />
          )}
          <div className={classes.twoInline}>
            <div className={classes.inputGroup}>
              {registerData.firstName && (
                <label className={classes.inputLabel}>Imię</label>
              )}
              <input
                type="text"
                name="firstName"
                placeholder="Imię"
                value={registerData.firstName}
                onChange={updateRegisterData}
                className={classes.input}
              />
            </div>
            <div className={classes.inputGroup}>
              {registerData.secondName && (
                <label className={classes.inputLabel}>Drugie imię</label>
              )}
              <input
                type="text"
                name="secondName"
                placeholder="Drugie imię"
                value={registerData.secondName}
                onChange={updateRegisterData}
                className={classes.input}
              />
            </div>
          </div>
          {registerData.lastName && (
            <label className={classes.inputLabel}>Nazwisko</label>
          )}
          <input
            type="text"
            name="lastName"
            placeholder="Nazwisko"
            value={registerData.lastName}
            onChange={updateRegisterData}
            className={classes.input}
          />
          <div className={classes.twoInline}>
            <div className={classes.inputGroup}>
              {registerData.phoneNumber && (
                <label className={classes.inputLabel}>Numer telefonu</label>
              )}
              <input
                type="text"
                name="phoneNumber"
                placeholder="Numer telefonu"
                value={registerData.phoneNumber}
                onChange={updateRegisterData}
                className={classes.input}
              />
            </div>
            <div className={classes.inputGroup}>
              {registerData.email && (
                <label className={classes.inputLabel}>Adres e-mail</label>
              )}
              <input
                type="email"
                name="email"
                placeholder="Adres e-mail"
                value={registerData.email}
                onChange={updateRegisterData}
                className={classes.input}
              />
            </div>
          </div>
          <div className={classes.twoInline}>
            <div className={classes.inputGroup}>
              {registerData.password && (
                <label className={classes.inputLabel}>Hasło</label>
              )}
              <input
                type="text"
                name="password"
                placeholder="Hasło"
                value={registerData.password}
                onChange={updateRegisterData}
                className={classes.input}
              />
            </div>
            <div className={classes.inputGroup}>
              {registerData.passwordConfirm && (
                <label className={classes.inputLabel}>Powtórz hasło</label>
              )}
              <input
                type="text"
                name="passwordConfirm"
                placeholder="Powtórz hasło"
                value={registerData.passwordConfirm}
                onChange={updateRegisterData}
                className={classes.input}
              />
            </div>
          </div>
          <label className={classes.inputLabel}>Data urodzenia</label>
          <input
            type="date"
            name="birthDate"
            value={registerData.birthDate}
            onChange={updateRegisterData}
            className={classes.input}
          />
          <label className={classes.acception}>
            <input
              type="checkbox"
              name="acception"
              value={registerData.acception}
              onChange={updateRegisterData}
              className={classes.acceptionInput}
            />
            Wyrażam zgodę na przetwarzanie danych
          </label>
          <button className={classes.registerBtn}>Zarejestruj się</button>
        </form>
      </div>
    </div>
  );
}

export default RegisterPage;
