import './AfterVisit.css';
import doctorimage from './../../../../src/images/doctors.png';
import paypal from './../../../../src/images/paypal.png';
import visa from './../../../../src/images/visa.png';
import mastercad from './../../../../src/images/mastercard.png';
import americanexpress from './../../../../src/images/americane.png';

function AfterVisit() {
  return(
  <div className='background'>
    <MainFrame />
  </div>)
  }

function MainFrame(){
  return(
    <div className='mainframe'>
      <SummaryFrame />
      <DoctorNote />
    </div>
  )  
}

function DoctorNote(){
  return(
    <div className='doctornote'>
      <div className='headingnote'>Notatka od lekarza</div>
      <Note />
    </div>
  )
}

function Note({note}){
  return(
    <div className='note'>
      {note}
    </div>
  )
}

function SummaryFrame(){
  return(
    <div className='summaryframe'>
      <SummaryHeading />
      <SummaryAndImage />
    </div>
  )
}

function SummaryHeading(){
  return(
    <h1 className='summaryheading'>Dziękujemy za wizytę</h1>
  )
}

function SummaryAndImage(){
  return(
    <div className='summaryandimage'>
      <SummaryAndMedicines />
      <ImageContainer />
    </div>
    
  )
}

function SummaryAndMedicines(){
  return(
    <div className='summaryandmedicines'>
      <Summary />
      <Medicines />
    </div>
  )
}

function ImageContainer(){
  return(
    <div>
      <img className='photo' src = {doctorimage} />
    </div>
  )
}

function Summary(){
  return(
    <div className='summary'>
      <SmallHeading text={"Podsumowanie "} />
      <VisitDetails text={"Data Wizyty "}/>
      <VisitDetails text={"Imie i Nazwisko Lekarza "} />
      <VisitDetails text={"Choroba "} />
      <VisitDetails text={"Do zapłaty "} /> 
      <Payment />
    </div>
  )
}

function Medicines(){
  return(
    <div className='medicnes'>
      <SmallHeading text={"Leki"} />
      <MedicinesFieldAndSlider/>
    </div>
  )
}

function SmallHeading({text}){
  return(
    <div className='smallheading'>
      {text}
    </div>
  )
}

function MedicinesFieldAndSlider({info}){
  return(
    <div className='medicinesfieldandslider'>
      <MedicinesField text={info} />
    </div>
  )
}

function MedicinesField({text}){
  return(
    <div className='medicinesfield'>
      {text}
    </div>
  )
}

function VisitDetails({text, information}){
  return(
    <div className='visitdetails'>
      <TextDetails detail = {text} />
      <VisitInfo info={information}/>
    </div>
  )
}

function TextDetails({detail}){
  return(
    <div className='detail'>
      {detail}
    </div>
  )
}
function VisitInfo({info}){
  return(
    <div className='visitinfo'>
      {info}
    </div>
  )
}

function Payment(){
  return(
    <div className='payment'>
      <img className='paymentphoto' src = {paypal} />
      <img className='paymentphoto' src = {visa} />
      <img className='paymentphoto' src = {mastercad} />
      <img className='paymentphoto' src = {americanexpress} />
      <PaymentButton />
    </div>
  )
}

function PaymentButton(){
  return(
    <button className='paymentbutton'> Przejdź do płatności </button>
  )
}

  
export default AfterVisit;
  