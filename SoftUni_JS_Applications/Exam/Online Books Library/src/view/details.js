import { html ,nothing} from '../../node_modules/lit-html/lit-html.js'
import * as bookService from '../api/books.js'

const detailsTemplate = (book,onDelete, isOwner) => html`  
 <section id="details-page" class="details">
            <div class="book-information">
                <h3>${book.title}</h3>
                <p class="type">${book.type}</p>
                <p class="img"><img src=${book.imageUrl}></p>
                <div class="actions">
                    <!-- Edit/Delete buttons ( Only for creator of this book )  -->
                    ${isOwner ? html`
                    <a class="button" href="/edit/${book._id}">Edit</a>
                    <a class="button" @click=${onDelete} href="javascript:void(0)">Delete</a>
                    
                    `: nothing
                    }
                    
                    
                    <!-- Bonus -->
                
                    <!-- Bonus -->
                </div>
            </div>
            <div class="book-description">
                <h3>Description:</h3>
                <p>${book.description}</p>
            </div>
        </section>

`;

export async function detailsPage(ctc) {
    const bookId = ctc.params.id;
    const book = await bookService.getById(bookId);

    if(ctc.user){
        const isOwner=ctc.user._id==book._ownerId;
        ctc.user.isOwner=isOwner;
        ctc.render(detailsTemplate(book,onDelete, ctc.user.isOwner));
    }
      
    else{ ctc.render(detailsTemplate(book,onDelete));}
   

    async function onDelete(){
        const choice=confirm('Are you sure gezzer?')
        if(choice){
            await bookService.deleteById(bookId);
            ctc.page.redirect('/')
        }
    }
    console.log(book)
    console.log(ctc.user)
}
// <!-- Like button ( Only for logged-in users, which is not creators of the current book ) -->
// <a class="button" href="#">Like</a>

// <!-- ( for Guests and Users )  -->
// <div class="likes">
//     <img class="hearts" src="/images/heart.png">
//     <span id="total-likes">Likes: 0</span>
// </div>