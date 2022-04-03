import { html } from '../../node_modules/lit-html/lit-html.js'
import * as server from '../api/server.js'
import { createSubmitHandler } from '../api/util.js';

const editTemplate = (pet, onSubmit) => html`  
    <section id="editPage">
        <form @submit=${onSubmit} class="editForm">
            <img src=${pet.image}>
            <div>
                <h2>Edit PetPal</h2>
                <div class="name">
                    <label for="name">Name:</label>
                    <input name="name" id="name" type="text" .value=${pet.name}>
                </div>
                <div class="breed">
                    <label for="breed">Breed:</label>
                    <input name="breed" id="breed" type="text" .value="${pet.breed}">
                </div>
                <div class="Age">
                    <label for="age">Age:</label>
                    <input name="age" id="age" type="text" .value=${pet.age}>
                </div>
                <div class="weight">
                    <label for="weight">Weight:</label>
                    <input name="weight" id="weight" type="text" .value=${pet.weight}>
                </div>
                <div class="image">
                    <label for="image">Image:</label>
                    <input name="image" id="image" type="text" .value=${pet.image}>
                </div>
                <button class="btn" type="submit">Edit Pet</button>
            </div>
        </form>
    </section>
`;

export async function editPage(ctc) {
    const id = ctc.params.id;
    const pet = await server.getById(id);
    console.log(pet)

    ctc.render(editTemplate(pet, createSubmitHandler(ctc, onSubmit)))

    async function onSubmit(ctc, data, e) {
        const id = ctc.params.id;
        if (Object.values(data).some(f => f == '')) {
            return alert('all fields are required')
        }

        server.editById(id, {    
            name:data.name,
            breed:data.breed,
            age:data.age,
            weight:data.weight,
            image:data.image
        })
        e.target.reset();
        ctc.page.redirect('/details/' + id);
    }
}