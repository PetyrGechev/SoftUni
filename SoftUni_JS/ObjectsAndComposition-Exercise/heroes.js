function solve(array){
    let result=[];
    array.forEach(element => {
       let splited=element.split(' / ');
       let splittedLenght=splited.length;

       let level=Number(splited[1]);
       if(splited[2]==''){
        splited.pop();
    }
    
       
       let hero={
           name:splited[0],
           level,
       }
       if(splited.length==2){
           hero.items=[];
       }else{
        let splitedItems=splited[2].split(', ');
        hero.items=splitedItems;
       }
       result.push(hero);

    });
    console.log(JSON.stringify(result));

}

console.log(solve(['Isacc / 25 /',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']
) )

/*[{"name":"Isacc","level":25,"items":["Apple","GravityGun"]},{"name":"Derek","level":12,"items":["BarrelVest","DestructionSword"]},{"name":"Hes","level":1,"items":["Desolator","Sentinel","Antara"]}]*/