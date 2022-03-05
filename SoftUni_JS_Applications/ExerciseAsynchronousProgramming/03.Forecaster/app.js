function attachEvents() {
    const locationInput =  document.querySelector('#request #location'); 
    const foreCastElement=document.getElementById("forecast")
    const submitBtn=document.getElementById("submit");
    submitBtn.addEventListener('click', onSubmit);

    const allSpans=Array.from(document.getElementsByTagName("SPAN"));
    console.log(allSpans)
    const symbolSpanElement=allSpans[0];
    const nameSpanElement=allSpans[2];
    const tempSpanElement=allSpans[3];
    const conditionSpanElement=allSpans[4];
    

    let locationObj={
        code:"",
        name:""
    };



    async function onSubmit(){

        const res= await fetch("http://localhost:3030/jsonstore/forecaster/locations");
        const data=await res.json();

        
        
        const cityInfo=data.find(x=>x.name==locationInput.value)
        locationObj.code=cityInfo.code;
        locationObj.name=cityInfo.name;
        console.log(locationObj)    
        const cityCode=locationObj.code;
        console.log(cityCode);
        const todayRes= await fetch(`http://localhost:3030/jsonstore/forecaster/today/${cityCode}`);
        const todayData=await todayRes.json();
        
        const symbol= checkForIcon(todayData.condition)
        symbolSpanElement.innerHTML=symbol;
        nameSpanElement.textContent=todayData.name;
        tempSpanElement.innerHTML=`${todayData.forecast.low}&#176/${todayData.forecast.high}&#176`;
        conditionSpanElement.textContent=todayData.forecast.condition;
        foreCastElement.style.display='block';

      
       console.log(todayData.name)
    }

    function checkForIcon(condtion){
        if(condtion="Sunny"){
            return "&#x2600"
        }
        if(condtion="Partly sunny"){
            return "&#x26C5"
        }
        if(condtion="Overcast"){
            return "&#x2601"
        }
        if(condtion="Rain"){
            return "&#x2614"
        }
    
    }
    //
    // Didnt finish the whole task ... Too much time consuming DOM operations ... all the same...
    //

}

attachEvents();