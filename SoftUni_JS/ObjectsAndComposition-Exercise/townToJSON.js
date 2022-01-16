function solve(array){
    let result=[];
    let splited=array[0].split(' | ').join(' ').split('| ').join(' ').split(' |').join(' ').split(' ');
    splited.pop();
    splited.shift();

    let Town=splited[0];
    let Latitude=splited[1];
    let Longitude=splited[2];


    for (let index = 1; index < array.length; index++) {
        
        let dw=array[index].substring(2, array[index].length-2);
        
        data=dw.split(' | ')
        let town=data[0];
        let latitude=(Math.round(Number(data[1]) * 100) / 100);
        let longitude=(Math.round(Number(data[2]) * 100) / 100);
        
        let townToAdd={
            Town:data[0],
            Latitude:latitude,
            Longitude:longitude
        }
        result.push(townToAdd);
    }
    console.log(JSON.stringify(result))
}

solve(['| Town | Latitude | Longitude |',
       '| Veliko Turnovo | 43.0757 | 25.6172 |',
       '| Monatevideo | 34.50 | 56.11 |']

)

/*[{"Town":"Sofia",
  "Latitude":42.7,
  "Longitude":23.32
},
{"Town":"Beijing", 
 "Latitude":39.91, 
 "Longitude":116.36
}]
*/