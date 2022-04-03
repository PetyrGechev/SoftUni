import { html, render } from '../../node_modules/lit-html/lit-html.js';
const root = document.getElementById('content')
const header = document.getElementById('site-header')

const navTemplate = (user) => html`
<nav>
    <a href="/">Theater</a>
    <ul>

        ${user? html` 
        <li><a href="/profile">Profile</a></li>
        <li><a href="/create">Create Event</a></li>
        <li><a href="/logout">Logout</a></li>` 
        :
        html`
        <li><a href="/login">Login</a></li>
        <li><a href="/register">Register</a></li>`}
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

