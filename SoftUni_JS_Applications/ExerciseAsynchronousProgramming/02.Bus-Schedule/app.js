function solve() {
    const showBoxElement=document.getElementById('info');
    const departBtn=document.getElementById('depart');
    const ArriveBtn=document.getElementById(`arrive`)
    let busStop= {  
        next: "depot"
      }
      
    async function depart(e) {
        //get information for next stop
        //display name of next stop
        departBtn.disabled=true;
        const url=`http://localhost:3030/jsonstore/bus/schedule/${busStop.next}`;

        const res = await fetch(url);
        const data = await res.json();
        showBoxElement.textContent=`Next stop ${data.name}`
        departBtn.disabled=true;
        ArriveBtn.disabled=false;
        busStop.next=data.next;
        busStop['name']=data.name;
       
        //swap active buttons
      
    }

    function arrive() {
        //display name of current stop
        //swap active buttons
        showBoxElement.textContent=`Arriving at  ${busStop.name}`
        departBtn.disabled=false;
        ArriveBtn.disabled=true;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();