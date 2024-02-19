import './about.css';
import { Link } from 'react-router-dom';

const tekst = "Projekt Occurrens to projekt studenckiego koła naukowego SKNI KOD Politechniki Rzeszowskiej. Naszym celem jest zaprzyjaźnienie się z obecnie stosowanymi technologiami, a przy tym zrobienie czegoś wyjątkowego, co może pomóc każemu z nas.";
const tekst2 = "Tym właśnie jest Projekt Occurrens. Z naszych pasji zrodziła się platforma, która ma w swych założeniach znacząco ułatwić komunikację na drodze lekarz - pacjent";
const tekst3 = "Aplikacja jest ciągle rozwijana, pragniemy wprowadzić wiele udogodnień zarówno dla pacjentów jak i dla lekrzy. Począwszy od wygodnej możliwości umówienia i odwołania wizyty, po indywidualną historię wizyt, aż po możliwość chatu na żywo z wykwalifikowanymi lekarzami."
const tekst4 = "Jeżeli chcesz skorzytać z wszystkich dostępnych możliwości i tych, które są ciągle rozwijane, gorąco zachęcamy do zalogowania lub założenia darmowego konata, poprzez wciśnięcie poniższego przycisku. Pozdrawiamy Zespół Occurrens :)"

function AboutContent() {
  return (
    <div className='mainContainer'>
      <br></br>
      <p className='mainTitle'>O Projekcie Occurrens</p>
      <br></br><br></br>
      <p className='mainText'>{tekst}</p>
      <br></br>
      <p className='mainText'>{tekst2}</p>
      <br></br>
      <p className='mainText'>{tekst3}</p>
      <br></br>
      <p className='mainText'>{tekst4}</p>
      <br></br>
      <Link to="/login" className='buttonLogin'>
        Zaloguj się
      </Link>
      <br></br><br></br>

    </div>
  );
}


function AboutPage() {

  return (    
  <div className='background'>
    <br></br>
    <br></br>
    <br></br><br></br><br></br><br></br>
    <AboutContent />
  </div>
  );
}

export default AboutPage;
