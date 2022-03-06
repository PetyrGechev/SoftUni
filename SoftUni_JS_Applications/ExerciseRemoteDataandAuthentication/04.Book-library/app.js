const tbody=document.querySelector('tbody');
const editForm=document.getElementById('editForm');
const createForm=document.getElementById('createForm');
editForm.style.display='none'
document.getElementById('loadBooks').addEventListener('click',loadBooks);
document.getElementById('createForm').addEventListener('submit',onCreate);
tbody.addEventListener('click',onClick);
loadBooks()

function onClick(ev){
    ev.preventDefault()
    if(ev.target.className=='delete'){
        
        onDelete(ev.target)

    }else if(ev.target.className=='edit'){
        editForm.style.display='block'
        createForm.style.display='none'
        onEdit(ev.target)

    }
}

async function onEdit(ev){
    const id=ev.parentElement.dataset.id;
    const res=await fetch(`http://localhost:3030/jsonstore/collections/books/`+id)
    const bookToUpdate=await res.json()
   
    const formData = new FormData(editForm);
    const bookTitle=formData.get('title');
    const bookAuthor=formData.get('author');
    const newBook={title: bookTitle, author: bookAuthor}
    updateBook(id,newBook);

}

async function onDelete(ev){
    const id=ev.parentElement.dataset.id;
    deleteBook(id);
    ev.parentElement.parentElement.remove(); 
}

async function onCreate(e){
    e.preventDefault();
    const formData = new FormData(e.target);
    const title=formData.get('title');
    const author=formData.get('author');
    const result=await createBook({title,author});
    e.target.reset();
    tbody.appendChild(createRow(result._id,result))

}

async function request(url, options){

    const response= await fetch(url,options);

    if(response.ok!=true){
        
        const error=await response.json()
        alert(error.message)
        throw new Error(error.message)
    }
    
    const data =await response.json()
    return data;

}
async function loadBooks(){
     const books=await request('http://localhost:3030/jsonstore/collections/books')
     const result=Object.entries(books).map(([id,book])=>createRow(id,book))
     tbody.replaceChildren(...result)

}
function createRow(id,book){
    const row= document.createElement('tr');
    row.innerHTML=`<td>${book.title}</td>
<td>${book.author}</td>
<td data-id=${id}>
    <button class="edit">Edit</button>
    <button class="delete">Delete</button>
</td>`
    return row;
}



async function createBook(book){
    const result=await request('http://localhost:3030/jsonstore/collections/books',{
        method:'post',
        headers:{
            'Content-Type':'application/json'
        },
        body: JSON.stringify(book)
    })
    return result;
}
async function updateBook(id,book){
    const result=await request('http://localhost:3030/jsonstore/collections/books/'+id,{
        method:'put',
        headers:{
            'Content-Type':'application/json'
        },
        body: JSON.stringify(book)
    })
    return result;

}
async function deleteBook(id,book){
    const result=await request('http://localhost:3030/jsonstore/collections/books/'+id,{
        method:'delete',
        body: JSON.stringify(book)
    })
    return result;

}