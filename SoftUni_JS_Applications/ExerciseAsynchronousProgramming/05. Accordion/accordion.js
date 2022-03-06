async function solution() {

    const mainElement=document.getElementById("main");

    const res=await fetch(`http://localhost:3030/jsonstore/advanced/articles/list`);
    const data = await res.json();
   
    // array - title: "Scalable Vector Graphics"    _id="ee9823ab-c3e8-4a14-b998-8c22ec246bd3"
    data.forEach(async (article) => {

        const res =await fetch(`http://localhost:3030/jsonstore/advanced/articles/details/${article._id}`);
        const element=await res.json();
        

        let spanElement=document.createElement('span');
       spanElement.textContent=element.title;

       let buttonElement=document.createElement('button');
       buttonElement.classList.add("button");
       buttonElement.textContent="More";
       buttonElement.setAttribute('id',element._id);
       buttonElement.addEventListener('click', showHiddenDiv)

       let headDivElement=document.createElement('div');
       headDivElement.classList.add("head");
        
       headDivElement.appendChild(spanElement);
       headDivElement.appendChild(buttonElement);

       let divExtra=document.createElement('div');
       divExtra.classList.add("extra");
       //.content
       let pElement=document.createElement("p");
       pElement.textContent=element.content;
       divExtra.appendChild(pElement);
       
       let mainDivElement=document.createElement("div");
       mainDivElement.classList.add("accordion");
       mainDivElement.appendChild(headDivElement);
       mainElement.appendChild(mainDivElement);
       mainDivElement.appendChild(divExtra);

       



       function showHiddenDiv(ev){
          
           if(ev.target.textContent=="More") {
            ev.target.textContent="Less";
            //console.log("click in")
            ev.target.parentElement.nextSibling.style.display="block";
           }else{
            ev.target.textContent="More"
            ev.target.parentElement.nextSibling.style.display="none";
           }
           
       }
        
    });
    


       
    


//     content: "Scalable Vector Graphics (SVG) is an Extensible Markup Language (XML)-based vector image format for two-dimensional graphics with support for interactivity and animation. The SVG specification is an open standard developed by the World Wide Web Consortium (W3C) since 1999."
//     title: "Scalable Vector Graphics"
//    _id: "ee9823ab-c3e8-4a14-b998-8c22ec246bd3"

}
solution();