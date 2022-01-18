function extractText() {
    let result=[]
    const text=document.getElementById('items').children;
    let textarea=document.getElementById('result');
    for (let index = 0; index < text.length; index++) {
    
        result.push(text[index].textContent);
    }
   console.log(result)
   textarea.value=result.join("\n")

}
