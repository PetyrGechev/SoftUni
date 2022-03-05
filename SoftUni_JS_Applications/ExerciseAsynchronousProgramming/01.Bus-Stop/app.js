window.onload = getInfo;
function getInfo() {
    const submitBtn = document.getElementById('submit');
    const inputField = document.getElementById('stopId');

    const busStopNameELement = document.getElementById('stopName');
    const busListELement = document.getElementById('buses');

    const baseURL = 'http://localhost:3030/jsonstore/bus/businfo/';

    submitBtn.addEventListener('click', loadBusData)

    async function loadBusData(e) {
        e.preventDefault();

        const busStopID = inputField.value


        try {
            busListELement.innerHTML = '';
            const endPoint = await fetch(`${baseURL}${busStopID}`);
            console.log(endPoint)
            const busStopData = await endPoint.json();
            console.log(busStopData)

            busStopNameELement.textContent = busStopData.name;
            if (inputField.value) {
                for (const key in busStopData.buses) {
                    let liElement = document.createElement('li');
                    liElement.textContent = `Bus ${key} arrives in ${busStopData.buses[key]} minutes`;
                    busListELement.appendChild(liElement);

                }
            }
        }
        catch (err) {
            busStopNameELement.textContent = 'Error'
        }
       

    }







}


