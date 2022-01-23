function toggle() {
    let buttonText=document.getElementsByClassName("button")[0].textContent ; 
    let button=document.getElementsByClassName("button")[0];
    let extra=document.getElementById("extra");
   
    if(buttonText=="More"){
        button.textContent='Less'
        
        let extra=document.getElementById("extra");
        extra.style.display='block';

    }else{
        button.textContent='More'
        extra.style.display='none';
    }
}