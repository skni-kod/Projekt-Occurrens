import './PasswordReset.css';

function EmailSent() {
  return <div className='background'>
      <ForgotPasswordFrame/>
  </div>;
}


function ForgotPasswordFrame(){
  return <div className='forgotPasswordFrame'>
      <ForgotPasswordHeading/>
      <NewPasswordFrame/>
  </div>
}
function ForgotPasswordHeading(){
  return <div className='forgotPasswordHeading'>
      Reset hasła
  </div>
}

function NewPasswordFrame(){
    return <div className='newPasswordFrame'>
        <p>Podaj nowe hasło</p>
        <PasswordInput placeholder="Podaj nowe hasło"/>
        <p>Powtórz hasło</p>
        <PasswordInput placeholder="Powtórz hasło" />
        <SendButton />
    </div>
}




  function PasswordInput({placeholder}){
    return(
        <input className='passwordInput'
                type="password" 
                placeholder={placeholder} 
            />
    );
  }

  function SendButton(){
    return(
      <button className='sendButton'>Wyślij</button>
    )
  }

  export default EmailSent;
  