class LibraryCollection{

    constructor(capacity) {
        this.capacity=capacity;
        this.books=[];
        
    }

    addBook (bookName, bookAuthor){
        //The bookName and bookAuthor are of type string. 
        /*{bookname:bookname,
            bookautor:bookautor,
            payed:false


         */

         if(this.capacity<=this.books.length){                        /// try - 1 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            throw new Error(`Not enough space in the collection.`);
         }
         let book={
             bookName,
             bookAuthor,
             payed:false
         }
         this.books.push(book);
         return `The ${bookName}, with an author ${bookAuthor}, collect.`
    }


    payBook(bookName) {
        if(!this.books.some(x=>x.bookName==bookName)){
            throw new Error(`${bookName} is not in the collection.`)
        }
        let book=this.books.find(x=>x.bookName==bookName);
        if(book.payed==true){
            throw new Error(`${bookName} has already been paid.`)
        }
        book.payed=true;
        return `${bookName} has been successfully paid.`
    }


    removeBook(bookName) {

        if(!this.books.some(x=>x.bookName==bookName)){
            throw new Error(`The book, you're looking for, is not found.`)
        }
        let book=this.books.find(x=>x.bookName==bookName);
        if(book.payed==false){
            throw new Error(`${bookName} need to be paid before removing from the collection.`)

        }
        let bookIndex=this.books.findIndex(x=>x.bookName==bookName);
        this.books.splice(bookIndex,1);
        //this.books=this.books.filter(x=>x.bookName==bookName);

        return `${bookName} remove from the collection.`

    }


    getStatistics(bookAuthor){

        if(bookAuthor==undefined){

            let result=[];
            result.push(`The book collection has ${this.capacity-this.books.length} empty spots left.`);   /// !!!!!!!!!!!!!!!!!!!! check

           for (const book of this.books) {
               if(book.payed==true){
                result.push(`${book.bookName} == ${book.bookAuthor} - Has Paid.`)
               }else{
                   result.push((`${book.bookName} == ${book.bookAuthor} - Not Paid.`))
               }

           }
           return result.join('\n');
            //"{bookName} == {bookAuthor} - {Has Paid / Not Paid}."
        }
        if(!this.books.some(x=>x.bookAuthor==bookAuthor)){
            return `${bookAuthor} is not in the collection.`
        }

        let book=this.books.find(x=>x.bookAuthor==bookAuthor);
        if(book.payed==true){
            return `${book.bookName} == ${book.bookAuthor} - Has Paid.`
        }else{
            return `${book.bookName} == ${book.bookAuthor} - Not Paid.`
        }


    }
    
}
const library = new LibraryCollection(5)
library.addBook('Don Quixote', 'Miguel de Cervantes');
library.payBook('Don Quixote');
library.addBook('In Search of Lost Time', 'Marcel Proust');
library.addBook('Ulysses', 'James Joyce');
console.log(library.getStatistics());


