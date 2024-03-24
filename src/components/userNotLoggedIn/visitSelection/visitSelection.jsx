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
        <textarea  style={{borderRadius: '10px', resize: 'none'}}
          value={textAreaInput} 
          onChange={handleChange} 
          placeholder="Wpisz wiadomość..." 
          rows={7} 
          cols={70} 
        />
      </label>
      <p>Wprowadzona wiadomość: {textAreaInput}</p>
      <AskForVisitButton/>

    </div>
  );
}



function FrameWithVisits(){
  return(
      <div  className='visitSection'>
        <Visit></Visit>
        <Visit></Visit>
        <Visit></Visit>
        <Visit></Visit>
        <Visit></Visit>
        <Visit></Visit>
        <Visit></Visit>
        <Visit></Visit>
        <Visit></Visit>
        <Visit></Visit>
        <Visit></Visit>
        <Visit></Visit>


      </div>
  )
}

function Visits(){
  return (
    <div className='visitsFrame'>
      <div  className='visitHeading'>Wizyty</div>
      <div style={{display: 'flex', alignItems: 'center', flexDirection: 'column', height: '100%'}}>
        <FrameWithVisits></FrameWithVisits>
        <MessageToDoctor></MessageToDoctor>
      </div>
    </div>
  )
}

function Visit(){
  return<div className='visit'>
    ALECHUJ (jest giga wielki)
    <button className='wybierzGodzineButton'>
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

  function MessageToDoctor(){
    return(
      <div className='wybranyDoktor'>
        <h1>Wybrana godzina: </h1>
        Podaj wiadomość, którą chciałbyć dołączyć do zgłoszenia do lekarza (opis choroby, jak się czujesz, jakich leków potrzebujesz, preferencje odnośnie godziny itd.):
        <TextAreaComponent/>
      </div>
    )
  }




function VisitSelection() {
    return (
    <div className='background' style={{display: "flex", justifyContent: "center", alignItems: "center"}}>
      <div className='mainframe'>
        <CalendarAndChosenDoctor/>
        <Visits/>


      </div>
    </div>
    );
  }
  
  export default VisitSelection;
  