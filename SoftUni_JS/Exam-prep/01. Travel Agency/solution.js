window.addEventListener('load', solution);

function solution() { 
  
   let block=document.getElementById('block')

   let submitBtn=document.getElementById('submitBTN');
   let editBTN=document.getElementById('editBTN');
   let continueBTN=document.getElementById('continueBTN');

   let phoneNumnerAvable=false;
   let addressAvaible=false;
   let postCodeAvaible=false;

   submitBtn.addEventListener('click',(e)=>{
    e.preventDefault();
    let fullNameElement=document.getElementById('fname');
    let emailElement=document.getElementById('email');
    let phoneNumberElement=document.getElementById('phone');
    let addressElement=document.getElementById('address');
    let postCodeElement=document.getElementById('code');

    if(fullNameElement.value=='' || emailElement.value==''){
      return;
    }
    
    let infoPreview=document.getElementById('infoPreview');
    
    let  fullNamePreviewElement= document.createElement('li');
    fullNamePreviewElement.textContent=(`Full Name: ${fullNameElement.value}`)
    console.log(fullNamePreviewElement.textContent)

    infoPreview.appendChild(fullNamePreviewElement);

    let emailPreviewElement=document.createElement('li');
    emailPreviewElement.textContent=(`Email: ${emailElement.value}`)

    infoPreview.appendChild(emailPreviewElement);
    let phoneNumberPreviewElement=document.createElement('li');
    let addressPreviewElement=document.createElement('li');
    let postCodePreviewElemenet=document.createElement('li');

    if(!phoneNumberElement.value==''){

     
      phoneNumberPreviewElement.textContent=(`Phone Number: ${phoneNumberElement.value}`)
      infoPreview.appendChild(phoneNumberPreviewElement);
      phoneNumnerAvable=true;
    }
    if(!addressElement.value==''){
      addressPreviewElement.textContent=(`Address: ${addressElement.value}`)
      infoPreview.appendChild(addressPreviewElement);
      addressAvaible=true;
    }
    if(!postCodeElement.value==''){
      postCodePreviewElemenet.textContent=(`Postal Code: ${postCodeElement.value}`)
      infoPreview.appendChild(postCodePreviewElemenet);
      postCodeAvaible=true;
    }
    submitBtn.disabled=true;
    fullNameElement.value='' ;
    emailElement.value='' ;
    phoneNumberElement.value='' ;
    addressElement.value='' ;
    postCodeElement.value='' ;

     editBTN.disabled=false;
     continueBTN.disabled=false;

    editBTN.addEventListener('click',(e)=>{
      fullNameElement.value=fullNamePreviewElement.textContent.slice(11);
      emailElement.value=emailPreviewElement.textContent.slice(7);
      infoPreview.removeChild(fullNamePreviewElement);
      infoPreview.removeChild(emailPreviewElement);
      if(phoneNumnerAvable==true){
        let numberToGoBack=phoneNumberPreviewElement.textContent.slice(14);
        phoneNumberElement.value=numberToGoBack;
        infoPreview.removeChild(phoneNumberPreviewElement);

      }
      if(addressAvaible==true){
        let  addressToGoBack=addressPreviewElement.textContent.slice(9)
        addressElement.value=addressToGoBack;
        infoPreview.removeChild(addressPreviewElement);
      }
      if(postCodeAvaible==true){

        let postCodeToGoBack= postCodePreviewElemenet.textContent.slice(13);
        postCodeElement.value=postCodeToGoBack;
        infoPreview.removeChild(postCodePreviewElemenet);
      
      }
      submitBtn.disabled=false;
      editBTN.disabled=true;
      continueBTN.disabled=true;

    })
    
    continueBTN.addEventListener('click',(e)=>{
    block.innerHTML='';
    let h3= document.createElement('h3');
    h3.textContent='Thank you for your reservation!'
    block.appendChild(h3);

    })

  
   })

  
 // “Full Name” and “Email” input fields are not empty.   !!!!!!!

}
