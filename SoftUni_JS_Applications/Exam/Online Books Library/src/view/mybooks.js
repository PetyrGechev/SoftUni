import { html } from '../../node_modules/lit-html/lit-html.js'
import * as bookService from '../api/books.js'

const catalogTemplate = (books) => html`<section id="my-books-page" class="my-books">
    <h1>My Books</h1>
    <!-- Display ul: with list-items for every user's books (if any) -->
    ${books.length > 0 ? html`
    <ul class="my-books-list">

        ${books.map(f => previewTemplate(f))}
    </ul>`: html`
    <p class="no-books">No books in database!</p>
    `


        }

    <!-- Display paragraph: If the user doesn't have his own books  -->
</section>

`

const previewTemplate = (book) => html`
<li class="otherBooks">
    <h3>${book.title}</h3>
    <p>${book.type}</p>
    <p class="img"><img src=${book.imageUrl}></p>
    <a class="button" href="/details/${book._id}">Details</a>
</li>
`


export async function myBooks(ctc) {

    const books = await bookService.getMybooks(ctc.user._id);
    console.log(books)
    ctc.render(catalogTemplate(books));
}