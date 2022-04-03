// import { html } from '../../node_modules/lit-html/lit-html.js'
// import * as server from '../api/server.js'
// import { createSubmitHandler } from '../api/util.js';

// const editTemplate = (theater,onSubmit) => html`  
//        <section id="editPage">
//             <form @submit=${onSubmit} class="theater-form">
//                 <h1>Edit Theater</h1>
//                 <div>
//                     <label for="title">Title:</label>
//                     <input id="title" name="title" type="text" placeholder="Theater name" .value=${theater.title}>
//                 </div>
//                 <div>
//                     <label for="date">Date:</label>
//                     <input id="date" name="date" type="text" placeholder="Month Day, Year" .value=${theater.date}>
//                 </div>
//                 <div>
//                     <label for="author">Author:</label>
//                     <input id="author" name="author" type="text" placeholder="Author"
//                         .value=${theater.author}>
//                 </div>
//                 <div>
//                     <label for="description">Theater Description:</label>
//                     <textarea id="description" name="description"
//                         placeholder="Description" .value=${theater.description}></textarea>
//                 </div>
//                 <div>
//                     <label for="imageUrl">Image url:</label>
//                     <input id="imageUrl" name="imageUrl" type="text" placeholder="Image Url"
//                         .value=${theater.imageUrl}>
//                 </div>
//                 <button class="btn" type="submit">Submit</button>
//             </form>
//         </section>
// `;

// export async function editPage(ctc) {
//     const id=ctc.params.id;
//     const theater = await server.getById(id);
    
//     ctc.render(editTemplate(theater,createSubmitHandler(ctc,onSubmit)))

//     async function onSubmit(ctc, data, e) {
//         const id=ctc.params.id;
//         if (Object.values(data).some(f => f == '')) {
//             return alert('all fields are required')
//         }
      
//         server.editById(id,{
//             title:data.title,
//             date:data.date,
//             author:data.author,
//             description:data.description,
//             imageUrl:data.imageUrl
         
//         })
//         e.target.reset();
//         ctc.page.redirect('/details/'+id);
//     }
// }