import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import PropTypes from 'prop-types';

const root = ReactDOM.createRoot(document.getElementById('root'));

//functional components

function User({ firstName, lastName }) {
    return(
        <div>
            Hello {firstName} {lastName}!
        </div>
        )
}

//Validate the props using propTypes
//const PropTypes = {
//    string(props, propName, componentName) {
//        if (typeof props[propName] !== 'string') {
//    return new Error(`You are passing a ${typeof props[propName]} instead of string for the ${componentName}`)
//        }
//    }
//}

User.propTypes = {
    firstName: PropTypes.string.isRequired,
    lastName: PropTypes.string.isRequired
}

//reusable component

const Message = (props) => <div className={props.className}>{props.children}</div>

const children = <> <h2>Child1</h2> <h2>Child2</h2> </>

const element = <div className='container'>
    <Message children={children}></Message>
    <Message children='Yet another way' className='another'/>
    <Message className='message1'>JSX is making it smooth</Message>
    <Message className='message2'>React is easy</Message>
    <Message className='message3'>Like JavaScript</Message>

    <User firstName="Bob" lastName="Kite" />

</div>

//using props
/*
const className = 'container';
const version = React.version;
const children = 'Learning React ' + React.version;
const style = { backgroundColor: 'blue', width: '100px' };

const prop = {className, children, style}


const h2Child = <h2 {...prop}></h2>
const h2Child1 = <h2> and JSX </h2>



//using JSX

const divElement = <div className={className}>{h2Child} {h2Child1}</div>

const element = <> {h2Child} {h2Child1} </>

const reactElement = React.createElement(React.Fragment, null, h2Child, h2Child1);
*/



 //const divElement = <div className="container"><h2 style={{backgroundColor: 'blue', width: '100px'}}>Learning React</h2></div>;


//Using React.createElement()
/*
const element = React.createElement("h2", {
    className: 'container'
}, "Learning React");

const divElement = React.createElement("div", null, element, "It's fun implementing code", React.createElement("h3", null, "Majorly FrontEnd."));

*/

//for react 18 or later
root.render(element)


//for react 17 or previous
// ReactDOM.render(element, root);
//console.log(divElement)

/* Using Vanilla JavaScript
//object representing an element
const element = document.createElement("h2");
element.textContent = "Learning React " + React.version;
element.className = "container";
root.appendChild(element);
*/

//root.render(
//  <React.StrictMode>
//    <App />
//  </React.StrictMode>
//);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
