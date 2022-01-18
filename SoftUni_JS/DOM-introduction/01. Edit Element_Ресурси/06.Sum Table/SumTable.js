function sumTable() {
    let sum=0;
    let elements = document.querySelectorAll("table tbody td");
    
    for (let index = 1; index < elements.length; index+=2) {
        sum+=Number(elements[index].textContent);
        
    }
    document.getElementById('sum').textContent=sum;
}