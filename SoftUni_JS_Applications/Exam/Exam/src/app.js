import page from '../node_modules/page/page.mjs';
import { homePage } from './view/home.js';
 import { addSesstion } from './middlewares/addSession.js';
import { addRender } from './middlewares/render.js';
import { dashboardPage } from './view/dashboard.js';

 import { loginPage } from './view/login.js';
 import {logout} from './api/user.js';
 import { registerPage } from './view/register.js';
// import { myProfile } from './view/profile.js';
 import { createPage } from './view/create.js';
 import { detailsPage } from './view/details.js';
import { editPage } from './view/edit.js';

 page(addSesstion)
 page(addRender)
 page('/',homePage)
 page('/dashboard',dashboardPage)
 page('/login',loginPage)
 page('/logout',onLogout);
 page('/register',registerPage)
// page('/profile',myProfile)
 page('/create',createPage)
 page('/details/:id',detailsPage);
page('/edit/:id',editPage)
 page.start();

function onLogout(){
    logout();
    page.redirect('/')
}