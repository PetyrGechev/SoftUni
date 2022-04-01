import { html, render } from '../../node_modules/lit-html/lit-html.js';
const root = document.getElementById('site-content')
const header = document.getElementById('site-header')

const navTemplate = (user) => html`
<nav class="navbar">
    <section class="navbar-dashboard">
        <a href="/">Dashboard</a>

        ${
            user ? html` <div id="user">
            <span>Welcome, ${user.email}</span>
            <a class="button" href="/myBooks/:id">My Books</a>
            <a class="button" href="/addBook">Add Book</a>
            <a class="button" href="/logout">Logout</a>
        </div>`
        : html` <div id="guest">
         <a class="button" href="/login">Login</a>
         <a class="button" href="/register">Register</a>
        </div>`
        }
      
    </section>
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