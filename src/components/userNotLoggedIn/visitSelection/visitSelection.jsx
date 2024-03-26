import React, { useState } from 'react';
import './visitSelection.css';
import Calendar from 'react-calendar';
import 'react-calendar/dist/Calendar.css';
import BasicDoctorImage from "../../../images/BasicDoctorImage.png";



function MyCalendar({minDate}) {
    const [date, setDate] = useState(new Date());

  const onChange = date => {
    setDate(date);
  }

  return (
    <div>
      
      <Calendar
        locale="pl-PL"
        onChange={onChange}
        value={date}
        minDate={minDate}
        
      />
    </div>
  );
}

function TextAreaComponent() {
  const [textAreaInput, setTextAreaInput] = useState('');

  const handleChange = (event) => {
    setTextAreaInput(event.target.value);
  };

  return (
    <div style={{display: 'flex', justifyContent: 'center', flexDirection: 'column', alignItems: 'center'}}>
      <label>
        <textarea  style={{borderRadius: '10px', resize: 'none', padding: '5px', fontSize: '16px'}}
          value={textAreaInput} 
          onChange={handleChange} 
          placeholder="Wpisz wiadomość..." 
          rows={7} 
          cols={70} 
        />
      </label>
      <AskForVisitButton/>

    </div>
  );
}



function FrameWithVisits({ setSelectedHour }){
  const generateHours = () => {
    const hours = [];
    for (let hour = 7; hour < 20; hour++) {
      for (let minute = 0; minute < 60; minute += 30) {
        hours.push(`${hour.toString().padStart(2, '0')}:${minute.toString().padStart(2, '0')}`);
      }
    }
    return hours;
  };

  // Lista godzin
  const hoursList = generateHours();

  return (
    <div className='visitSection'>
      {hoursList.map((hour, index) => (
        <Visit key={index} hour={hour} setSelectedHour={setSelectedHour}  />
      ))}
    </div>
  );
}

function Visits({ setSelectedHour, selectedHour }){

  console.log("Aktualna wartość selectedHour w Visits: ", selectedHour);

  return (
    <div className='visitsFrame'>
      <div  className='visitHeading'>Wizyty</div>
      <div style={{display: 'flex', alignItems: 'center', flexDirection: 'column', height: '100%'}}>
        <FrameWithVisits setSelectedHour={setSelectedHour} />
        <MessageToDoctor selectedHour={selectedHour}/>
      </div>
    </div>
  )
}

function Visit({ hour, setSelectedHour  }){
  const handleHourSelection = () => {
    console.log("dupa: ", hour)
    setSelectedHour(hour);
    
  };
  return<div className='visit'>
    Godzina:  {hour}
    <button className='choseHourButton' onClick={handleHourSelection}>
      Wybierz godzinę
    </button>
  </div>
}

function ChosenDoctor(){
  return(
    <div className='chosenDoctor'>
      <h1>Wybrany Doktor:</h1> 
      <div style={{display: 'flex', flexDirection: 'row', justifyContent: 'space-between'}}>
        <DoctorInfo/>
        <DoctorImage className='scaledImage'/>
      </div>
      
    </div>
  )
}

function DoctorInfo(){
  return(
    <div>
      <h2>Imię:</h2>
      <h2>Nazwisko:</h2>
    </div>
  )
}

function DoctorImage(){
  return(
    <img src={BasicDoctorImage}/>
  )
}

function CalendarAndChosenDoctor(){
  return(
    <div className='calendarAndChosenDoctor'>
        <MyCalendar className='react-calendar' 
              minDate={new Date()}
        />
        <ChosenDoctor/>
    </div>
  )
  }

  function AskForVisitButton(){
    return(
      <button className='askForVisitButton'>Wyślij</button>
    )
  }

  function MessageToDoctor({selectedHour}){

    console.log("Aktualna wartość selectedHour w MessageToDoctor:", selectedHour);


    return(
      <div className='wybranyDoktor'>
        <h1>Wybrana godzina: {selectedHour}</h1>
        Podaj wiadomość, którą chciałbyć dołączyć do zgłoszenia do lekarza (opis choroby, jak się czujesz, jakich leków potrzebujesz, preferencje odnośnie godziny itd.):
        <TextAreaComponent selectedHour={selectedHour}/>
      </div>
    )
  }




  function VisitSelection() {
    const [selectedHour, setSelectedHour] = useState(null);
    const [key, setKey] = useState(0);
  
    const handleHourSelection = (hour) => {
      setSelectedHour(hour);
      setKey(key + 1); // Zwiększ klucz, aby wymusić ponowne renderowanie komponentu
    };
  
    // Reszta kodu
  
    return (
      <div className='background' style={{display: "flex", justifyContent: "center", alignItems: "center"}}>
        <div className='mainframe'>
          <CalendarAndChosenDoctor/>
          <Visits key={key} setSelectedHour={setSelectedHour} selectedHour={selectedHour} />
        </div>
      </div>
    );
  }
  
  export default VisitSelection;
  