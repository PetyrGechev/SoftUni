function search() {
   let towns=Array.from(document.querySelectorAll("ul li"));
   let result=document.getElementById("result");
   let search=document.getElementById("searchText").value;
   let matches=0;
   towns.forEach(element => {
     let town=element.textContent;

      if (town.includes(search)) {
         matches++;
         element.style.fontWeight="bold";
         element.style.textDecoration = "underline";
      }else{
         element.style.fontWeight="normal";
         element.style.textDecoration = "none";
      }

   });
   if(matches!=0){
      result.textContent=`${matches} matches found`;
   }else{
      result.textContent='';
   }
   
}
