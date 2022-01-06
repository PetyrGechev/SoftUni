function cook(number,operation1,operation2,operation3,operation4,operation5){
   const arr=[] ;
   arr.push(operation1,operation2,operation3,operation4,operation5);
   console.log(arr)
   for (let index = 0; index < arr.length; index++) {
       
       let operation=arr[index];
       switch(operation){
           case 'chop':
               number=number/2;
               console.log(number);
               break;
            case 'spice':
                number=number+1;
                console.log(number);
                break;
            case 'dice':
                number=Math.sqrt(number);
                console.log(number);
                break;
            case 'bake':
                number=number*3;
                console.log(number);
                break;    
            case 'fillet':
                number=number*0.8;
                console.log(number);
                break;
       }
   }
}
cook('9', 'dice', 'spice', 'chop', 'bake', 'fillet');