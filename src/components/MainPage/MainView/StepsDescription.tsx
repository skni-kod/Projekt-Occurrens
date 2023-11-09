import classes from "./StepsDescription.module.scss";

interface TypePatientData {
  step: string;
  description: string;
}

const patientSteps: TypePatientData[] = [
  {
    step: "Krok 1 :",
    description:
      "Utwórz swoje konto. Wypełnij krótki formularz rejestracyjny swoimi danymi osobowymi.",
  },
  {
    step: "Krok 2 :",
    description:
      "Zaloguj się na swoje konto wykorzystując E-mail i hasło podane podczas rejestracji",
  },
  {
    step: "Krok 3 :",
    description:
      "Znajdź lekarza do którego chcesz się umówić i wypełnij króti formularz.",
  },
  {
    step: "Krok 4 :",
    description:
      "Zaczekaj na decyzję lekarza który przydzieli ci termin wizyty.",
  },
];

interface TypeDoctorData {
  step: string;
  description: string;
}

const doctorSteps: TypeDoctorData[] = [
  {
    step: "Krok 1 :",
    description:
      "Utwórz swoje konto. Wypełnij krótki formularz rejestracyjny swoimi danymi osobowymi.",
  },
  {
    step: "Krok 2 :",
    description:
      "Zaloguj się na swoje konto wykorzystując E-mail i hasło podane podczas rejestracji",
  },
  {
    step: "Krok 3 :",
    description:
      "Wejdź w swój profil i ustaw adres swojego gabinetu oraz godziny w jakich przyjmujesz.",
  },
  {
    step: "Krok 4 :",
    description:
      "Ustalaj daty wizyt swoich pacjentów, sprawdzaj ich historię medyczną, dodawaj sprawozdania z wizyt.",
  },
];

const StepsDecision = () => {
  return (
    <section className={classes.description}>
      <span>
        <h1>Jak korzystać z naszej strony?</h1>
        <p className={classes.description_paragraph}>
          Jeżeli chcesz umówić się do lekarza, to powinieneś wykonać poniższe
          kroki:{" "}
        </p>
      </span>
      <div className={classes.description_steps}>
        {patientSteps.map((item) => (
          <div key={item.step}>
            <h3>{item.step}</h3>
            <p>{item.description}</p>
          </div>
        ))}{" "}
      </div>

      <p className={classes.description_paragraph}>
        Jesteś lekarzem i chcesz skorzystać z naszej strony? Oto co powinienieś
        zrobić:{" "}
      </p>

      <div className={classes.description_steps}>
        {doctorSteps.map((item) => (
          <div key={item.step}>
            <h3>{item.step}</h3>
            <p>{item.description}</p>
          </div>
        ))}{" "}
      </div>
    </section>
  );
};

export default StepsDecision;
