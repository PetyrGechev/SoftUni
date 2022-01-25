function attachGradientEvents() {
    let result=document.getElementById("result");

    let gradient=document.getElementById('gradient');
    gradient.addEventListener("mousemove", solve);
    function solve(ev){
        
        //gradient.removeEventListener("mousemove", solve);
       let resultData=Number(Math.floor(ev.offsetX/ev.target.clientWidth*100))
       console.log(resultData)
       result.textContent=`${resultData}%`;
    }

}