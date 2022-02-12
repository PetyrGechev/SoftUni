class ArtGallery {
    constructor(creator) {
        this.creator = creator,
        possibleArticles = { picture: 200, photo: 50, item: 250 }
        listOfArticles = [] //{articleModel:, articleName:, quantity:}
        guests = []//{guestName, points, purchaseArticle: 0}. 


    }
    addArticle (articleModel, articleName, quantity ){
        let ValidatedArticleModel=articleModel.toLowerCase();
        if(!possibleArticles[ValidatedArticleModel]){
            throw new Error("This article model is not included in this gallery!");
        }
        if(this.listOfArticles.some((x=>x.articleName==articleName) && (m=>m.articleModel==ValidatedArticleModel))){
            let article=this.listOfArticles.find(x=>x.articleName==articleName);
            article.quantity+=quantity;
            return `Successfully added article ${articleName} with a new quantity- ${quantity}.`  // !!!!!!!!!!!!!!!! 

        }else{
            let newArticle={ValidatedArticleModel,articleName,quantity};
            listOfArticles.push(newArticle);
            return `Successfully added article ${articleName} with a new quantity- ${quantity}.`  // !!!!!!!!!!!!!!!! 

        }

    }
    inviteGuest ( guestName, personality){
        //{guestName, points, purchaseArticle: default 0}.
        if(this.guests.some(x=>x.guestName==guestName)){
            throw new Error(`${guestName} has already been invited.`)
        } 
        let guest={guestName, points, purchaseArticle:0}
        if(personality=="Vip"){
            guest.points=500;
        }else if(personality == "Middle"){
            guest.points=250;
        }else{
            guest.points=50;
        }
        return `You have successfully invited ${guestName}!`
    }
    buyArticle ( articleModel, articleName, guestName){
        let articleToFind =listOfArticles.findIndex(x=>x.articleName==articleName);
        let validArtocleModel=articleModel.toLowerCase();
        if(!articleToFind==-1 || articleToFind.articleModel!=articleModel)
    }


}