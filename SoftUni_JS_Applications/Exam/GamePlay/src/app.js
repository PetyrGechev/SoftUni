import page from '../node_modules/page/page.mjs'
import { addRender } from './middlewares/render.js';
import { catalogPage } from './view/catalog.js';
import { createPage } from './view/create.js';
import { detailsPage } from './view/details.js';
import { editPage } from './view/edit.js';
import { homePage } from './view/home.js';
import { loginPage } from './view/login.js';
import { registerPage } from './view/register.js';
import {logout} from './api/user.js';

 import * as api from './api/user.js';
import { addSesstion } from './middlewares/addSession.js';

window.api=api;

page(addSesstion);
page(addRender);


page('/',homePage);
page('/catalog',catalogPage);
page('/login',loginPage);
page('/logout',onLogout);
page('/register',registerPage);
page('/create',createPage);
page('/details/:id',detailsPage);
page('/edit/:id',editPage)

function onLogout(){
    logout();
    page.redirect('/')
}

page.start()