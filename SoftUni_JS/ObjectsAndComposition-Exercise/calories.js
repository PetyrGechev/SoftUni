function solve(array){
    let result={};
    for (let index = 0; index < array.length; index+=2) {
       let product=array[index];
       let calories=Number(array[index+1]);
       result[product]=calories;
    }
    console.log(result)
}
solve(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);
//{ Yoghurt: 48, Rise: 138, Apple: 52 }