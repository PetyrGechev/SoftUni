'using strict'
function solve(numnberOne , numberTwo , operator){
    let result;
    if(operator=='+'){
        result=numnberOne+numberTwo;
    }else if (operator=='-'){
        result=numnberOne-numberTwo;
    }else if (operator=='*'){
        result=numnberOne*numberTwo;
    }else if (operator=='/'){
        result=numnberOne/numberTwo;
    }else if (operator=='%'){
        result=numnberOne%numberTwo;
    }else if (operator=='**'){
        result=numnberOne**numberTwo;
    }
    console.log(result);
}
solve(1,3,'-')