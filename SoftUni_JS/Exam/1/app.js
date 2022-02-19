function solve() {
    
let divNames=document.querySelector('.top-row');
let tBodyElement=document.getElementById('tbody');
let firstNameElement=document.getElementById('fname');
let LastNameElement=document.getElementById('lname')
let emailElement=document.getElementById('email');
let birhDayElement=document.getElementById('birth');
let positionElement=document.getElementById('position');
let salaryElement=document.getElementById('salary');
let hireButton=document.getElementById('add-worker');
let totalSalaryElement=document.getElementById('sum')

hireButton.addEventListener('click',(e)=>{
    e.preventDefault();
    //console.log(firstNameElement.value)
    if (firstNameElement.value==''|| LastNameElement.value==''|| emailElement.value==''||
    birhDayElement.value==''|| positionElement.value=='' || salaryElement.value==''){
        return
    }
    let tdFirstName=document.createElement('td');
    tdFirstName.textContent=firstNameElement.value;

    let tdLastName=document.createElement('td');
    tdLastName.textContent=LastNameElement.value;

    let tdEmail=document.createElement('td');
    tdEmail.textContent=emailElement.value;

    let tdBirthDay=document.createElement('td');
    tdBirthDay.textContent=birhDayElement.value;

    let tdPossition=document.createElement('td');
    tdPossition.textContent=positionElement.value;

    let tdSalary=document.createElement('td');
    tdSalary.textContent=salaryElement.value;

    let btnFired=document.createElement('button');
    btnFired.textContent='Fired';
    btnFired.classList.add('fired');

    let btnEdit=document.createElement('button');
    btnEdit.textContent='Edit';
    btnEdit.classList.add('edit')

    let tdButtons=document.createElement('td');
    tdButtons.appendChild(btnFired);
    tdButtons.appendChild(btnEdit);
    //tdButtons.innerHTML="<button class='fired'>Fired</button> <button class='edit'>Edit</button>";
  

    let trInfo=document.createElement('tr');
    trInfo.appendChild(tdFirstName);
    trInfo.appendChild(tdLastName);
    trInfo.appendChild(tdEmail);
    trInfo.appendChild(tdBirthDay);
    trInfo.appendChild(tdPossition);
    trInfo.appendChild(tdSalary);
    trInfo.appendChild(tdButtons);
    tBodyElement.appendChild(trInfo)

    let salaryLikeNumber=Number(salaryElement.value);
    let totalSalaryElementPrevius=Number(totalSalaryElement.textContent);
    totalSalaryElement.textContent=(salaryLikeNumber+totalSalaryElementPrevius).toFixed(2);

    firstNameElement.value='';
    LastNameElement.value='';
    emailElement.value='';
    birhDayElement.value='';
    positionElement.value='';
    salaryElement.value='';


    btnFired.addEventListener('click',(e)=>{

        let solaryTodeduct=e.target.parentElement.parentElement.children[5];
        solaryTodeduct=Number(solaryTodeduct.textContent);
        let deduction=Number(totalSalaryElement.textContent);
        totalSalaryElement.textContent=(Math.abs(deduction-solaryTodeduct)).toFixed(2);
        e.target.parentElement.parentElement.remove();
    });

    btnEdit.addEventListener('click',(e)=>{

        firstNameElement.value=tdFirstName.textContent;
        LastNameElement.value=tdLastName.textContent;
        emailElement.value=tdEmail.textContent;
        birhDayElement.value=tdBirthDay.textContent;
        positionElement.value=tdPossition.textContent;
        salaryElement.value=tdSalary.textContent;


        let solaryTodeduct=e.target.parentElement.parentElement.children[5];
        solaryTodeduct=Number(solaryTodeduct.textContent);
        let deduction=Number(totalSalaryElement.textContent);
        totalSalaryElement.textContent=(Math.abs(deduction-solaryTodeduct)).toFixed(2);
        e.target.parentElement.parentElement.remove();

    })
    
})






}
solve()