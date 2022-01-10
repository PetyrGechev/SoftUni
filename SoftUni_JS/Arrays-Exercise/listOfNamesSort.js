function solve(array){
    array.sort((a,b)=>a.localeCompare(b));
    let index=1;
 for (const item of array) {
     console.log(`${index++}.${item}`)
 }

}
solve(["John", "Bob", "Christina", "Ema"]);