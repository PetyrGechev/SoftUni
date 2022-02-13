class Story{
   
    _comments;
    _likes
    constructor(title, creator){
        this.title=title;
        this.creator=creator;
        this._comments=[];
        this._likes=[];
        
       
    }
    get likes (){
        let username=this._likes[0];
        if(this._likes.length==0){
           return`${this.title} has 0 likes`;
        }
        else if (this._likes.length==1){
            return `${username} likes this story!`;
        }else{
            return `${username} and ${this.likes.length-1} others like this story!`;
        }

    }
    like (username){
        if(this._likes.includes(username)){
            throw new Error(`You can't like the same story twice!`);
        }
        if(this.creator==username){
            throw new Error(`You can't like your own story!`);
        }
        this._likes.push(username);
        return `${username} liked ${this.title}!`;
       
    }
    dislike (username){
        if(!this._likes.includes(username)){
            throw new Error("You can't dislike this story!");
        }
        this._likes=this._likes.filter(x=>x !== username)
        return `${username} disliked ${this.title}`
        //likes--
    }
    comment (username, content, id){
        
        if(!id===undefined || !this._comments.some(x=>x.Id==id)){

            let userComment={
                Id:this._comments.length+1,
                Username:username,
                Content:content,
                Replies:[]
            }
            this.firstLike++;
            this._comments.push(userComment);
            return `${username} commented on ${this.title}`;

        }
        let commentToReplay=this._comments.find(x=>x.Id==id);
        let replayId=Number(`${commentToReplay.Id}.${commentToReplay.Replies.length+1}`);
        let replay={
            Id:replayId,
            Username:username,
            Content:content
        }
        commentToReplay.Replies.push(replay)
        return `You replied successfully`;
       
    }
    toString(sortingType){
       const sortingStrategy={
           asc: (a,b)=> a.Id - b.Id,
           desc: (a,b)=> b.Id- a.Id,
           username: (a,b)=> a.Username.localeCompare(b.Username)
       }
       let commentsArrey=[];
       let comments=this._comments.sort(sortingStrategy[sortingType]);
       comments.forEach(c=>c.Replies.sort(sortingStrategy[sortingType]))
       for (const comment of comments) {
           let commentString=`-- ${comment.Id}. ${comment.Username}: ${comment.Content}`;
           let replaysString=comment.Replies.map(r=>`--- ${r.Id}. ${r.Username}: ${r.Content}`).join('\n');
           replaysString = comment.Replies.length > 0
                ? `\n${replaysString}`
                : '';
           let finalString=`${commentString}\n${replaysString}`;
           commentsArrey.push(finalString);
           
       }
       let finalCommentsArrey=`\n${commentsArrey.join('\n')}`;
       let result=`Title: ${this.title}
Creator: ${this.creator}
Likes: ${this._likes.length}
 Comments: ${finalCommentsArrey}`;
       return result;
    }   

}
let art = new Story("My Story", "Anny");
art.like("John");
console.log(art.likes);
art.dislike("John");
console.log(art.likes);
art.comment("Sammy", "Some Content");
console.log(art.comment("Ammy", "New Content"));
art.comment("Zane", "Reply", 1);
art.comment("Jessy", "Nice :)");
console.log(art.comment("SAmmy", "Reply@", 1));
console.log()
console.log(art.toString('username'));
console.log()
art.like("Zane");
console.log(art.toString('desc'));

