function solve(obj){
    let result={};
    result['model']=obj.model;
    result.engine=getVolumeSize(obj.power);
    result.carriage={ type: obj.carriage, color: obj.color }
    let properWheelSize=obj.wheelsize%2==0?obj.wheelsize-1:obj.wheelsize;
    result.wheels=new Array(4).fill(properWheelSize,0,4);;
    function getVolumeSize(power){
        if(power<=90){
            return {power,volume:1800 }
        }else if (power<120){
            return {power,volume:2400 }
        }else{
            return {power,volume:3500 }
        }
    }
    return function solve(obj){
    let result={};
    result['model']=obj.model;
    result.engine=getVolumeSize(obj.power);
    result.carriage={ type: obj.carriage, color: obj.color }
    let properWheelSize=obj.wheelsize%2==0?obj.wheelsize-1:obj.wheelsize;
    result.wheels=new Array(4).fill(properWheelSize,0,4);;
    function getVolumeSize(power){
        if(power<=90){
            return {power,volume:1800 }
        }else if (power<120){
            return {power,volume:2400 }
        }else{
            return {power,volume:3500 }
        }
    }
    console.log(result)
};
}


solve({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 }
);
