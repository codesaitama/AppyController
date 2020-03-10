function readExternalFile(file, mime, callback) {
    let overrideMime = ''

    mime === 'json' ? overrideMime = "application/json" : mime === 'html' ? overrideMime = "text/html" : overrideMime = "text/plain"

    let dataFile = new XMLHttpRequest();
    dataFile.overrideMimeType(overrideMime);
    dataFile.open("GET", file, true);
    dataFile.onreadystatechange = function () {
        if (dataFile.readyState === 4 && dataFile.status == "200") {
            callback(dataFile.responseText);
        }
    }
    dataFile.send(null);
}

function makeAPIRequest(url, method, data = "", callback) {
    switch (method) {
        case 'GET':
            getRequest(url, callback)
            break;
        case 'POST':
        case 'PUT':
            postOtPutRequest(url, method, data, callback)
            break
        case 'DELETE':
            deleteRequest(url, callback)
            break;
    }

    function getRequest(url, callback) {
        fetch(url).then(data => data.text()).then(data => callback(data));
    }

    function deleteRequest(url, callback) {
        fetch(url, {
            method: 'DELETE',
        }).then(res => res.text()).then(data => callback(data));
    }

    function postOtPutRequest(url, method, data, callback) {
        fetch(url, {
            method: method,
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(data),
        }).then(data => data.text()).then(data => callback(data));
    }

}

function uuidv4() {
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
        var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
        return v.toString(16);
    });
}

function setColorToToastr(color) {
    let elements = document.getElementsByClassName('iziToast-theme-light');
    for (let x = 0; x < elements.length; x++) {
        elements[x].style.backgroundColor = color
    }
}




function messenger(message) {
    switch (message.toLowerCase()) {
        case 'success':
            setColorToToastr('lightgreen');
            iziToast.show({
                color: color,
                icon: 'fa fa-check',
                position: 'topRight',
                message: 'Data submitted successfully'
            });
            break;
        case 'error':
            setColorToToastr('red')
            iziToast.show({
                color: 'red',
                icon: 'fa fa-times',
                position: 'topRight',
                message: 'An error occured'
            });
            break;
        case 'warning':
            setColorToToastr('lightblue')
            iziToast.show({
                color: 'yellow',
                icon: 'fa fa-warning',
                position: 'topRight',
                message: 'Something went wrong'
            });
            break;
        case 'unknown':
            document.querySelector('.iziToast-theme-light').style.backgroundColor = 'lightblue'
            iziToast.show({
                color: 'blue',
                icon: 'fa fa-info',
                position: 'topRight',
                message: 'No match found!'
            });
            break;
    }
}