import * as Components from './compile-components.js';
import * as Routes from './router.js';
import * as HttpClient from './http-client.service.js';

let isHome = true;
let formOnPage;
let topic = document.getElementsByClassName('topic-container')[0];
let MutationObserver = window.MutationObserver;
let isPostLoad = false;
let isCommentsLoad = false;
let id;

let observer = new MutationObserver(() => {

    topic = document.getElementsByClassName('topic-container')[0];

    isHome = window.location.pathname.includes('index') ? true : false;

    if (!isPostLoad && isHome) {

        load();

        isPostLoad = true;

    }

    if (!isCommentsLoad && !isHome) {

        loadTopicHeader();
        loadComm();

        isCommentsLoad = true;

    }

    formOnPage = getForm();

});

observer.observe(document, {
    subtree: true,
    attributes: true,
    childList: true,
    characterData: true
});

window.onload = async (ev) => {

    if (!isPostLoad) {

        load();

        isPostLoad = true;

    }

    formOnPage = getForm();

    document.getElementById('anchor-home').addEventListener('click', () => {

        navigateToHome();

        isPostLoad = false;

    });

    document.getElementsByClassName('cancel')[0].addEventListener('click', () => formOnPage.reset())

}

function makePost(ev) {

    ev.preventDefault();

    HttpClient.makePostAsync(formOnPage);

    load();

}

function postComments(ev) {

    ev.preventDefault();

    HttpClient.postCommentAsync(formOnPage, id);

    loadTopicHeader();
    loadComm();

}

async function load() {

    const posts = await HttpClient.getPostsAsync();

    if (isHome) {

        for (const post in posts) {

            const component = Components.postStructureHomePage();
            component.querySelector('a').id = posts[post]._id;
            component.querySelector('a').onclick = navigateToPost;
            component.querySelector('h2').textContent = posts[post].topicName;
            component.querySelector('time').textContent = posts[post].createdOn;
            component.querySelector('.name').textContent = posts[post].username;

            topic.append(component);
        }

    }

}

async function loadComm() {

    const comments = await HttpClient.getCommentsAsync();

    const commentContainer = document.getElementsByClassName('comment')[0];

    const commentsArr = Object.entries(comments).filter(([, value]) => value.topicId === id);

    commentsArr.forEach(comment => {

        const component = Components.commentStructure();
        component.querySelector('.name-comment').textContent = comment[1].username;
        component.querySelector('.time-content').textContent = comment[1].createdOn;
        component.querySelector('.post-details-comment').textContent = comment[1].comment;

        commentContainer.appendChild(component);

    })

    isCommentsLoad = true;

}

async function loadTopicHeader() {

    const topic = await HttpClient.getHeaderAsync(id);

    const commentDiv = document.getElementsByClassName('comment')[0];
    commentDiv.innerHTML = '';
    const component = Components.postStructurePostDetailsPage();
    component.querySelector('.post-name').textContent = topic.username;
    component.querySelector('.post-time').textContent = topic.createdOn;
    component.querySelector('.post-content').textContent = topic.content;
    commentDiv.appendChild(component);

    const titleHeading = document.querySelector('.title-topic');
    titleHeading.textContent = topic.topicName;

}

//Routing Invoke
function navigateToPost() {

    id = this.id;

    isCommentsLoad = false;

    Routes.navigateToPost();

}

function navigateToHome() {

    isCommentsLoad = false;

    Routes.navigateToHome();

}

//utility
function getForm() {

    const form = isHome
        ? document.getElementById('post-form')
        : document.getElementById('comment-form');

    form.addEventListener('submit', isHome
        ? makePost
        : postComments);

    return form;

}