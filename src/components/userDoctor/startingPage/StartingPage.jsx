import classes from "./StartingPage.module.css";
import RemindersCard from "/home/mono/vsprojects/otherprojects/Projekt-Occurrens/src/components/userDoctor/assets/RemindersCard.jsx";
function StartingPage() {
    return (
      <>
        <div className={classes.background}>
          <div className={classes.header}>
            <div className={classes.presentationContent}>
              <div className={classes.description}>
                <p className={classes.information}>Witaj <br/>Tu zaczyna się Twoja podróż do <br/> efektywnej opieki  <br/> <span className={classes.blue}>pacjenta</span></p>
              </div>
              <img className={classes.doctor} src="https://i.imgur.com/ZvxPxuo.png" alt = "doctor"/>
            </div>
            <div className={classes.reminders}>
              <RemindersCard description = "Dzisiaj jest (data) (X) Pacjentów oczekuje na wizytę" buttonText = "Dzisiejsze wizyty"/>
              <RemindersCard description = "Masz X nowych wizyt do przydzielenia" buttonText = "Wizyty do przedzielenia"/>
            </div>
          </div>
          <br/>
        </div>
      </>
    )
}

export default StartingPage;