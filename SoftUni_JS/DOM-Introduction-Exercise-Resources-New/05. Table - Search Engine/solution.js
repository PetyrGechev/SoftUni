function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);
  
   function onClick() {
     let input=Array.from(document.querySelectorAll("tbody tr"));
     let search=document.getElementById("searchField").value ;
     input.forEach(element => {
        
        let row=(element.textContent);
        if(row.includes(search)){
         element.classList.add("select");
        }else{
           element.classList.remove("select");
        }
        
     });

   }
}