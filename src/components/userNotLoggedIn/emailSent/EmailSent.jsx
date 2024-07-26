import './EmailSent.css';

function EmailSent() {
  return <div className='background'>
      <ForgotPasswordFrame/>
  </div>;
}


function ForgotPasswordFrame(){
  return <div className='emailSentFrame'>
      <ForgotPasswordHeading/>
      <p style={{marginTop: '7%', width: '90%'}}>Na podany adres email wysłaliśmy mail z linkiem do resetu hasła  </p>      
  </div>
}
function ForgotPasswordHeading(){
  return <div className='emailSentHeading'>
      Reset hasła
  </div>
}
  export default EmailSent;
  