function solve() {
  //(`<p> {text} </p>`)
  let outText=document.getElementById("output");
  let input=document.getElementById("input").value.split(".").filter((p) => p.length > 0);;
  let result='';
  let temp='';
  console.log(input)
  for (let i = 1; i <= input.length; i++) {
    
    temp+=input[i-1]+'.';
    if(i%3==0 ){
      result+=`<p> ${temp} </p> `
      temp='';
    }
    if(i==input.length){
      result+=`<p> ${temp} </p> `
    }
   
    
  }
  console.log(result)
  outText.innerHTML=result
}