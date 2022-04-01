import { html } from '../../node_modules/lit-html/lit-html.js'
import * as bookService from '../api/books.js'

const catalogTemplate = (books) => html` 
<section id="dashboard-page" class="dashboard">
    <h1>Dashboard</h1>

    ${books.length > 0 ? html`
      <ul class="other-books-list">
      ${books.map(f=>previewTemplate(f))}
      </ul>`


    :
    html`
    <p class="no-books">No books in database!</p>
    `
    }
   
`;


const previewTemplate = (book) =>  html`
    <li class="otherBooks">
        <h3>${book.title}</h3>
        <p>${book.type}</p>
        <p class="img"><img src=${book.imageUrl}></p>
        <a class="button" href="/details/${book._id}">Details</a>
    </li>`


export async function catalogPage(ctc) {
  
    const books = await bookService.getАll();

    ctc.render(catalogTemplate(books));
}