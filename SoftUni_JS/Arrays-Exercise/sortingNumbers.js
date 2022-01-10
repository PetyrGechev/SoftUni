function solve(array){
array.sort((a,b)=>a-b);
let result=[];
if (array.length%2==0){
    for (let index = 0; index < array.length/2; index++) {
        result.push(array[index]);
        result.push(array[array.length-1-index]);
    }
}else{
    for (let index = 0; index < array.length/2; index++) {
        result.push(array[index]);
        result.push(array[array.length-1-index]);
    }
    result.pop();
    
}

return result;
}
console.log(solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56, 10]))
