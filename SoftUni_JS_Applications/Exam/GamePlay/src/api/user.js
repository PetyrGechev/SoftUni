import * as api from './api.js'
import { clearUserData, setUserData } from './util.js'

const endpoints={
    login:'/users/login',
    logout:'/users/logout',
    register:'/users/register'
}

export async function login(email,password){
 const result= await api.post(endpoints.login,{email,password})
 setUserData(result);
 return result;
}

export async function register(email,password){
    const result= await api.post(endpoints.register,{email,password})
    setUserData(result);
    return result; 
}

export async function logout(){
    api.get(endpoints.logout);
    clearUserData();
}