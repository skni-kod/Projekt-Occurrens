import './ForgotPassword.css';
import React, { useState } from 'react';

function AboutPage() {
    return <div className='background'>
        <ForgotPasswordFrame/>
    
        
    </div>;
  }

  function ForgotPasswordFrame(){
    return <div className='forgotPasswordFrame'>
        <ForgotPasswordHeading/>
        <EmailFrame/>        
    </div>
  }
  function ForgotPasswordHeading(){
    return <div className='forgotPasswordHeading'>
        Zapomniałeś hasła?
    </div>
  }
  function EmailFrame(){
    return <div className='emailFrame'>
        <h1>Podaj swój adres email</h1>
        <TextAreaComponent/>
        <SendButton/>
    </div>
  }

  function TextAreaComponent() {
    const [textAreaInput, setTextAreaInput] = useState('');
  
    const handleChange = (event) => {
      setTextAreaInput(event.target.value);
    };
  
    return (
          <textarea className='textBox'
            value={textAreaInput} 
            onChange={handleChange} 
            placeholder="Podaj swój email" 
            rows={1} 
            cols={70} 
          />
    );
  }

  function SendButton(){
    return(
      <button className='sendButton'>Wyślij</button>
    )
  }

  
  
  export default AboutPage;
  