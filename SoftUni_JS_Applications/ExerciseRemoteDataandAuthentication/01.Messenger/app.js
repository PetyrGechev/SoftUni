function attachEvents() {
   const refreshBtn=document.getElementById('refresh');
   refreshBtn.addEventListener('click', getMessages)

}

async function getMessages(ev){

    const res= await fetch('http://localhost:3030/jsonstore/messenger');
    const data=await res.json();

    console.log(Object.values(data))

}


attachEvents();