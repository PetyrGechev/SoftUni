import page from '../node_modules/page/page.mjs'
import { addRender } from './middlewares/render.js';
import { catalogPage } from './view/catalog.js';
import { createPage } from './view/create.js';
import { detailsPage } from './view/details.js';
import { editPage } from './view/edit.js';

import { loginPage } from './view/login.js';
import { registerPage } from './view/register.js';
import {logout} from './api/user.js';


import { addSesstion } from './middlewares/addSession.js';
import { myBooks } from './view/mybooks.js';



page(addSesstion);
page(addRender);


page('/',catalogPage);

page('/login',loginPage);
page('/logout',onLogout);
page('/register',registerPage);
page('/addBook',createPage);
page('/details/:id',detailsPage);
page('/edit/:id',editPage)
page('/myBooks/:id',myBooks)

function onLogout(){
    logout();
    page.redirect('/')
}

page.start()