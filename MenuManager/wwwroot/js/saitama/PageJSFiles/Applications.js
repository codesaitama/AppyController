$(document).ready(function () {

    let dt = new DateHandler();
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
        makeAPIRequest('/api/application/getapplicationbyprojectid/' + this.value, 'GET', '', loadAPIData);
    });

    function loadAPIData(data) {
        data = JSON.parse(data);
        createAppsTable(data, '#apps-tbody');
    }

    function createAppsTable(data, tableId) {
        let view = ''

        data.forEach(element => {
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
                            ${dt.calendarFormat(element.createdDate, '-')}
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

    function getDataByID(outsideId) {
        readExternalFile(file = "/Data/Applications.json", mime = 'json', loadData);
        outsideId = Number(outsideId);

        function loadData(data) {
            data = JSON.parse(data);
            data = data.filter(function (x) { return x.id == outsideId });
            populateInputFields(data[0])
        }
    }

    function populateInputFields(data) {
        document.querySelector('#description').value = data.name;
        document.querySelector('#notes').value = data.description != null ? data.description : 'Empty';
        document.querySelector('#txtWebsite').value = data.url;
        document.querySelector('#txtPrefix').value = data.prefix;
        document.querySelector('#slctProject').value = data.projectID;
        document.querySelector('#btnSave').innerText = 'Update';

        $('#appModal').modal('toggle');
    }
});