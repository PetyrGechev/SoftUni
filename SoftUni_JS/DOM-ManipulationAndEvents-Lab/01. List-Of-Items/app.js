function addItem() {
    let input=document.getElementById("newItemText").value ;
    let newLi=document.createElement("li");
    newLi.textContent=input;
    let ud=document.getElementById("items");
    ud.appendChild(newLi);
    console.log(input)
}