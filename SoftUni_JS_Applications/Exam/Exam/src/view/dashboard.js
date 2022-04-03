import { html } from '../../node_modules/lit-html/lit-html.js'
import * as server from '../api/server.js'

const catalogTemplate = (pets) => html`  
<section id="dashboard">
    <h2 class="dashboard-title">Services for every animal</h2>
    <div class="animals-dashboard">
        ${pets.length >0 ? html`
        ${pets.map(f=>previewTemplate(f))}
        `: 
        html`
        <div>
            <p class="no-pets">No pets in dashboard</p>
        </div>
        ` 
        }

        <!--If there is no pets in dashboard-->
        
    </div>
</section>
`;

const previewTemplate = (pet) => html`
<div class="animals-board">
    <article class="service-img">
        <img class="animal-image-cover" src=${pet.image}>
    </article>
    <h2 class="name">${pet.name}</h2>
    <h3 class="breed">${pet.breed}</h3>
    <div class="action">
        <a class="btn" href="/details/${pet._id}">Details</a>
    </div>
</div>
`

export async function dashboardPage(ctc) {
    const pets = await server.getAll();
    console.log(pets)
    ctc.render(catalogTemplate(pets));
}

/*age: "1 years"
breed: "Teddy guinea pig"
image: "../images/guinea-pig.jpg"
name: "Chibi"
weight: "1kg"
_createdOn: 1617194295480
_id: "136777f5-3277-42ad-b874-76d043b069cb"
_ownerId: "847ec027-f659
*/