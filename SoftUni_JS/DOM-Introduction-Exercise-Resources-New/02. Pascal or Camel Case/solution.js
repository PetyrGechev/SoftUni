function solve() {
    let input=document.getElementById("text").value ;
    let result='';
    let splitedText=input.split(' ');
    let namingConv=document.getElementById("naming-convention").value;
  
    if(namingConv=="Camel Case"){
      let firstword=splitedText[0].toLowerCase()
      result+=firstword
      for (let index = 1; index < splitedText.length; index++) {
        let word=splitedText[index].toLowerCase();
        word=word[0].toUpperCase()+word.slice(1);
        result+=word;
        
      }

    }else if(namingConv=="Pascal Case"){
      for (let index = 0; index < splitedText.length; index++) {
        let word=splitedText[index].toLowerCase();
        word=word[0].toUpperCase()+word.slice(1);
        result+=word;
        
      }

    }else{
      let finalResult=document.getElementById("result");
      finalResult.textContent="Error!";
      return;
      
    }
    let finalResult=document.getElementById("result");
    finalResult.textContent=result;
}