function solve(array){
    let result={};
    //A:{Appricot:20.4 , t.n.}
    array.forEach(element => {
        [product,price]=element.split(' : ')
        let firstLetter=product[0];
       
        if(!result[firstLetter]){
            result[firstLetter]={};
        }
        result[firstLetter][product]=Number(price);
    });
    
    let initialsort=Object.keys(result).sort((a,b)=>a.localeCompare(b));
    for (const key of initialsort) {
        let products=Object.entries(result[key]).sort((a,b)=>a[0].localeCompare(b[0]));
        console.log(key);
        products.forEach(element => {
            console.log(`  ${element[0]}: ${element[1]}`);
        });
    }
    


}
solve(['Appricot : 20.4','Fridge : 1500','TV : 1499','Deodorant : 10','Boiler : 300','Apple : 1.25','Anti-Bug Spray : 15','T-Shirt : 10']
)

