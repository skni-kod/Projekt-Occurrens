import './ForgotPassword.css';
import React, { useState } from 'react';
import { RouterProvider, createBrowserRouter } from "react-router-dom";
import EmailSent from "../emailSent/EmailSent";
import { useNavigate } from 'react-router-dom';
import { NavLink, Outlet } from "react-router-dom";


function ForgotPassword() {

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
        <NavLink
                to="emailSent"
              ></NavLink>
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
    const navigate = useNavigate(); // Use useNavigate hook to programmatically navigate

  const handleButtonClick = () => {
    // Navigate to the emailSent route
    navigate("emailSent");
  };
    return(
      <button className='sendButton' onClick={handleButtonClick}>Wyślij </button>
    )
  }

  
  
  export default ForgotPassword;
  