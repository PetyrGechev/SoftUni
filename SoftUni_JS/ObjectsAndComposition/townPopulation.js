function solve(inputArray){
const towns={};
for (const town of inputArray) {
    let[cityName,cityPopulation]=town.split(" <-> ");
    cityPopulation=Number(cityPopulation);
    if(towns[cityName]!=undefined){
        cityPopulation=cityPopulation+towns[cityName];
    }
    towns[cityName]=cityPopulation;
  

}
for (let town in towns) {
    console.log(`${town} : ${towns[town]}`)
}
}
solve(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']
);