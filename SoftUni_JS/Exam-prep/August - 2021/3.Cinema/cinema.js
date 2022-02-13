

const cinema = {
    showMovies: function(movieArr) {

        if (movieArr.length == 0) {
            return 'There are currently no movies to show.';
        } else {
            let result = movieArr.join(', ');
            return result;
        }

    },
    ticketPrice: function(projectionType) {

        const schedule = {
            "Premiere": 12.00,
            "Normal": 7.50,
            "Discount": 5.50
        }
        if (schedule.hasOwnProperty(projectionType)) {
            let price = schedule[projectionType];
            return price;
        } else {
            throw new Error('Invalid projection type.')
        }

    },
    swapSeatsInHall: function(firstPlace, secondPlace) {

        if (!Number.isInteger(firstPlace) || firstPlace <= 0 || firstPlace > 20 ||
            !Number.isInteger(secondPlace) || secondPlace <= 0 || secondPlace > 20 || firstPlace === secondPlace) {
            return "Unsuccessful change of seats in the hall.";
        } else {
            return "Successful change of seats in the hall.";
        }

    }
};

const { equal } = require('assert');
let { expect }= require('chai');
describe("Cinema", function() {
    describe("First", function() {
        it("test empty", function() {
            let movies=[];
            
            expect(cinema.showMovies(movies)).to.equal('There are currently no movies to show.')
            
        });
        it("test mama baba ", function() {
            let movies=['mama','baba'];
            
            expect(cinema.showMovies(movies)).to.equal('mama, baba')
            
        });
        it("test mama baba 22", function() {
            let movies=['mama','baba','22'];
            
            expect(cinema.showMovies(movies)).to.equal('mama, baba, 22')
            
        });
        it("test 2 baba ", function() {
            let movies=['mama','baba'];
            
            expect(cinema.showMovies(movies)).to.not.equal('2, baba')
            
        });
     });
     describe("Second", function() {
        it("test 12.00", function() {
            expect(cinema.ticketPrice("Premiere")).to.be.equal(12.00)
            
        });
        it("test 7.5.00", function() {
            expect(cinema.ticketPrice("Normal")).to.be.equal(7.50)
            
        });
        it("test 7.Discount.00", function() {
            expect(cinema.ticketPrice("Discount")).to.be.equal(5.50)
            
        });
        it("test bad", function() {
            expect(()=>cinema.ticketPrice("Discddount")).to.throw(Error,'Invalid projection type.')
            
        });
     });
     describe("third", function() {
        it("test good", function() {
            expect(cinema.swapSeatsInHall(1,3)).to.be.equal("Successful change of seats in the hall.");
            
        });
        it("test bad", function() {
            expect(cinema.swapSeatsInHall(undefined,3)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad", function() {
            expect(cinema.swapSeatsInHall(2,2.0)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad2", function() {
            expect(cinema.swapSeatsInHall(NaN,3)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad3", function() {
            expect(cinema.swapSeatsInHall('',3)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad4", function() {
            expect(cinema.swapSeatsInHall(null,3)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad5", function() {
            expect(cinema.swapSeatsInHall(1,undefined)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad6", function() {
            expect(cinema.swapSeatsInHall(2,NaN)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad7", function() {
            expect(cinema.swapSeatsInHall(2,``)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad8", function() {
            expect(cinema.swapSeatsInHall(3,null)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad9", function() {
            expect(cinema.swapSeatsInHall(2,-2)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad10", function() {
            expect(cinema.swapSeatsInHall(-3,2)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad11", function() {
            expect(cinema.swapSeatsInHall(2,0)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad12", function() {
            expect(cinema.swapSeatsInHall(0,2)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad13", function() {
            expect(cinema.swapSeatsInHall(2,22)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad14", function() {
            expect(cinema.swapSeatsInHall(22,2)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad146", function() {
            expect(cinema.swapSeatsInHall(2,2)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad1426", function() {
            expect(cinema.swapSeatsInHall(0,0)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad12246", function() {
            expect(cinema.swapSeatsInHall(2.1,2)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad142226", function() {
            expect(cinema.swapSeatsInHall(1,3.2)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad1224622", function() {
            expect(cinema.swapSeatsInHall(true,2)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad14222226", function() {
            expect(cinema.swapSeatsInHall(1,false)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad14222226", function() {
            expect(cinema.swapSeatsInHall(true,true)).to.be.equal("Unsuccessful change of seats in the hall.");
            
        });
        it("test bad14222226", function() {
            expect(cinema.swapSeatsInHall(1.0,2)).to.be.equal("Successful change of seats in the hall.");
            
        });
        it("test bad14222226", function() {
            expect(cinema.swapSeatsInHall(3.0,2)).to.be.equal("Successful change of seats in the hall.");
            
        });
        it("test bad14222226", function() {
            expect(cinema.swapSeatsInHall(20,2)).to.be.equal("Successful change of seats in the hall.");
            
        });
        it("test bad14222226", function() {
            expect(cinema.swapSeatsInHall(2,20)).to.be.equal("Successful change of seats in the hall.");
            
        });
           it("test bad14222226", function() {
            expect(cinema.swapSeatsInHall(1.0,2)).to.be.equal("Successful change of seats in the hall.");
            
        });
        it("test bad14222226", function() {
            expect(cinema.swapSeatsInHall(3.0,2)).to.be.equal("Successful change of seats in the hall.");
            
        });
        
     });
     
    
});
