import classes from "./StartingPage.module.css";
import RemindersCard from "/home/mono/vsprojects/otherprojects/Projekt-Occurrens/src/components/userDoctor/assets/RemindersCard.jsx";

let day = new Date().toLocaleString("pl-PL", {day : 'numeric'})
let month = new Date().toLocaleString("pl-PL", {month : 'long'})
let year = new Date().getFullYear()

const separator = ' '

let dateString = day + separator + month + separator + year


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
              <RemindersCard logo = "https://i.imgur.com/QJtQdLL.png" 
              description = {<div>Dzisiaj jest <br></br> {dateString} <br></br><br></br> 5 pacjentów oczekuje na wizytę </div>} 
              buttonText = "Dzisiejsze wizyty"/>
              <RemindersCard logo = "https://i.imgur.com/MXql48L.png" description = "Masz X nowych wizyt do przydzielenia" buttonText = "Wizyty do przedzielenia"/>
            </div>
          </div>
          <br/>
        </div>
      </>
    )
}

export default StartingPage;