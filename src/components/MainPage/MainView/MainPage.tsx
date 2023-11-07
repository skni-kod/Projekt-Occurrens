

import classes from "./MainPage.module.scss";

const MainPage: React.FC = () => {

  return (
    <section className={classes.mainPage}>
      <section className={classes.mainPage_img}>
        <div className={classes.mainPage_text}>
          <h1>
            <u>Occurrens</u>
          </h1>
          <h2>Znudziło ci się czekanie w kolejkach do lekarza?</h2>
          <p>
            Nie musisz dłużej czekać! Dzięki naszej stronie możesz szybko i
            łatwo umówić się na swoją wizytę <b>całkowicie online!</b>
          </p>
        </div>
      </section>

      <section className={classes.description}>
        <span>
          <h1>
            Jak korzystać z naszej storny?
          </h1>
        </span>
        <div className={classes.description_steps}>
          <div>
            <h3>Krok 1 :</h3>
            <p>
              Utwórz swoje konto. Wybierz odpowiednią opcję w zależności czy
              jesteś lekarzem, czy chcesz się umówić na wizytę.
            </p>
          </div>
          <div>
            <h3>Krok 2 :</h3>
            <p>Zaloguj się na swoje konto wykorzystując dane z rejestracji.</p>
          </div>
          <div>
            <h3>Krok 3 :</h3>
            <p>
              Ciesz się z łatwego dostępu do opieki medycznej. Umawaj się na
              wizyty online! Kontroluj swoich pacjentów!
            </p>
          </div>
        </div>
      </section>
    </section>
  );
};

export default MainPage;
