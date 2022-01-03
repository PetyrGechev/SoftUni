function circle(radius) {
    let answer = 0;
    if (typeof radius == 'number') {
        answer=radius**2*Math.PI;
        answer=Math.round((answer * 100))/100;
        console.log(answer);
    }else{
        console.log(`We can not calculate the circle area, because we receive a ${typeof radius}.`)
    }
}
