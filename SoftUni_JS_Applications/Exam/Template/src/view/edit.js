import { html } from '../../node_modules/lit-html/lit-html.js'
import * as gameService from '../api/games.js'
import { createSubmitHandler } from '../api/util.js';

const editTemplate = (game,onSubmit) => html`  
 <section id="edit-page" class="auth">
            <form @submit=${onSubmit} id="edit">
                <div class="container">

                    <h1>Edit Game</h1>
                    <label for="leg-title">Legendary title:</label>
                    <input type="text" id="title" name="title" .value=${game.title}>

                    <label for="category">Category:</label>
                    <input type="text" id="category" name="category" .value=${game.category}>

                    <label for="levels">MaxLevel:</label>
                    <input type="number" id="maxLevel" name="maxLevel" min="1" .value=${game.maxLevel}>

                    <label for="game-img">Image:</label>
                    <input type="text" id="imageUrl" name="imageUrl" .value=${game.imageUrl}>

                    <label for="summary">Summary:</label>
                    <textarea name="summary" id="summary" .value=${game.summary}></textarea>
                    <input class="btn submit" type="submit" value="Edit Game">

                </div>
            </form>
        </section>
`;

export async function editPage(ctc) {
    const id=ctc.params.id;
    const game = await gameService.getById(id);
    console.log(game)
    ctc.render(editTemplate(game,createSubmitHandler(ctc,onSubmit)))

    async function onSubmit(ctc, data, e) {
        const id=ctc.params.id;
        if (Object.values(data).some(f => f == '')) {
            return alert('all fields are required')
        }
      
        gameService.editById(id,{
            title: data.title,
            category: data.category,
            maxLevel: data.maxLevel,
            imageUrl: data.imageUrl,
            summary: data.summary
        })
        e.target.reset();
        ctc.page.redirect('/details/'+id);
    }
}