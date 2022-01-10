function solve(arrey,rotation){
    for (let index = 0; index < rotation; index++) {
        arrey.unshift(arrey.pop());
       
    }
    console.log(arrey.join(' '));
}
solve (['1', 
'2', 
'3', 
'4'], 
2
);