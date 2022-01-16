function solve (obj){
    result=Object.assign({},obj);
    
    if(result.dizziness){
        let amountToAdd=0.1*obj.experience*obj.weight;
        result.levelOfHydrated+=amountToAdd;
        result.dizziness=false;
    }
    return result;
    
}

console.log(solve({ weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true }
  ))
  /*{ weight: 80,
  experience: 1,
  levelOfHydrated: 8,
  dizziness: false }
  */
