function solve(arr){
    let result={};
    for (const item of arr) {
        splitedItem=item.split(' | ');
        let splitedTown=splitedItem[0];
        let splitedProduct=splitedItem[1];
        let splitedPrice=Number(splitedItem[2]);
        if(!result[splitedProduct]){
            result[splitedProduct]={};
        }
        result[splitedProduct][splitedTown]=splitedPrice;
        
    }
    for (const product in result) {
        const sorted=Object.entries(result[product]).sort((a,b)=>a[1]-b[1]);
        console.log(`${product} -> ${sorted[0][1]} (${sorted[0][0]})`)
      
    }
    //Sample Product -> 1000 (Sample Town)
    
}

solve([ 'Sample Town | Sample Product | 1000',
        'Sample Town | Orange | 2',
        'Sample Town | Peach | 1',
        'Sofia | Orange | 3',
        'Sofia | Peach | 2',
        'New York | Sample Product | 1000.1',
        'New York | Burger | 10']
);