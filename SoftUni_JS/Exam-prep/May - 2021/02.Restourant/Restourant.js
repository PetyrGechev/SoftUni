class Restaurant {
    constructor(budget){
        
        this.budgetMoney=Number(budget) ,
        this.menu={},
        this.stockProducts ={},
        this.history=[]
    }

loadProducts(products){
    
    //"{productName} {productQuantity} {productTotalPrice}","{productName} {productQuantity} {productTotalPrice}"
    products.forEach(element => {
        let splitedProduct=element.split(' ');
        let product=splitedProduct[0];
        let quantity=Number(splitedProduct[1]);
        let price =Number(splitedProduct[2]);
        if (this.budgetMoney>=price){

            if(!this.stockProducts.hasOwnProperty(product)){
                this.stockProducts[product]=quantity;
                this.budgetMoney-=price;
                }else{
                    this.stockProducts[product]+=quantity;
                    this.budgetMoney-=price;
                }
                this.history.push(`Successfully loaded ${quantity} ${product}`) 
        }else{
            this.history.push(`There was not enough money to load ${quantity} ${product}`)
        }
    });
    return this.history.join('\n')
   // let sptlitedProducts=products.split(', ');
}
addToMenu(meal,neededProducts,price){
   
    if(!this.menu[meal]){
        this.menu[meal]={
            products:{},
            price
        }
        neededProducts.forEach(element => {
            //"{productName} {productQuantity}" 
            let [productName , productQuality]=element.split(' ');
            productQuality=Number(productQuality);
            this.menu[meal].products[productName]=productQuality;
         
        });
        if(Object.keys(this.menu).length==1){
            return `Great idea! Now with the ${meal} we have 1 meal in the menu, other ideas?`
        }else{
            return `Great idea! Now with the ${meal} we have ${Object.keys(this.menu).length} meals in the menu, other ideas?`
        }
    }
    else{
        return `The ${meal} is already in the our menu, try something different.`
    }
    

   
   
    //"{productName} {productQuantity}"
}

showTheMenu(){
    if(Object.keys(this.menu)==0){
        return `Our menu is not ready yet, please come later...`
    }
    let result=[];
    for (const meal in this.menu) {
        result.push(`${meal} - $ ${this.menu[meal].price}`)
        
    }
    return result.join('\n')
   
}
makeTheOrder(meal){
    if(!this.menu[meal]){
        return `There is not ${meal} yet in our menu, do you want to order something else?`
    }else{
        for (const product in this.menu[meal].products) {

            if(!this.stockProducts[product] || this.menu[meal].products[product]>this.stockProducts[product]){//.quantity?
                return `For the time being, we cannot complete your order (${meal}), we are very sorry...`
            }
            
        }
        for (const product in this.stockProducts) {
           this.stockProducts[product]-=this.menu[meal].products[product];
        }
        return `Your order (${meal}) will be completed in the next 30 minutes and will cost you ${this.menu[meal].price}.`
    }
}

    
}
// let kitchen = new Restaurant(1000);
// console.log(kitchen.loadProducts(['Banana 10 5', 'Banana 20 10', 'Strawberries 50 30', 'Yogurt 10 10', 'Yogurt 500 1500', 'Honey 5 50']));
// console.log(kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99));
// console.log(kitchen.addToMenu('Pizza', ['Flour 0.5', 'Oil 0.2', 'Yeast 0.5', 'Salt 0.1', 'Sugar 0.1', 'Tomato sauce 0.5', 'Pepperoni 1', 'Cheese 1.5'], 15.55));
// console.log(kitchen.showTheMenu());
let kitchen = new Restaurant(1000);
kitchen.loadProducts(['Yogurt 30 3', 'Honey 50 4', 'Strawberries 30 10', 'Banana 5 1']);
kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 31'], 9.99);
console.log(kitchen.makeTheOrder('frozenYogurt'));
console.log(kitchen.makeTheOrder('putka'));