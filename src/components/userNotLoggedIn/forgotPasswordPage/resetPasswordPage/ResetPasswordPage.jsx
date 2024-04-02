import { useState } from "react";
import { useNavigate } from "react-router-dom";
import classes from "./ResetPasswordPage.module.css";

function LoginPage() {
  const navigate = useNavigate();

  const selectedRole = 1;
  console.log(selectedRole);

  const [resetPasswordData, setResetPasswordData] = useState({
    password: "",
    passwordConfirm: "",
    role: selectedRole,
  });

  function updateResetPasswordData(event) {
    const { name, value } = event.target;
    setResetPasswordData((prevLoginData) => {
      return {
        ...prevLoginData,
        [name]: value,
      };
    });
  }

  const submitResetPasswordData = async (event) => {
    event.preventDefault();
    console.log(resetPasswordData);
    navigate("/login", { state: { role: resetPasswordData.role } });
    // try {
    //   const response = await fetch(
    //     `http://localhost:5000/account/sing-in/${resetPasswordData.role}`,
    //     {
    //       method: "POST",
    //       headers: { "Content-Type": "application/json" },
    //       body: JSON.stringify(resetPasswordData),
    //     }
    //   );
    //   if (response.status === 400) {
    //     console.log("response: ", "ok");
    //   }
    //   const jsonResponse = await response.json();
    //   console.log("json: ", jsonResponse);
    // } catch (event) {
    //   console.log("błąd: ", event);
    // }
  };

  return (
    <div className={classes.background}>
      <div className={classes.container}>
        <h2 className={classes.title}>ZRESETUJ HASŁO</h2>
        <form onSubmit={submitResetPasswordData} className={classes.form}>
          {resetPasswordData.password && (
            <label className={classes.inputLabel}>Nowe hasło</label>
          )}
          <input
            type="password"
            name="password"
            placeholder="Nowe hasło"
            value={resetPasswordData.password}
            onChange={updateResetPasswordData}
            className={classes.input}
          />
          {resetPasswordData.passwordConfirm && (
            <label className={classes.inputLabel}>Powtórz nowe hasło</label>
          )}
          <input
            type="password"
            name="passwordConfirm"
            placeholder="Powtórz nowe hasło"
            value={resetPasswordData.passwordConfirm}
            onChange={updateResetPasswordData}
            className={classes.input}
          />
          <button className={classes.resetBtn}>Zresetuj hasło</button>
        </form>
      </div>
    </div>
  );
}

export default LoginPage;
