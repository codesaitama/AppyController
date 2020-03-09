$(document).ready(function () {

    let dt = new DateHandler();
    let sub = {
        1: { color: 'success', state: 'Active' },
        0: { color: 'danger', state: 'Inactive' }
    };

    readExternalFile(file = "/Data/Projects.json", mime = 'json', loadAPIData);

    function loadAPIData(data) {
            data = JSON.parse(data);
            createProjectTable(data, '#project-tbody');
    }

    makeAPIRequest('api/project/getprojects', 'GET').then(data => data.json()).then(data => console.log(data))

    function createProjectTable(data, tableId) {
        let view = ''

        data.forEach(element => {
            view += `
                    <tr>
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
                    </tr>
                    `
        });

        // Render the tbody.
        document.querySelector(tableId).innerHTML = `${view}`
        bindButtonsToDOM()
    }

    document.querySelector('#btnAddProject').addEventListener('click', function () {
        $('#projectsModal').modal('toggle');
        document.querySelector('#btnSave').innerText = 'Add';
    });

    function bindButtonsToDOM() {
        let elements = document.getElementsByClassName('editButton');

        for (let x = 0; x < elements.length; x++) {
            elements[x].addEventListener('click', function (e) {
                getRowFunction(this)
            });
        }
    }

    function getRowFunction(el) {
        var n = el.parentNode.parentNode.cells
        let data = [];

        for (let x = 0; x < n.length; x++) { data.push(n[x].textContent.trim()) }

        let selectedRowData = { id: el.id, name: data[0], status: data[1] == "Active" ? 1 : 0, date: data[2] };
        populateInputFields(selectedRowData);
    }

    function populateInputFields(data) {
        document.querySelector('#description').value = data.name;
        document.querySelector('#notes').value = 'Empty';
        document.querySelector('#status').value = data.status;
        document.querySelector('#btnSave').innerText = 'Update';

        $('#projectsModal').modal('toggle');
    }
});