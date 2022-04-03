// import { html } from '../../node_modules/lit-html/lit-html.js'
// import { createSubmitHandler } from '../api/util.js';
// import * as userService from '../api/user.js'

// const registerTemplate = (onSubmit) => html`  
//    <section @submit=${onSubmit} id="registerPage">
//             <form class="registerForm">
//                 <h2>Register</h2>
//                 <div class="on-dark">
//                     <label for="email">Email:</label>
//                     <input id="email" name="email" type="text" placeholder="steven@abv.bg" value="">
//                 </div>

//                 <div class="on-dark">
//                     <label for="password">Password:</label>
//                     <input id="password" name="password" type="password" placeholder="********" value="">
//                 </div>

//                 <div class="on-dark">
//                     <label for="repeatPassword">Repeat Password:</label>
//                     <input id="repeatPassword" name="repeatPassword" type="password" placeholder="********" value="">
//                 </div>

//                 <button class="btn" type="submit">Register</button>

//                 <p class="field">
//                     <span>If you have profile click <a href="/login">here</a></span>
//                 </p>
//             </form>
//         </section>

// `;

// export async function registerPage(ctc) {
//     ctc.render(registerTemplate(createSubmitHandler(ctc,onSubmit)));
// }

// async function onSubmit(ctc,data,event){
//     if(data.email=='' || data.password==''){
//         return alert('All fields are required')
//     }
//     if(data.password!=data['repeatPassword']){
//         return alert('Passwords must be the same')
//     }
//     await userService.register(data.email,data.password);
//     event.target.reset();
//     ctc.page.redirect('/')
// }