import { html, nothing } from '../../node_modules/lit-html/lit-html.js'
import * as server from '../api/server.js'

/*age: "1 years"
breed: "Teddy guinea pig"
image: "../images/guinea-pig.jpg"
name: "Chibi"
weight: "1kg"
_createdOn: 1617194295480
_id: "136777f5-3277-42ad-b874-76d043b069cb"
_ownerId: "847ec027-f659
*/

const detailsTemplate = (pet, onDelete, isOwner,user,) => html` 
<section id="detailsPage">
    <div class="details">
        <div class="animalPic">
            <img src=${pet.image}>
        </div>
        <div>
            <div class="animalInfo">
                <h1>Name: ${pet.name}</h1>
                <h3>Breed: ${pet.breed}</h3>
                <h4>Age: ${pet.age}</h4>
                <h4>Weight: ${pet.weight}</h4>
                <h4 class="donation">Donation: 0$</h4>
            </div>
            ${user ? html`
            <div class="actionBtn">

                ${isOwner ? html`
                <a href="/edit/${pet._id}" class="edit">Edit</a>
                <a @click=${onDelete} href="javascript:void(0)" class="remove">Delete</a>
                `: 
                html`
                <a  href="#" class="donate">Donate</a>
                `
                
            
                }
                <!-- Only for registered user and creator of the pets-->
                
                <!--(Bonus Part) Only for no creator and user-->
                
            </div>
            `
            : nothing
            
            }
            <!-- if there is no registered user, do not display div-->
            
        </div>
    </div>
</section>
 
`;

export async function detailsPage(ctc) {
    const petId = ctc.params.id;
    const pet = await server.getById(petId);

    if (ctc.user) {
        const isOwner = ctc.user._id == pet._ownerId;
        ctc.user.isOwner = isOwner;
        ctc.render(detailsTemplate(pet, onDelete, ctc.user.isOwner,ctc.user,));
    }
    else { ctc.render(detailsTemplate(pet, onDelete)); }

    console.log(ctc.user)
    async function onDelete() {
        const choice = confirm('Are you sure gezzer?')
        if (choice) {
            await server.deleteById(petId);
            ctc.page.redirect('/')
        }
    }
    
}   