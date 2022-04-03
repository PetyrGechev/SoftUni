import { html } from '../../node_modules/lit-html/lit-html.js'
import * as server from '../api/server.js'

const catalogTemplate = (theaters,user) => html`
<section id="profilePage">
    <div class="userInfo">
        <div class="avatar">
            <img src="./images/profilePic.png">
        </div>
        <h2>${user.email}</h2>
    </div>
    <div class="board">
        <!--If there are event-->
        ${theaters.length>0 ? html`
        ${theaters.map(f=>previewTemplate(f))}
        `: 
        html`
         <div class="no-events">
            <p>This user has no events yet!</p>
        </div>
        
        
        `}
        

        <!--If there are no event-->
       
    </div>
</section>

`

const previewTemplate=(theater)=>html`
 <div class="eventBoard">
            <div class="event-info">
                <img src=${theater.imageUrl}>
                <h2>${theater.title}<h2>
                <h6>${theater.date}</h6>
                <a href="/details/${theater._id}" class="details-button">Details</a>
            </div>
</div>
`


export async function myProfile(ctc) {
    const user=ctc.user;
    const theaters = await server.getMyTheathers(ctc.user._id);
    console.log(ctc.user)
    ctc.render(catalogTemplate(theaters,user));
}