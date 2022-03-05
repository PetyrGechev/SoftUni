async function lockedProfile() {
    const mainElement = document.getElementById("main");
    const hiddenInfoElement = document.getElementsByClassName("hiddenInfo")[0];

    const res = await fetch("http://localhost:3030/jsonstore/advanced/profiles");
    const data = await res.json();
    mainElement.replaceChildren(...Object.values(data).map(x => makeProfile(x)));
    mainElement.addEventListener('click', showMore);

    //ev.target.parentNode.children[2].checked)
    function showMore(ev) {
        if (ev.target.tagName === "BUTTON") {
            if (ev.target.parentNode.children[2].checked) {
               
                return
            } else if (ev.target.parentNode.children[4].checked&&ev.target.textContent=="Show more") {
                console.log("unlocked")
                console.log(hiddenInfoElement)
                ev.target.parentNode.children[9].style.display = 'block';
                ev.target.parentNode.children[9].classList.remove('hiddenInfo');
                ev.target.parentNode.children[9].children[2].style.display = 'block';
                ev.target.parentNode.children[9].children[3].style.display = 'block';
                ev.target.textContent = 'Hide it';
            }
            else if(ev.target.parentNode.children[4].checked&&ev.target.textContent=="Hide it"){
                ev.target.textContent = 'Show more';
                ev.target.parentNode.children[9].style.display = 'none';
                ev.target.parentNode.children[9].classList.add('hiddenInfo');
                ev.target.parentNode.children[9].children[2].style.display = 'none';
                ev.target.parentNode.children[9].children[3].style.display = 'none';
            }


        } else {
            return;
        }
    }


    function makeProfile(profile) {
        const divElement = document.createElement("div");
        divElement.classList.add("profile");
        divElement.innerHTML = `
        <img src="./iconProfile2.png" class="userIcon" />
        <label>Lock</label>
        <input type="radio" name="user1Locked" value="lock" checked>
        <label>Unlock</label>
        <input type="radio" name="user1Locked" value="unlock"><br>
        <hr>
        <label>Username</label>
        <input type="text" name="user1Username" value="${profile.username}" disabled readonly />
        <div class="hiddenInfo">
            <hr>
            <label>Email:</label>
            <input type="email" name="user1Email" value="${profile.email}" disabled readonly />
            <label>Age:</label>
            <input type="email" name="user1Age" value="${profile.age}" disabled readonly />
        </div>
        <button>Show more</button>`;
        return divElement;

    }
}