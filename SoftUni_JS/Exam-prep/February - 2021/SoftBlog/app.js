function solve() {

   let buttonCreate = document.querySelector('.btn , .create');
   buttonCreate.addEventListener('click', (e) => {
      e.preventDefault();
      let siteContent = document.querySelector('.site-content section')
      let creatorElement = document.getElementById(`creator`);
      let titleElement = document.getElementById(`title`);
      let categoryElement = document.getElementById(`category`);
      let contentElement = document.getElementById(`content`);

      let article = document.createElement('article');

      let h1Element = document.createElement('h1');
      h1Element.textContent = titleElement.value;

      let strCategory = document.createElement('strong');
      strCategory.textContent = categoryElement.value;

      let pCategory = document.createElement('p');
      pCategory.textContent = 'Category:';
      pCategory.appendChild(strCategory);

      let strAuthor = document.createElement('strong');
      strAuthor.textContent = creatorElement.value;

      let pAuthor = document.createElement('p');
      pAuthor.textContent = 'Creator:';
      pAuthor.appendChild(strAuthor);

      let pContent = document.createElement('p');
      pContent.textContent = contentElement.value;

      let btnDelete = document.createElement('button');
      btnDelete.textContent = 'Delete';
      btnDelete.classList.add('btn');
      btnDelete.classList.add('delete');
      let btnArhive = document.createElement('button');
      btnArhive.textContent = 'Archive';
      btnArhive.classList.add('btn');
      btnArhive.classList.add('archive');

      let divElement = document.createElement('div');
      divElement.classList.add('buttons');
      divElement.appendChild(btnDelete);
      divElement.appendChild(btnArhive);
      article.appendChild(h1Element);
      article.appendChild(pCategory);
      article.appendChild(pAuthor);
      article.appendChild(pContent);
      article.appendChild(divElement);

      siteContent.appendChild(article);

      creatorElement.value = ('');
      titleElement.value = ('')
      categoryElement.value = ('')
      contentElement.value = ('')

      btnArhive.addEventListener('click',(e)=>{
        let olElement=document.getElementsByTagName('OL')[0];
        let liElementArhive= document.createElement('li');
        liElementArhive.textContent=h1Element.textContent;

         olElement.appendChild(liElementArhive);
         e.currentTarget.parentElement.parentElement.remove();


         let allLiElements=Array.from(olElement.children);
         allLiElements.sort((a,b)=>a.textContent.localeCompare(b.textContent))
         .forEach(x=>olElement.appendChild(x));
         

      })
      btnDelete.addEventListener('click',(e)=>{
            e.currentTarget.parentElement.parentElement.remove();
      })
   });

}


