
   function solve() {
      document.querySelector('#btnSend').addEventListener('click', onClick);
   
      function onClick() {

         let bestRestorantResult=document.querySelector('#bestRestaurant>p');
         let bestTeamResult=document.querySelector('#workers>p');
 

         let restorants = [];
         let bestAvarage=0;
         let arr = JSON.parse(document.querySelector('#inputs textarea').value);
   
         for (let i = 0; i < arr.length; i++) {
   
            
            let splited = arr[i].split(" - ");
            let restorantName = splited[0];
   
   
            let restorant = {
               Name: restorantName
            }
   
   
            let array = splited[1].split(", ");
            let restorantSum = 0;
   
            let priPancho = restorants.find(rest => rest.Name == restorantName);
            if (typeof priPancho !== "undefined") {
               let tempsum=0
               for (let j = 0; j < array.length; j++) {
                 
   
                  let splitedArray = array[j].split(" ");
                  let nameWorker = splitedArray[0];
                  let salary = Number(splitedArray[1]);
                  priPancho[nameWorker] = salary;
                  tempsum+=salary;
   
               }
               let avarageTempSum=tempsum/array.length;
               priPancho.avarageSalary=(avarageTempSum+priPancho.avarageSalary)/2;
               if(priPancho.avarageSalary>bestAvarage){
                  bestAvarage=priPancho.avarageSalary;
               }
              
            }
            else {
               for (let j = 0; j < array.length; j++) {
                 
   
                  let splitedArray = array[j].split(" ");
                  let nameWorker = splitedArray[0];
                  let salary = Number(splitedArray[1]);
                  restorant[nameWorker] = salary;
                  restorantSum += salary;
   
   
               }
               let avarageSalaty = restorantSum / array.length;
   
               restorant.avarageSalary = avarageSalaty;
               restorants.push(restorant);
               if(restorant.avarageSalary>bestAvarage){
                  bestAvarage=restorant.avarageSalary;
               }
            }
            
         }
         bestAvarage=0;
         let values=Object.values(restorants);
         values.forEach(element => {
           if(element.avarageSalary>bestAvarage){
              bestAvarage=element.avarageSalary;
           }
         });
         let bestRestorant=restorants.find(rest => rest.avarageSalary == bestAvarage);

         let topWages=0
         let salaries=Object.values(bestRestorant)
         salaries.forEach(element => {
            if(element>topWages){
               topWages=element;
            }
         });

         bestRestorantResult.textContent=`Name: ${bestRestorant.Name} Average Salary: ${bestRestorant.avarageSalary.toFixed(2)} Best Salary: ${topWages.toFixed(2)}`;
         
         delete bestRestorant.avarageSalary;
         delete bestRestorant.Name;
         let people=Object.entries(bestRestorant);
         let theResult="";
         people.forEach(element => {
            theResult+= `Name: ${element[0]} With Salary: ${element[1]} `
         });
         
         bestTeamResult.textContent=theResult;
        

   };



}

