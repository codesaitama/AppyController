$(document).ready(function () {

    let dt = new DateHandler();
    let saveLoadedData = [];
    let saveOrUpdate = 0; 
    let applicationId = null;
    let sub = {
        1: { color: 'success', state: 'Active' },
        0: { color: 'danger', state: 'Inactive' }
    };

    makeAPIRequest('/api/project/getprojects', 'GET', '', loadForSelectBox);

    function loadForSelectBox(data) {
        data = JSON.parse(data);

        var options = '<option value="-1" disabled selected >Select Project</option>';
        data.forEach((element) => {
            options += '<option value="' + element.id + '">' + element.projectName + '</option>';
        });

        document.querySelector('#slctProject').innerHTML = options;
    }

    document.querySelector('#slctProject').addEventListener('change', function () {
        makeAPIRequest('/api/application/getapplicationbyprojectid/' + this.value, 'GET', '', function (data) {
            if (data) {
                createAppsTable(JSON.parse(data), '#apps-tbody');
            }
        });
    });

    function createAppsTable(data, tableId) {
        let view = ''
        saveLoadedData = [];
        data.forEach(element => {
            element.status = 1;
            saveLoadedData.push(element)
            view += `
                    <tr>
                        <td>
                            <i class=""></i>${element.prefix}
                        </td>
                        <td>
                            <i class=""></i>${element.name}
                        </td>
                        <td>
                            <span class="badge badge-dot mr-4">
                                <i class="bg-${element.status == 1 ? `success` : `warning`}"></i> <span class="btn btn-${sub[element.status].color} btn-sm" disabled>${sub[element.status].state}</span>
                            </span>
                        </td>
                        <td class="">
                            ${dt.calendarFormat(element.createdAt, '-')}
                        </td>
                        <td class="text-center">
                            <a href="#" class="text-inverse editButton" id="${element.id}" title="Edit"><i class="fas fa-edit"></i></a>
                            <a href="#" class="text-danger deleteButton" title="Delete"><i class="fas fa-trash"></i></a>
                        </td>
                    </tr>`
        });

        // Render the tbody.
        document.querySelector(tableId).innerHTML = `${view}`
        bindButtonsToDOM()
    }

    document.querySelector('#btnAddApp').addEventListener('click', function () {
        $('#appModal').modal('toggle');
        saveOrUpdate = 0;
        document.querySelector('#btnSave').innerText = 'Add';
    });

    function bindButtonsToDOM() {
        let elements = document.getElementsByClassName('editButton');

        for (let x = 0; x < elements.length; x++) {
            elements[x].addEventListener('click', function (e) {
                getDataByID(this.id)
            });
        }
    }

    function getDataByID(rowId) {
        applicationId = rowId;
        let data = saveLoadedData.filter((ele) => ele.id === rowId);
        populateInputFields(data[0]);
        saveOrUpdate = 1;
    }

<<<<<<< HEAD
    function clearFields() {
        document.querySelector('textarea').value = "";
        document.querySelector('#description').value = "";
        document.querySelector('#txtWebsite').value = "";
        document.querySelector('#txtPrefix').value = "";
    }

=======
>>>>>>> 845c9f533b09e017e06ac47a189bb5694d3c9982
    function populateInputFields(data) {
        document.querySelector('#description').value = data.name;
        document.querySelector('#notes').value = data.description != null ? data.description : 'Empty';
        document.querySelector('#txtWebsite').value = data.url;
        document.querySelector('#txtPrefix').value = data.prefix;
        document.querySelector('#btnSave').innerText = 'Update';

        $('#appModal').modal('toggle');
    }

    
    document.querySelector('#btnSave').addEventListener('click', function () {

        let postData = {
            projectId: document.querySelector('#slctProject').value,
            description: document.querySelector('#notes').value,
            name: document.querySelector('#description').value,
            prefix: document.querySelector('#txtPrefix').value,
            url: document.querySelector('#txtWebsite').value
        }

        saveOrUpdate != 1 ? createApplication('/api/application/postapplication', postData) : updateApplication(`/api/application/putapplication/${applicationId}`, postData);

    });

    function reloadApplications() {
        makeAPIRequest('/api/application/getapplicationbyprojectid/' + document.querySelector('#slctProject').value, 'GET', '', function (data) {
            if (data) {
                createAppsTable(JSON.parse(data), '#apps-tbody');
            }
        });
    }

    function createApplication(url, data) {
        makeAPIRequest(url, 'POST', data, function (response) {
            response = JSON.parse(response)
            console.log(response);
            reloadApplications();
            $('#appModal').modal('toggle');
            messenger('success');
        });
    }

    function updateApplication(url, data) {
        makeAPIRequest(url, 'PUT', data, function (response) {
            reloadApplications();
            $('#appModal').modal('toggle');
            messenger('success');
        });
    }
});