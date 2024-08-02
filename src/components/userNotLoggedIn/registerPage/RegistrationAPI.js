import {useState} from 'react'

const [registrationData, setRegistrationData] = useState({
    role: roleChoice,
    pesel: "",
    firstName: "",
    secondName: "",
    lastName: "",
    phoneNumber: "",
    email: "",
    password: "",
    passwordConfirm: "",
    birthDate: "",
    acception: false,
});


function updateRegisterData(event) {
    const { name, value, type, checked } = event.target;
    setRegistrationData((prevRegisterData) => {
      return {
        ...prevRegisterData,
        [name]: type === "checkbox" ? checked : value,
      };
    });
}

const register = () => {
    return fetch('https://localhost:5001/api/account/sign-up', {
        method: 'POST',
        headers: {
            Accept: 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            "name": registrationData.firstName,
            "secondName": registrationData.secondName,
            "surname": registrationData.lastName,
            "pesel": registrationData.pesel,
            "phoneNumber": registrationData.phoneNumber,
            "birthDate": registrationData.birthDate,
            "email": registrationData.email,
            "password": registrationData.password,
            "repeatPassword": registrationData.repeatPassword,
            "role": registrationData.role
        })
    }).catch(
        console.error(error)
    )
}



