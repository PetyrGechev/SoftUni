function magic(matrix){

    let checkSum=0;
    for (let index = 0; index < matrix[0].length; index++) {
       
        checkSum+=matrix[0][index];
    }
    for (let row = 0; row < matrix.length; row++) {
        let sum=0;
        for (let index = 0; index < matrix[0].length; index++) {
       
            sum+=matrix[row][index];
        }
       if(checkSum!=sum){
           return false;
       }
        
    }


    for (let col = 0; col < matrix.length; col++) {
        let sum=0;
        for (let index = 0; index < matrix[0].length; index++) {
       
            sum+=matrix[index][col];
        }
       if(checkSum!=sum){
           return false;
       }
        
    }

   return true;



}

console.log(magic([[11, 32, 45],
                   [21, 0, 1],
                   [21, 1, 1]]
   
   
));