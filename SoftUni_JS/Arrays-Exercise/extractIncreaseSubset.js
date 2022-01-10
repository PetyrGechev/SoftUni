function solve(array){
    let result=[];
    let minNum=-9999999999999999;
    for (let index = 0; index < array.length; index++) {
       if (array[index]>=minNum){
           minNum=array[index];
           result.push(array[index]);
       }
        
    }
    console.log(result.join( ))
}

solve([20, 
    3, 
    2, 
    15,
    6, 
    1]
     );