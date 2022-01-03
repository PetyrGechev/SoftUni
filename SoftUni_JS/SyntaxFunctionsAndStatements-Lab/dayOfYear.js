function getDate(date,year){
    let theDate= new Date(year, date,0).getDate();
    console.log(theDate);
}
getDate(2, 2021);