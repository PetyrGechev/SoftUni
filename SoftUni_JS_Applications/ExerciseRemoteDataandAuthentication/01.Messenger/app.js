function attachEvents() {
 
   const refreshBtn=document.getElementById('refresh');
   const sendBtn=document.getElementById('submit');
   refreshBtn.addEventListener('click', getMessages);
   sendBtn.addEventListener('click',sendMassage)

}
const meseegesAreaElement=document.getElementById('messages');
async function getMessages(ev){
    

    const res= await fetch('http://localhost:3030/jsonstore/messenger');
    const data=await res.json();

 
    const inputData=Object.values(data);
    const inputDataAsSting=inputData.map(x=>`${x.author}: ${x.content}`).join('\n');

    meseegesAreaElement.value=inputDataAsSting;

}

async function sendMassage(ev){
    const authorElement=document.querySelector('[name="author"]');
    const contentElement=document.querySelector('[name="content"]')

    const message={
        author: authorElement.value,
        content: contentElement.value,
    }


    const options={
        method: 'post',
        headers:{
            'Content-Type':'application/json'
        },
        body: JSON.stringify(message)
        
    }

    const res=await fetch('http://localhost:3030/jsonstore/messenger',options);
    const result=await res.json();
    contentElement.value='';
    //meseegesAreaElement.value+=`\n${result.author}: ${result.content}`;
   
    
    // {
    //  author: authorName,
    //  content: msgText,
    // }

}

attachEvents();