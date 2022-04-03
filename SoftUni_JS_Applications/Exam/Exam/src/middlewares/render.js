import { html, render } from '../../node_modules/lit-html/lit-html.js';
const root = document.getElementById('content')
const header = document.getElementById('site-header')

const navTemplate = (user) => html`

<nav>
    <section class="logo">
        <img src="./images/logo.png" alt="logo">
    </section>
    <ul>
        <!--Users and Guest-->
        <li><a href="/">Home</a></li>
        <li><a href="/dashboard">Dashboard</a></li>
        
        ${user? html`
        <li><a href="/create">Create Postcard</a></li>
        <li><a href="/logout">Logout</a></li>`
        :
        html`
        <li><a href="/login">Login</a></li>
        <li><a href="/register">Register</a></li>`
        }


        <!--Only Guest-->   
        
        <!--Only Users-->
        
    </ul>
</nav>

 `;

export function addRender(ctc, next) {

    function ctcRender(content) {
        render(content, root);
    }

    render(navTemplate(ctc.user), header)
    ctc.render = ctcRender;
    next();
}

