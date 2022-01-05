function sameNum(num){
    let sum=0;
    let numLenght=num.toString().length;
    let numbers=num.toString().split('');
     isSame=true;
    for(let i=0;i<numLenght;i++){
      
        sum+=Number(numbers[i]);
    }
    for(let i=0;i<numLenght-1;i++){
      
       if(numbers[i]!=numbers[i+1]){
           isSame=false
       }
    }

    console.log(isSame);
    console.log(Number(sum));
}
sameNum(2222223);