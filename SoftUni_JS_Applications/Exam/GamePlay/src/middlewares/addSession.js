import { getUserData } from "../api/util.js";

export function addSesstion(ctc,next){
    const user= getUserData();

    if(user){
        ctc.user=user;
    }

    next();
}