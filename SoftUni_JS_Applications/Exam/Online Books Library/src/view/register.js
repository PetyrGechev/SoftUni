import { html } from '../../node_modules/lit-html/lit-html.js'
import { createSubmitHandler } from '../api/util.js';
import * as userService from '../api/user.js'

const registerTemplate = (onSubmit) => html`  
   <section id="register-page" class="register">
            <form @submit=${onSubmit} id="register-form" action="" method="">
                <fieldset>
                    <legend>Register Form</legend>
                    <p class="field">
                        <label for="email">Email</label>
                        <span class="input">
                            <input type="text" name="email" id="email" placeholder="Email">
                        </span>
                    </p>
                    <p class="field">
                        <label for="password">Password</label>
                        <span class="input">
                            <input type="password" name="password" id="password" placeholder="Password">
                        </span>
                    </p>
                    <p class="field">
                        <label for="repeat-pass">Repeat Password</label>
                        <span class="input">
                            <input type="password" name="confirm-pass" id="repeat-pass" placeholder="Repeat Password">
                        </span>
                    </p>
                    <input class="button submit" type="submit" value="Register">
                </fieldset>
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
    if(data.password!=data['confirm-pass']){
        return alert('Passwords must be the same')
    }
    await userService.register(data.email,data.password);
    event.target.reset();
    ctc.page.redirect('/')
}