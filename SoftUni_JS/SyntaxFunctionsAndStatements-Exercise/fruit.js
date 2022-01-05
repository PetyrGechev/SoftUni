function calc(fruit, weight, price){

    let finalPrice=weight/1000*price;
    let finalWeight=(weight/1000).toFixed(2)
    console.log(`I need $${finalPrice.toFixed(2)} to buy ${finalWeight} kilograms ${fruit}.`);

}
calc('orange', 2500, 1.80);