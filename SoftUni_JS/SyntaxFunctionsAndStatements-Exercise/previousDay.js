function pD(year, month, day){
    let date2=new Date(year,month,day)
    if(date2.getMonth()==10)
    {
        date2.setDate(date2.getDate()-2);
    }
    else{
        date2.setDate(date2.getDate()-1);
    }

console.log(`${date2.getFullYear()}-${date2.getMonth()}-${date2.getDate()}`);
}
pD(2016, 9, 30);
pD(2016, 10, 1);