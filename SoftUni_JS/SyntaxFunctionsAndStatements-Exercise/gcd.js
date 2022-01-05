//  function gcd(a, b)
//     while b ≠ 0
//         t := b
//         b := a mod b
//         a := t
//     return a

function dcg(num1,num2){

    while(num2!=0) {
        let temp =num2;
        num2=num1%num2;
        num1=temp;
    }
    console.log(num1)
}
dcg(15, 5);