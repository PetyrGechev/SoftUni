function aggregate(...params){
    let sum=0;
    let sum2=0;
    let concaf='';
    for(let i =0 ; i <params.length;i++){
        sum+=Number(params[i]);
    }
    for(let i =0 ; i <params.length;i++){
        sum2+=Number(1/params[i]);
    }
    for(let i =0 ; i <params.length;i++){
          concaf+=params[i]
      }
    console.log(sum);
    console.log(sum2.toFixed(4));
    console.log(concaf);

}
aggregate(2, 4, 8, 16);