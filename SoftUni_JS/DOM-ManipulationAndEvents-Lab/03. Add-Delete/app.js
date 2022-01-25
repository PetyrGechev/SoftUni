function addItem() {
    let input=document.getElementById("newItemText").value ;
    let newLi=document.createElement("li");
    let button=document.createElement('a');
    button.href='#';
    button.textContent='[Delete]';
    
    newLi.textContent=input;
    newLi.appendChild(button);
    let ud=document.getElementById("items");
    ud.appendChild(newLi);
    button.addEventListener('click', deleteItem);

    function deleteItem(ev) {
       ev.target.parentNode.parentNode.removeChild(ev.target.parentNode)

    }
  

}