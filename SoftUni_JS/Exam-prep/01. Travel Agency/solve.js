function solve() {

    let addButtonElement = document.getElementById('add');
    addButtonElement.addEventListener('click', (e) => {

        e.preventDefault();

        let modelInput = document.getElementById('model');
        let yearInput = document.getElementById('year');
        let descriptionInput = document.getElementById('description');
        let priceInput = document.getElementById('price');
        priceInput.classList.add('test')


        let modelInputContent = document.getElementById('model').value;
        let yearInputContent = Number(document.getElementById('year').value);
        let descriptionInputContent = document.getElementById('description').value;
        let priceInputContent = Number(document.getElementById('price').value);

        if (!modelInputContent == '' && !descriptionInputContent == '' && yearInputContent != 0 && priceInputContent != 0) {

            modelInput.value = '';
            yearInput.value = '';
            descriptionInput.value = '';
            priceInput.value = '';



            let tdModelElement = document.createElement('td');
            tdModelElement.textContent = modelInputContent;

            let tdPriceElement = document.createElement('td');
            tdPriceElement.textContent = priceInputContent.toFixed(2);

            let trModelPriceButtons = document.createElement('tr');

            let moreBtn = document.createElement('button');
            moreBtn.textContent = 'More Info';
            moreBtn.classList.add('moreBtn')

            let buyBtn = document.createElement('button');
            buyBtn.textContent = 'Buy it';
            buyBtn.classList.add('buyBtn');

            let tdButtons = document.createElement('td');
            tdButtons.appendChild(moreBtn);
            tdButtons.appendChild(buyBtn);

            trModelPriceButtons.appendChild(tdModelElement);
            trModelPriceButtons.appendChild(tdPriceElement);
            trModelPriceButtons.appendChild(tdButtons);

            trModelPriceButtons.classList.add('info');

            tdYearElement = document.createElement('td');
            tdYearElement.textContent = `Year: ${yearInputContent}`;

            tdColspanElement = document.createElement('td');
            tdColspanElement.setAttribute('colspan', 3);
            tdColspanElement.textContent = `Description: ${descriptionInputContent}`


            let trHiddenElement = document.createElement('tr');
            trHiddenElement.classList.add('hide');
            trHiddenElement.appendChild(tdYearElement);
            trHiddenElement.appendChild(tdColspanElement);


            let tBodyElement = document.getElementById("furniture-list");
            tBodyElement.appendChild(trModelPriceButtons);
            tBodyElement.appendChild(trHiddenElement);

            moreBtn.addEventListener('click', (e) => {
                let buttonContent=e.currentTarget.textContent;
                if (buttonContent == 'More Info') {
                    trHiddenElement.style.display='contents';
                    
                    e.currentTarget.textContent = 'Less Info';
                } else  {
                    trHiddenElement.style.display='none';
                    e.currentTarget.textContent = 'More Info';
                }



            })

            buyBtn.addEventListener('click', (e)=>{
                let totalPriceELemennt=document.querySelector(".total-price");
                let totalPrice=Number(totalPriceELemennt.textContent);

                totalPrice+=priceInputContent;
                totalPriceELemennt.textContent=totalPrice.toFixed(2);
                trModelPriceButtons.remove();
                trHiddenElement.remove();
            })

            

        }


    })
}