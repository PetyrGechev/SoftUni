class ArtGallery {
    constructor(creator) {
        this.creator = creator;
        this.possibleArticles = { picture: 200, photo: 50, item: 250 };
        this.listOfArticles = [];
        this.guests = []

    }
    addArticle (articleModel, articleName, quantity ){
        articleModel=articleModel.toLowerCase();
        if(!this.possibleArticles[articleModel]){
            throw new Error("This article model is not included in this gallery!");
        }
        // console.log(this.listOfArticles.some(x=>x.articleName==articleName));
        // console.log(this.listOfArticles.some(x=>x.articleModel==articleModel))

        if((this.listOfArticles.some(x=>x.articleName==articleName)) && (this.listOfArticles.some(x=>x.articleModel==articleModel)) ){
            let article=this.listOfArticles.find(x=>x.articleName==articleName);
            article.quantity+=quantity;
            return `Successfully added article ${articleName} with a new quantity- ${quantity}.`  // !!!!!!!!!!!!!!!! 

        }else{
            let newArticle={articleModel,articleName,quantity};
            this.listOfArticles.push(newArticle);
            return `Successfully added article ${articleName} with a new quantity- ${quantity}.`  // !!!!!!!!!!!!!!!! 

        }

    }
    inviteGuest ( guestName, personality){
        //{guestName, points, purchaseArticle: default 0}.
        if(this.guests.some(x=>x.guestName==guestName)){
            throw new Error(`${guestName} has already been invited.`)
        } 
        let guest={guestName, points:0, purchaseArticle:0}
        if(personality=="Vip"){
            guest.points=500;
        }else if(personality == "Middle"){
            guest.points=250;
        }else{
            guest.points=50;
        }
        this.guests.push(guest);
        return `You have successfully invited ${guestName}!`
    }
    buyArticle ( articleModel, articleName, guestName){
        /////////////////////////// FINDINDEX!!!!!!!!!!!!!!!!!
        let validArtocleModel=articleModel.toLowerCase();
        let articleToFind =this.listOfArticles.find((x=>x.articleName==articleName));

        if(!articleToFind==undefined || articleToFind.articleModel!=validArtocleModel){
            throw new Error("This article is not found.");
        }
        if(articleToFind.quantity==0){
            return `The ${articleName} is not available.`
        }
        if(!this.guests.some(x=>x.guestName==guestName)){
            return(`This guest is not invited.`);
        }
        let theGuest=this.guests.find(x=>x.guestName==guestName);

        let moneyNeeed=this.possibleArticles[articleModel];

        if(moneyNeeed>theGuest.points){
            return `You need to more points to purchase the article.`;
        }
        theGuest.points-=moneyNeeed;
        articleToFind.quantity--;
        theGuest.purchaseArticle++;
        return `${guestName} successfully purchased the article worth ${moneyNeeed} points.`
    }
    showGalleryInfo (criteria){
        if(criteria=='article'){
            let result=[];
            result.push("Articles information:");
            this.listOfArticles.forEach(element => {
                //{articleModel:, articleName:, quantity:}
                result.push(`${element.articleModel} - ${element.articleName} - ${element.quantity}`)
            });
            return result.join("\r\n").trimEnd();
        }else if(criteria=='guest'){
            let result=[];
            result.push("Guests information:");
            this.guests.forEach(element=>{
                result.push(`${element.guestName} - ${element.purchaseArticle}`)
            })
            return result.join("\r\n").trimEnd();
        }
    }


}


const artGallery = new ArtGallery('Curtis Mayfield'); 
artGallery.addArticle('picture', 'Mona Liza', 3);
artGallery.addArticle('Item', 'Ancient vase', 2);
artGallery.addArticle('picture', 'Mona Liza', 1);
artGallery.inviteGuest('John', 'Vip');
artGallery.inviteGuest('Peter', 'Middle');
artGallery.buyArticle('picture', 'Mona Liza', 'John');
artGallery.buyArticle('item', 'Ancient vase', 'Peter');
console.log(artGallery.showGalleryInfo('article'));
console.log(artGallery.showGalleryInfo('guest'));



