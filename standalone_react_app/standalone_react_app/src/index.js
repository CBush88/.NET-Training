import React, { useState } from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import Box from './Box';
import Greeting from './Greetings'
import reportWebVitals from './reportWebVitals';
import PropTypes from 'prop-types';

const root = ReactDOM.createRoot(document.getElementById('root'));


function GreetingsApp() {
    const [count, setCount] = React.useState(0)
    return (
        <div>
            <button onClick={() => { setCount(count + 1) }}>{count}</button>
            <Greeting />
        </div>
        )
}



root.render(<GreetingsApp />)


// Utility with useState

//function Utility() {
//    const [count, setCount] = useState(0)
//    const [message, setMessage] = useState('')

//    return (<div>
//        <p>Event Count: {count} </p>
//        <button onClick={() => setCount(count + 1)}>Click</button>
//        <input onChange={event => setMessage(event.target.value)} />
//        <p>You typed: {message}</p>
//    </div>
//    )
//}

//root.render(<Utility />)

//function setState(newState) {
//    Object.assign(state, newState);
//    console.log(state.eventCount)
//    renderApp();
//}

//function renderApp() {
//    root.render(<Utility />)
//}



//function Greeting() {
//    //using useState hook
//    const [name, setName] = React.useState('')
//    const [name1, setName1] = React.useState('')
//    //const name = stateArray[0]
//    //const setName = stateArray[1]

//    const handleChange = event => setName(event.target.value);
//    const handleChange1 = event => setName1(event.target.value);

//    return (
//        <>
//        <div>
//            <form>
//                <label htmlFor='name'>Name: </label>
//                <input id='name' type='text' onChange={handleChange} />
//            </form>
//            {name ? <strong>Hello {name}</strong> : 'Please type your name'}
//        </div>
//        <div>
//            <form>
//                <label htmlFor='name'>Name: </label>
//                <input id='name' type='text' onChange={handleChange1} />
//            </form>
//            {name1 ? <strong>Hello {name1}</strong> : 'Please type your name'}
//        </div>
//        </>
//    )
//}

//root.render(<Greeting />)

// Hooks
// Earlier we were having class components (methods to manage state)
// Functional Components were stateless earlier and
// The hooks introduced the state to the functional components to make them stateful


//const state = { eventCount: 0, message: '' }


//function Utility() {

//    return (<div>
//        <p>Event Count: {state.eventCount} </p>
//        <button onClick={() => setState({ eventCount: state.eventCount + 1 })}>Click</button>
//        <input onChange={event => setState({ message: event.target.value})} />
//        <p>You typed: {state.message}</p>
//    </div>)
//}

//function setState(newState) {
//    Object.assign(state, newState);
//    console.log(state.eventCount)
//    renderApp();
//}

//function renderApp() {
//    root.render(<Utility />)
//}

//renderApp()

//const element = (
//    <div>
//        <Box size='small' style={{ backgroundColor: 'red' }} className='box box--small'>Small Box</Box>
//        <Box size='medium' style={{ backgroundColor: 'blue' }} className='box box--medium'>Medium Box</Box>
//        <Box size='large' style={{ backgroundColor: 'green' }} className='box box--large'>Large Box</Box>
//        <Box></Box>
//    </div>
//)

//root.render(Utility())


//function repeat() {
//    const time = new Date().toLocaleTimeString();

//    const element = (< div >
//        { time }
//    </div >
//    );

//    root.innerhtml = element;
//    root.render(element);

//}

//repeat();
//setInterval(repeat, 1000);

//function TextLength({ text }) {
//    return (
//        <div>
//            {/*The text {text.length > 0 ? `${text} has' ${text.length} characters` : `has no characters`}*/}
//            {`The text ${text} has `}
//            {text.length > 0 ? <strong>{text.length}</strong> : 'no'}
//            {' characters.' }
//        </div>
//        )}

//const element = <>
//    <TextLength text="Learning React" />
//    <TextLength text="" />

//</>




//functional components

//function User({ firstName, lastName }) {
//    return(
//        <div>
//            Hello {firstName} {lastName}!
//        </div>
//        )
//}

//Validate the props using propTypes
//const PropTypes = {
//    string(props, propName, componentName) {
//        if (typeof props[propName] !== 'string') {
//    return new Error(`You are passing a ${typeof props[propName]} instead of string for the ${componentName}`)
//        }
//    }
//}

//User.propTypes = {
//    firstName: PropTypes.string.isRequired,
//    lastName: PropTypes.string.isRequired
//}

//reusable component

//const Message = (props) => <div className={props.className}>{props.children}</div>

//const children = <> <h2>Child1</h2> <h2>Child2</h2> </>

//const element = <div className='container'>
//    <Message children={children}></Message>
//    <Message children='Yet another way' className='another'/>
//    <Message className='message1'>JSX is making it smooth</Message>
//    <Message className='message2'>React is easy</Message>
//    <Message className='message3'>Like JavaScript</Message>

//    <User firstName="Bob" lastName="Kite" />

//</div>

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
//root.render(element)


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
