import { useState } from "react";
import { useLocation, useNavigate } from "react-router-dom";
import classes from "./ForgotPasswordPage.module.css";

function LoginPage() {
  const navigate = useNavigate();

  const selectedRole = useLocation().state.role;
  console.log(selectedRole);

  const [recoverData, setRecoverData] = useState({
    email: "",
    role: selectedRole,
  });

  const [linkSendMsg, setLinkSendMsg] = useState(false);

  function updateRecoverData(event) {
    setRecoverData((prevLoginData) => {
      return {
        ...prevLoginData,
        email: event.target.value,
      };
    });
  }

  const submitRecoverData = (event) => {
    event.preventDefault();
    setLinkSendMsg(true);
    console.log(recoverData);
    // try {
    //   const response = await fetch(
    //     `http://localhost:5000/account/sing-in/${recoverData.role}`,
    //     {
    //       method: "POST",
    //       headers: { "Content-Type": "application/json" },
    //       body: JSON.stringify(recoverData),
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
        <h2 className={classes.title}>ODZYSKAJ KONTO</h2>
        <p className={classes.description}>
          Wprowadź adres e-mail, na który zostanie wysłany link aktywacyjny, aby
          zresetować hasło.
        </p>
        {linkSendMsg || (
          <form onSubmit={submitRecoverData} className={classes.form}>
            <input
              type="email"
              name="email"
              placeholder="Adres e-mail"
              value={recoverData.email}
              onChange={updateRecoverData}
              className={classes.input}
            />
            <div className={classes.buttons}>
              <button
                type="button"
                className={classes.cancelBtn}
                onClick={() =>
                  navigate("/login", { state: { role: recoverData.role } })
                }
              >
                Anuluj
              </button>
              <button type="submit" className={classes.sendBtn}>
                Wyślij link
              </button>
            </div>
          </form>
        )}
        {linkSendMsg && (
          <p className={classes.recoverMessage}>
            Sprawdź swój e-mail i kliknij w link aktywacyjny.
          </p>
        )}
      </div>
    </div>
  );
}

export default LoginPage;
