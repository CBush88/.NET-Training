import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';

const root = ReactDOM.createRoot(document.getElementById('root'));

function getLoginStatus(is_LoggedIn) {
    if (is_LoggedIn) {
        return (<p>You are logged in.</p>);
    } else {
        return (<a href="login.html">Login</a>);
    }
}

function getNotificationDetails(notifications) {
    return (<p>You have {notifications.length} notifications </p>)
}
const element = <>
    <div>Hello</div>
</>

//Why do I have to practice with code snippets that don't work?
function getButton(text, buttonColor) {

    //console.log(<button style={'background-color:' + buttonColor}>{text}</button>) 

    return (<button className={buttonColor + 'BackColor'} >{text}</button>);
} 


//root.render(getLoginStatus(false));
//root.render(getNotificationDetails([1, 2, 3]));
root.render(getButton("Hello", blue));



//root.render(
//  <React.StrictMode>
//        <App />
//  </React.StrictMode>
//);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
