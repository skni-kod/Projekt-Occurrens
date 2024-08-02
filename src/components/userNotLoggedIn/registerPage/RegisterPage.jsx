import { useLocation } from "react-router-dom";
import { useState } from "react";
import classes from "./RegisterPage.module.css";
import { register } from "../api/RegistrationAPI";

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
register(registerData)

    event.preventDefault();
    console.log(registerData);
  }

  return (
    <div className={classes.background}>
      <div className={classes.container}>
        <h2 className={classes.title}>REJESTRACJA</h2>
        <form onSubmit={submitRegisterData} className={classes.form}>
          {registrationData.role === 2 &&
          (
            <div className={classes.inputGroup}>
              <label className={classes.inputLabel}>Pesel</label>
              <input
                type="text"
                name="pesel"
                placeholder="Pesel"
                value={registrationData.pesel}
                onChange={updateRegisterData}
                className={classes.input}
              />
            </div>
          )}
          <div className={classes.twoInline}>
            <div className={classes.inputGroup}>  
              <label className={classes.inputLabel}>Imię</label>              
              <input
                type="text"
                name="firstName"
                placeholder="Imię"
                value={registrationData.firstName}
                onChange={updateRegisterData}
                className={classes.input}
                required
              />
            </div>
            <div className={classes.inputGroup}>
              <label className={classes.inputLabel}>Drugie imię</label>
              <input
                type="text"
                name="secondName"
                placeholder="Drugie imię"
                value={registrationData.secondName}
                onChange={updateRegisterData}
                className={classes.input}
              />
            </div>
          </div>
            <label className={classes.inputLabel}>Nazwisko</label>
          <input
            type="text"
            name="lastName"
            placeholder="Nazwisko"
            value={registrationData.lastName}
            onChange={updateRegisterData}
            className={classes.input}
            required
          />
          <div className={classes.twoInline}>
            <div className={classes.inputGroup}>
                <label className={classes.inputLabel}>Numer telefonu</label>
              <input
                type="tel"
                inputmode = "numeric"
                name="phoneNumber"
                placeholder="Numer telefonu"
                pattern="[0-9]{9}"
                value={registrationData.phoneNumber}
                onChange={updateRegisterData}
                className={classes.input}
                required
              />
            </div>
            <div className={classes.inputGroup}>
                <label className={classes.inputLabel}>Adres e-mail</label>
              <input
                type="email"
                name="email"
                placeholder="Adres e-mail"
                value={registrationData.email}
                onChange={updateRegisterData}
                className={classes.input}
                required
              />
            </div>
          </div>
          <div className={classes.twoInline}>
            <div className={classes.inputGroup}>
              <label className={classes.inputLabel}>Hasło</label>
              <input
                type="text"
                name="password"
                placeholder="Hasło"
                value={registrationData.password}
                onChange={updateRegisterData}
                className={classes.input}
                required
              />
            </div>
            <div className={classes.inputGroup}>
              <label className={classes.inputLabel}>Powtórz hasło</label>
              <input
                type="text"
                name="passwordConfirm"
                placeholder="Powtórz hasło"
                value={registrationData.passwordConfirm}
                onChange={updateRegisterData}
                className={classes.input}
                required
              />
            </div>
          </div>
          <label className={classes.inputLabel}>Data urodzenia</label>
          <input
            type="date"
            name="birthDate"
            value={registrationData.birthDate}
            onChange={updateRegisterData}
            className={classes.input}
            required
          />
          <label className={classes.acception}>
            <input
              type="checkbox"
              name="acception"
              value={registrationData.acception}
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
