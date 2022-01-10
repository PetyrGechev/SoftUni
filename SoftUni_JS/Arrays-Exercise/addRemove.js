function solve(array){
let result=[];
for (let index = 0; index < array.length; index++) {

   let command=array[index];
   if(command=='add'){
        result.push(index+1);
   }
   else{
       result.pop()
   }

}
if(result.length==0){
    console.log('Empty');
    
}else{
console.log(result.join("\r\n"));}

}
solve(['add', 
'add', 
'add', 
'add']
);

solve(['add', 
'add', 
'remove', 
'add', 
'add']
)