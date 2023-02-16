import React from 'react';


// user defined hooks
function useLocalStorage(key, defaultValue='') {
    const [state, setState] = React.useState(
        () => {
            return window.localStorage.getItem(key) || defaultValue
        })
    
    React.useEffect(() => {
        window.localStorage.setItem(key, state)
    }, [key, state]);

    return [state, setState];
}



export default function Greeting() {
    //using useState hook
    // lazy useState initializer (function gets run on initialization only)
    //const [name, setName] = React.useState(
    //    () => {
    //        //See how often local storate is accessed
    //        console.log("here");
    //    return window.localStorage.getItem('name') || ''
    //})
    ////const name = stateArray[0]
    ////const setName = stateArray[1]

    //console.log('rendered')

    //// dependency array prevents useEffect running when rendering unless dependency changes
    //// blank array causes not to be used
    //// could also move setItem into the handleChange
    //React.useEffect(() => {
    //    console.log("Side Effect")
    //    window.localStorage.setItem("name", name)
    //},[name]);

    const [name, setName] = useLocalStorage('name');
    const [age, setAge] = useLocalStorage('age');
    const [phone, setPhone] = useLocalStorage('phone');

    const changeName = event => setName(event.target.value);
    const changeAge = event => setAge(event.target.value);
    const changePhone = event => setPhone(event.target.value);

    return (
        <>
        <div>
            <form>
                <label htmlFor='name'>Name: </label>
                <input id='name' name='name' type='text' onChange={changeName} value={name} />
                <br />
                <label htmlFor='age'>Age: </label>
                <input id='age' name='age' type='text' onChange={changeAge} value={age} />
                <br />
                <label htmlFor='phone'>Phone Number: </label>
                <input id='phone' name='phone' type='text' onChange={changePhone} value={phone} />
            </form>
                {name ? <strong>Hello {name}</strong> : 'Please type your name'}
                <br />
                {age ? <strong>You are {age}</strong> : 'Please type your age'}
                <br />
                {phone ? <strong>Your Phone number is {phone}</strong> : 'Please type your phone number' }
        </div>
        </>
    )
}