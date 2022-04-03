import { html, nothing } from '../../node_modules/lit-html/lit-html.js'
import * as server from '../api/server.js'

const detailsTemplate = (theater, onDelete,isOwner) => html` 
<section id="detailsPage">
    <div id="detailsBox">
        <div class="detailsInfo">
            <h1>${theater.title}</h1>
            <div>
                <img src=${theater.imageUrl} />
            </div>
        </div>

        <div class="details">
            <h3>Theater Description</h3>
            <p>${theater.description}</p>
            <h4>${theater.date}</h4>
            <h4>${theater.author}</h4>
            <div class="buttons">

            ${isOwner? html`
            <a class="btn-delete" @click=${onDelete} href="javascript:void(0)">Delete</a>
            <a class="btn-edit" href="/edit/${theater._id}">Edit</a>
            
            `: nothing }
                
                <a class="btn-like" href="#">Like</a>
            </div>
            <p class="likes">Likes: 0</p>
        </div>
    </div>
</section>
 
`;

export async function detailsPage(ctc) {
    const theaterId = ctc.params.id;
    const theater = await server.getById(theaterId);

    if (ctc.user) {
        const isOwner = ctc.user._id == theater._ownerId;
        ctc.user.isOwner = isOwner;
        ctc.render(detailsTemplate(theater,onDelete, ctc.user.isOwner));
    }
    else{ ctc.render(detailsTemplate(theater,onDelete));}
    
    console.log(ctc.user)
    async function onDelete() {
        const choice = confirm('Are you sure gezzer?')
        if (choice) {
            await server.deleteById(theaterId);
            ctc.page.redirect('/')
        }
    }
}