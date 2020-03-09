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

function makeAPIRequest(url, method, data = "") {
    switch (method) {
        case 'GET':
            getRequest(url)
            break;
        case 'POST':
        case 'PUT':
            postOtPutRequest(url, method, data)
            break
    }

    function getRequest(url) {
        let return_data = null;
        fetch(url).then(data => return_data = data);
        return return_data;
    }

    function postOtPutRequest(url, method, data) {
        let return_data = null;
        fetch(url, {
            method: method,
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(data),
        }).then((x) => return_data = x);
        return return_data;
    }

}