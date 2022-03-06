function attachEvents() {

   
    const phonebookEndpoint = `http://localhost:3030/jsonstore/phonebook`;

    const phoneElement = document.getElementById('phonebook');

    const personElement = document.getElementById('person');
    const phoneFieldElement = document.getElementById('phone');

    const createElement = document.getElementById('btnCreate');
    createElement.addEventListener('click', create);

    const loadButton = document.getElementById('btnLoad');
    loadButton.addEventListener('click', load);

    async function create() {

        const object = {
            person: personElement.value,
            phone: phoneFieldElement.value
             };

        await fetch(phonebookEndpoint, {

            method: 'POST',
            headers: {

                'Content-type': 'application/json'

            },
            body: JSON.stringify(object)

        })

        load(); 

    }

    async function deleteContact(ev) {

        ev.preventDefault();

        const deleteEndpoint = `${phonebookEndpoint}/${ev.target.parentNode.id}`;

        await fetch(deleteEndpoint, {

            method: 'DELETE',
            headers: {
                'Content-type': 'application/json'
            }

        });

        load(); //reload the phonebook data after deleting a record

    }

    async function load() {

        phoneElement.replaceChildren();

        const res = await fetch(phonebookEndpoint);
        const data = await res.json();

        for (const record in data) {

            const liElement = document.createElement('li');
            liElement.textContent = `${data[record].person}: ${data[record].phone}`;
            liElement.id = record;
            phoneElement.appendChild(liElement);

            const deleteButton = document.createElement('button');
            deleteButton.textContent = `Delete`;
            deleteButton.addEventListener(`click`, deleteContact);
            liElement.appendChild(deleteButton);


        }

    }

}

attachEvents();