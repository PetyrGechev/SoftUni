function attachEvents() {

    
    const postsEndpoint = `http://localhost:3030/jsonstore/blog/posts`;
    const commentsEndpoint = `http://localhost:3030/jsonstore/blog/comments`;

    const dropElement = document.getElementById('posts');

    const postTitle = document.getElementById('post-title');
    const postBody = document.getElementById('post-body');
    const postComments = document.getElementById('post-comments');

    const buttonLoadPosts = document.getElementById('btnLoadPosts');
    buttonLoadPosts.addEventListener('click', getPosts);

    const buttonViewPost = document.getElementById('btnViewPost');
    buttonViewPost.addEventListener('click', viewPost);

    async function viewPost() {

        postComments.replaceChildren();

        const res = await fetch(postsEndpoint);
        const result = await res.json();

        postTitle.textContent = result[dropElement.value].title.toUpperCase();
        postBody.textContent = result[dropElement.value].body;

        const response = await fetch(commentsEndpoint);
        const dataInfo = await response.json();

        let resultAsArr = Object.entries(dataInfo);
        resultAsArr = resultAsArr.filter(([, value]) => value.postId === dropElement.value);

        for (const [key, value] of resultAsArr) {

            const liElement = document.createElement('li');
            liElement.id = key;
            liElement.textContent = value.text;
            postComments.appendChild(liElement);

        }

    }

    async function getPosts() {

        const res = await fetch(postsEndpoint);
        const data = await res.json();

        for (const key in data) {
            const optionElement = document.createElement('option');
            optionElement.textContent = data[key].title;
            optionElement.value = key;
            dropElement.appendChild(optionElement);

        }

    }

}

attachEvents();