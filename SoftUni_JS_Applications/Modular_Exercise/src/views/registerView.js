import{render ,html} from '../../node_modules/lit-html/lit-html.js'


const root=document.querySelector('#root');



 const registerTemplate=()=>
    console.log('in')
     html`<h1>Register</h1>`;
 



export const registerView =()=>{
    render(registerTemplate(),root);
}