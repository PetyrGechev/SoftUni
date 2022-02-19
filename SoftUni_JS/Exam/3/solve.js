const flowerShop = {
    calcPriceOfFlowers(flower, price, quantity) {
        if (typeof flower != 'string' || !Number.isInteger(price) || !Number.isInteger(quantity)) {
            throw new Error('Invalid input!');
        } else {
            let result = price * quantity;
            return `You need $${result.toFixed(2)} to buy ${flower}!`;
        }
    },
    checkFlowersAvailable(flower, gardenArr) {
        if (gardenArr.indexOf(flower) >= 0) {
            return `The ${flower} are available!`;
        } else {
            return `The ${flower} are sold! You need to purchase more!`;
        }
    },
    sellFlowers(gardenArr, space) {
        let shop = [];
        let i = 0;
        if (!Array.isArray(gardenArr) || !Number.isInteger(space) || space < 0 || space >= gardenArr.length) {
            throw new Error('Invalid input!');
        } else {
            while (gardenArr.length > i) {
                if (i != space) {
                    shop.push(gardenArr[i]);
                }
                i++
            }
        }
        return shop.join(' / ');
    }
}






const {expect}=require ('chai');


describe("flowerShop", ()=>{
    describe("calcPriceOfFlowers", ()=> {

        it("good", ()=> { expect(flowerShop.calcPriceOfFlowers('lale',5,10)).to.equal(`You need $50.00 to buy lale!`);});
      
        it("good2", ()=> {expect(flowerShop.calcPriceOfFlowers('lale',0,10)).to.equal(`You need $0.00 to buy lale!`);});
      

        it("bad1", ()=> {expect(()=>flowerShop.calcPriceOfFlowers('lale',undefined,10)).to.throw(Error,`Invalid input!`);});
      
        it("bad2", ()=> {expect(()=>flowerShop.calcPriceOfFlowers('lale',NaN,10)).to.throw(Error,`Invalid input!`);});
        
        it("bad2", ()=> {expect(()=>flowerShop.calcPriceOfFlowers('lale',null,10)).to.throw(Error,`Invalid input!`);});
        it("bad3", ()=> {expect(()=>flowerShop.calcPriceOfFlowers('lale',true,10)).to.throw(Error,`Invalid input!`);});
        it("bad3", ()=> {expect(()=>flowerShop.calcPriceOfFlowers('lale',12,null)).to.throw(Error,`Invalid input!`);});
       
        it("bad4", ()=> { expect(()=>flowerShop.calcPriceOfFlowers('lale',false,10)).to.throw(Error,`Invalid input!`);});
    
        it("bad5", ()=> { expect(()=>flowerShop.calcPriceOfFlowers('lale',2.2,10)).to.throw(Error,`Invalid input!`);});
        
        it("bad5", ()=> {expect(()=>flowerShop.calcPriceOfFlowers('lale','dada',10)).to.throw(Error,`Invalid input!`);});
        
        it("bad6", ()=> {expect(()=>flowerShop.calcPriceOfFlowers('lale',10,undefined)).to.throw(Error,`Invalid input!`);});
        
        it("bad7", ()=> {expect(()=>flowerShop.calcPriceOfFlowers('lale',10,NaN)).to.throw(Error,`Invalid input!`);});
        
        it("bad8", ()=> {expect(()=>flowerShop.calcPriceOfFlowers('lale',10,true)).to.throw(Error,`Invalid input!`);});
        
        it("bad9", ()=> {expect(()=>flowerShop.calcPriceOfFlowers('lale',10,false)).to.throw(Error,`Invalid input!`);});
        
        it("bad10", ()=> {expect(()=>flowerShop.calcPriceOfFlowers('lale',12,1.20)).to.throw(Error,`Invalid input!`);});

        it("bad11", ()=> {expect(()=>flowerShop.calcPriceOfFlowers('lale',12,`1.20`)).to.throw(Error,`Invalid input!`);});
        
        //null 
        
        
        
        // it("samo s pesho", ()=> {});
        // expect(()=>kur.ebise('pesh')).to.throw(Error,'ne stava')
        
    });
    describe("checkFlowersAvailable", ()=> {

        it("good", ()=> {expect(flowerShop.checkFlowersAvailable('lale',['lale','roza'])).to.equal(`The lale are available!`);});
        
        it("good1", ()=> {expect(flowerShop.checkFlowersAvailable('',['','roza'])).to.equal(`The  are available!`);});
        
        it("good2", ()=> {expect(flowerShop.checkFlowersAvailable(1,[1,'roza'])).to.equal(`The 1 are available!`);});
        

        it("bad1", ()=> {expect(flowerShop.checkFlowersAvailable('lale',['',''])).to.equal(`The lale are sold! You need to purchase more!`);});
        it("bad2", ()=> {expect(flowerShop.checkFlowersAvailable('lale',['1','212',2])).to.equal(`The lale are sold! You need to purchase more!`);});
        it("bad3", ()=> {expect(flowerShop.checkFlowersAvailable('',['22','212',2])).to.equal(`The  are sold! You need to purchase more!`);});
        it("bad4", ()=> {expect(flowerShop.checkFlowersAvailable(1,['22','212',2])).to.equal(`The 1 are sold! You need to purchase more!`);});
        
        
        // it("samo s pesho", ()=> {});
        // expect(()=>kur.ebise('pesh')).to.throw(Error,'ne stava')
        
    });
    describe("sellFlowers", ()=> {

        it("good", ()=> {expect(flowerShop.sellFlowers(['lale' , 'roza'],1)).to.equal(`lale`);});
        it("good2", ()=> {expect(flowerShop.sellFlowers(['lale','roza',`roza`],2)).to.equal(`lale / roza`);});

        it("bad1", ()=> {()=>expect(flowerShop.sellFlowers(['lale','roza',`roza`],3)).to.throw(Error,`Invalid input!`);});
        it("bad2", ()=> {()=>expect(flowerShop.sellFlowers(['lale','roza',`roza`],5)).to.throw(Error,`Invalid input!`);});
        it("bad3", ()=> {()=>expect(flowerShop.sellFlowers(['lale','roza',`roza`],-3)).to.throw(Error,`Invalid input!`);});

        it("bad4", ()=> {()=>expect(flowerShop.sellFlowers('dada',3)).to.throw(Error,`Invalid input!`);});
        it("bad5", ()=> {()=>expect(flowerShop.sellFlowers(1,3)).to.throw(Error,`Invalid input!`);});

        it("bad6", ()=> {()=>expect(flowerShop.sellFlowers(['lale','roza',`roza`],'')).to.throw(Error,`Invalid input!`);});
        it("bad7", ()=> {()=>expect(flowerShop.sellFlowers(['lale','roza',`roza`],'dada')).to.throw(Error,`Invalid input!`);});

        it("bad8", ()=> {()=>expect(flowerShop.sellFlowers(['lale','roza',`roza`],undefined)).to.throw(Error,`Invalid input!`);});
        it("bad9", ()=> {()=>expect(flowerShop.sellFlowers(['lale','roza',`roza`],null)).to.throw(Error,`Invalid input!`);});

        it("bad10", ()=> {()=>expect(flowerShop.sellFlowers(['lale','roza',`roza`],[])).to.throw(Error,`Invalid input!`);});
        it("bad11", ()=> {()=>expect(flowerShop.sellFlowers(['lale','roza',`roza`],{})).to.throw(Error,`Invalid input!`);});

        it("bad8", ()=> {()=>expect(flowerShop.sellFlowers(['lale','roza',`roza`],-2)).to.throw(Error,`Invalid input!`);});
        it("bad9", ()=> {()=>expect(flowerShop.sellFlowers(['lale','roza',`roza`],3)).to.throw(Error,`Invalid input!`);});

        
      
        
        
        // it("samo s pesho", ()=> {});
        // expect(()=>kur.ebise('pesh')).to.throw(Error,'ne stava')
        
    });

});
