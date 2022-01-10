function solve(array,number){
    let result=[];
for (let index = 0; index < array.length; index+=number) {
    let element=array[index];
    result.push(element);  

}
return result ;
}
console.log(solve (['5', '20', '31', '4', '20'],2));