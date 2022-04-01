import { html } from '../../node_modules/lit-html/lit-html.js'
import * as gameService from '../api/games.js'

const catalogTemplate = (games) => html`  
<section id="catalog-page">
            <h1>All Games</h1>
            <!-- Display div: with information about every game (if any) -->
           
            ${games.lenght >0 ? games.map(previewTemplate): html` <h3 class="no-articles">No articles yet</h3>`}

        
           
        </section>
`;
const previewTemplate=(game)=>html` <div class="allGames">
<div class="allGames-info">
    <img src="${game.imageUrl}">
    <h6>${game.category}</h6>
    <h2>${game.title}</h2>
    <a href="/details/${game._id}" class="details-button">Details</a>
</div>

`;

export async  function catalogPage(ctc) {
    const games=await gameService.getАll();
    ctc.render(catalogTemplate(games));
}