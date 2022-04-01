import { html , nothing } from '../../node_modules/lit-html/lit-html.js'
import * as bookService from '../api/books.js'

const detailsTemplate = (game,onDelete) => html`  
  <section id="game-details">
            <h1>Game Details</h1>
            <div class="info-section">

                <div class="game-header">
                    <img class="game-img" src=${game.imageUrl} />
                    <h1>${game.title}</h1>
                    <span class="levels">MaxLevel: ${game.maxLevel}</span>
                    <p class="type">${game.category}</p>
                </div>

                <p class="text">
                    ${game.summary}
                </p>

                
                ${game.isOwner ?
                html`<div class="buttons">
                    <a  href="javascript:void(0" class="button">Edit</a>
                    <a @click=${onDelete} href="javascript:void(0)" class="button">Delete</a>
                   
                </div>`
                :
                nothing
                }
                    
                
                
            </div>


        </section>

`;

export async function detailsPage(ctc) {
    const gameId = ctc.params.id;
    const game = await gameService.getById(gameId);

    if(ctc.user){
        const isOwner=ctc.user._id==game._ownerId;
        game.isOwner=isOwner;
    }
    ctc.render(detailsTemplate(game,onDelete));

    async function onDelete(){
        const choice=confirm('Are you sure gezzer?')
        if(choice){
            await bookService.deleteById(gameId);
            ctc.page.redirect('/')
        }
    }
}