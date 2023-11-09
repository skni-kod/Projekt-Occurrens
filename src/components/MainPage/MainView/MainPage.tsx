import classes from "./MainPage.module.scss";
import StepsDecision from "./StepsDescription";

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

      <StepsDecision />
    </section>
  );
};

export default MainPage;
