function deleteByEmail() {
    let inputEmail=document.getElementsByName("email")[0].value;
    let result=document.getElementById("result");
    console.log(inputEmail)
    let found=false;
    let rows=Array.from(document.querySelectorAll("tbody tr td"));
    rows.forEach(element => {
       if(element.textContent==inputEmail){
           console.log(element.parentNode.parentNode)
           element.parentNode.parentNode.removeChild(element.parentNode);
           found=true
           
       }

    });
    result.textContent = (found ) ? "Deleted." : "Not found.";
}