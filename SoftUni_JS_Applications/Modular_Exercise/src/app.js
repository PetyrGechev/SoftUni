import page from '../node_modules/page/page.mjs';
import { homeView } from './views/homeView.js';
import { loginView } from './views/loginView.js';
import { registerView } from './views/registerView.js';



page('/', homeView);
page('/login', loginView);

page('/register', registerView);

page('/movies', homeView);

page.start();