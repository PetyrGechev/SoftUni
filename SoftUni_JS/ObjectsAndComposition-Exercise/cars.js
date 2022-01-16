function solve(obj){
    let result={};
    result.model=obj.model;
    result.engine=getVolumeSize(obj.power);
    result.carriage={ type: obj.carriage, color: obj.color }
    let properWheelSize=obj.wheelsize%2==0?obj.wheelsize-1:obj.wheelsize;
    result.wheels=new Array(4).fill(properWheelSize,0,4);;
    function getVolumeSize(power){
        if(power<=90){
            return {power:90,volume:1800 }
        }else if (power<120){
            return {power:120,volume:2400 }
        }else{
            return {power:200,volume:3500 }
        }
    }

    return result;
}


solve({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 }
);