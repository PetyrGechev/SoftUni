import { html, render } from '../../node_modules/lit-html/lit-html.js';
const root = document.getElementById('main-content')
const header=document.getElementById('myNav')

const navTemplate = (user) => html`
<h1><a class="home" href="/">GamesPlay</a></h1>
<nav>
    <a href="/catalog">All games</a>
    ${user ? html`
    <div id="user">
        <a href="/create">Create Game</a>
        <a href="/logout">Logout</a>
    </div>` :html`
    <div id="guest">
        <a href="/login">Login</a>
        <a href="/register">Register</a>
    </div>
    `}
    
</nav>

`;

export function addRender(ctc, next) {

    function ctcRender(content) {
        render(content, root);
    }

    render(navTemplate(ctc.user),header)
    ctc.render = ctcRender;
    next();
}