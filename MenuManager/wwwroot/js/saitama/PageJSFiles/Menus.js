$(document).ready(function () {

<<<<<<< HEAD
    let dt = new DateHandler();
    let saveLoadedData = [];
    let saveOrUpdate = 0;
    let projectId = null;
    let sub = {
        1: { color: 'success', state: 'Active' },
        0: { color: 'danger', state: 'Inactive' }
    };

    loadProjects();
    function loadProjects() {
        makeAPIRequest('/api/project/getprojects', 'GET', '', loadAPIData);
    }

    function loadAPIData(data) {
        if (data) {
            data = JSON.parse(data);
            createProjectTable(data, '#project-tbody');
        }
    }


    function createProjectTable(data, tableId) {
        let view = ''

        saveLoadedData = [];

        data.forEach(element => {
            saveLoadedData.push(element);
            element.status = 1;
            view += `
                    <tr>
                        <td>
                            <i class=""></i>${element.projectName}
                        </td>
                        <td>
                            <span class="badge badge-dot mr-4">
                                <i class="bg-${element.status == 1 ? `success` : `warning`}"></i> <span class="btn btn-${sub[element.status].color} btn-sm" disabled>${sub[element.status].state}</span>
                            </span>
                        </td>
                        <td class="">
                            ${dt.calendarFormat(element.createdate, '-')}
                        </td>
                        <td class="text-center">
                            <a href="#" class="text-inverse editButton" id="${element.id}" title="Edit"><i class="fas fa-edit"></i></a>
                            <a href="#" class="text-danger deleteButton" title="Delete"><i class="fas fa-trash"></i></a>
                        </td>
                    </tr>
                    `
        });

        // Render the tbody.
        document.querySelector(tableId).innerHTML = `${view}`
        bindButtonsToDOM()
    }

    document.querySelector('#btnAddProject').addEventListener('click', function () {
        $('#projectsModal').modal('toggle');
        saveOrUpdate = 0;
        document.querySelector('#btnSave').innerText = 'Add';
        clearFields();
    });

    function clearFields() {
        document.querySelector('textarea').value = "";
        document.querySelector('select').value = -1;
        document.querySelector('#description').value = "";
    }

    function bindButtonsToDOM() {
        let elements = document.getElementsByClassName('editButton');

        for (let x = 0; x < elements.length; x++) {
            elements[x].addEventListener('click', function (e) {
                getRowData(this.id)
            });
        }
    }

    function getRowData(rowId) {
        projectId = rowId;
        let data = saveLoadedData.filter((ele) => ele.id === rowId);
        populateInputFields(data[0]);
        saveOrUpdate = 1;
    }

    function populateInputFields(data) {
        document.querySelector('#description').value = data.projectName;
        document.querySelector('#notes').value = data.description;
        document.querySelector('#status').value = 1;
        document.querySelector('#btnSave').innerText = 'Update';

        $('#projectsModal').modal('toggle');
    }

    document.querySelector('#btnSave').addEventListener('click', function () {
        let postData = {
            description: document.querySelector('#notes').value,
            projectName: document.querySelector('#description').value,
            uniqueIdentifier: uuidv4()
        }

        saveOrUpdate != 1 ? createProject('/api/project/postproject', postData) : updateProject(`/api/project/putproject/${projectId}`, postData)
    });

    function createProject(url, data) {
        makeAPIRequest(url, 'POST', data, function (response) {
            console.log(response);
            loadProjects();
            $('#projectsModal').modal('toggle');
            messenger('success');
        });
    }

    function updateProject(url, data) {
        makeAPIRequest(url, 'PUT', data, function (response) {
            console.log(response);
            loadProjects();
            $('#projectsModal').modal('toggle');
            messenger('success');
        });
    }
=======
    makeAPIRequest('/api/project/getprojects', 'GET', '', function (data) {
        if (data) {
            data = JSON.parse(data);
            let options = '<option value="-1" disabled selected >Select Project</option>';
            data.forEach((element) => {
                options += '<option value="' + element.id + '">' + element.projectName + '</option>';
            });
            document.querySelector('#slctProject').innerHTML = options;
        }
    });

    document.querySelector('#slctProject').addEventListener('change', function () {
        makeAPIRequest('/api/application/getapplicationbyprojectid/' + this.value, 'GET', '', function (data) {
            if (data) {
                data = JSON.parse(data);
                let options = '<option value="-1" disabled selected >Select Application</option>';
                data.forEach((element) => {
                    options += '<option value="' + element.id + '">' + element.name + '</option>';
                });
                document.querySelector('#slctApplication').innerHTML = options;
            }
        });
    });

    document.querySelector('#slctApplication').addEventListener('change', function () {
        enableDisable(0, '#btnAddMenu');
        makeAPIRequest('/api/application/GetMenusByApplicationId/' + this.value, 'GET', '', function (data) {
            enableDisable(1, '#btnAddMenu');
            if (data) {
                data = JSON.parse(data);
                console.log(data);
            }
        });
    });


    /*
     * POST
     {
      "applicationId": "string",
      "parent": "string",
      "projectId": "string",
      "status": 0,
      "uniqueId": "string",
      "controller": "string",
      "description": "string",
      "method": "string",
      "name": "string"
    }
     */

>>>>>>> 28a5a8e4f77a15da4ece3ec87b8df1f453a462cc
});