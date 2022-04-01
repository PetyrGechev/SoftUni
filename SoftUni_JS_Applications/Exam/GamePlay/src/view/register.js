import { html } from '../../node_modules/lit-html/lit-html.js'
import { createSubmitHandler } from '../api/util.js';
import * as userService from '../api/user.js'

const registerTemplate = (onSubmit) => html`  
  <section id="register-page" class="content auth">
            <form @submit=${onSubmit} id="register">
                <div class="container">
                    <div class="brand-logo"></div>
                    <h1>Register</h1>

                    <label for="email">Email:</label>
                    <input type="email" id="email" name="email" placeholder="maria@email.com">

                    <label for="pass">Password:</label>
                    <input type="password" name="password" id="register-password">

                    <label for="con-pass">Confirm Password:</label>
                    <input type="password" name="confirm-password" id="confirm-password">

                    <input class="btn submit" type="submit" value="Register">

                    <p class="field">
                        <span>If you already have profile click <a href="/login">here</a></span>
                    </p>
                </div>
            </form>
        </section>
`;

export async function registerPage(ctc) {
    ctc.render(registerTemplate(createSubmitHandler(ctc,onSubmit)));
}

async function onSubmit(ctc,data,event){
    if(data.email=='' || data.password==''){
        return alert('All fields are required')
    }
    if(data.password!=data['confirm-password']){
        return alert('Passwords must be the same')
    }
    await userService.register(data.email,data.password);
    event.target.reset();
    ctc.page.redirect('/')
}