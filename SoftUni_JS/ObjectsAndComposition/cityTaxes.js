function solve(city,population,treasury){
    let result={
        name: city,
        population:population,
        treasury:treasury,
        taxRate:10,
        collectTaxes() {
            this.treasury+=Math.floor(this.taxRate*this.population);
        },
        applyGrowth(percentage) {
            this.population += Math.floor(this.population*percentage/100);
        },
        applyRecession(percentage){
            this.treasury-=Math.ceil(this.treasury*percentage/100);
        } 
    }
        return result;
    }
    const tortuga=solve('Tortuga',
    7000,
    15000);
    console.log(tortuga)
    tortuga.collectTaxes();
    console.log(tortuga)

