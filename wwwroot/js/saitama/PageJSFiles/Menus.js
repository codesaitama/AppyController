$(document).ready(function () {
    let dt = new DateHandler();
    let saveLoadData = [];
    let saveOrUpdate = 0;
    let menuId = null;
    let sub = {
        1: { color: 'success', state: 'Active' },
        0: { color: 'danger', state: 'Inactive' }
    }
    makeAPIRequest('/api/Menus/GetAllMenus', 'GET', '', function (data) {
        data = JSON.parse(data)
        console.log(data)
    });
});

function loadAPIData(data) {
    if (data) {
        data = JSON.parse(data);
        createMenuTable(data, '#menu-body')
    }
}
function createMenuTable(data, tableId) {
    let view = ''

    saveLoadData = [];

    data.forEach(ele => {
        saveLoadData.push(ele)
        ele.status = 1;
        view += `
                <tr>
                    <td>
                        <i class=""></i>${ele.menuName}
                    </td>

                    <td>
                        <span class="badge badge-dot mr-4">
                            <i class="bg-${ele.status == 1 ? `success` : `warning`}"></i> <span class="btn btn-${sub[ele.status].color} btn-sm" disabled> ${sub[ele.status].state}</span>
                        </span>
                    </td>

                    <td>
                        <i class=""></i>${ele.menuController}
                    </td>

                    <td>
                        <i class=""></i>${ele.menuMethod}
                    </td>
                    
                     <td class="">
                            ${dt.calendarFormat(element.createdate, '-')}
                     </td>

                     <td class="text-center">
                          <a href="#" class="text-inverse editButton" id="${ele.id}" title="Edit"><i class="fas fa-edit"></i></a>
                          <a href="#" class="text-danger deleteButton" title="Delete"><i class="fas fa-trash"></i></a>
                     </td>
                </tr>
                `
    });
    document.querySelector(tableId).innerHtml = `${view}`
    bindButtonsToDom()
}
document.querySelector('#btnAddMenu').addEventListener('click', function () {
    $('#menusModal').modal('toggle');
    saveOrUpdate = 0;
    document.querySelector('#btnSaveMenu').innerText = 'Add';
});

function bindButtonsToDom() {
    let elements = document.getElementsByClassName('editButton');
    for (let x = 0; x < elements.length; x++) {
        elements[x].addEventListener('click', function (e) {
            getDataByID(this.id)
        });
    }
}
function getDataByID(rowId) {
    menuId = rowId;
    let data = saveLoadData.filter((ele) => ele.id === rowId);
    populateInputFields(data[0]);
    saveOrUpdate = 1;
}
function populateInputFields(data) {
    document.querySelector('#menudescrip').value = data.name;
    document.querySelector('#notes').value = data.menudescrip != null ? data.menudescrip : 'Empty';
    document.querySelector('#txtWebsite').value = data.url;
    document.querySelector('#txtPrefix').value = data.prefix;
    document.querySelector('#btnSaveMenu').innerText = 'Update';

    $('#menusModal').modal('toggle');
}

    let postData = {
        MenuId: document.querySelector('#selectMenu').value,
        description: document.querySelector('#notes').value,
        name: document.querySelector('#txtWebsite').value,
        prefix: document.querySelector('#txtPrefix').value,
        url: document.querySelector('#txtWebsite').value
    }

    saveOrUpdate != 1 ? createMenu('/api/Menu/PostMenu', postData) : updateMenu(`/api/Menu/putMenu/${menuId}`, postData);

    });

function createMenu(url, data) {
    makeAPIRequest(url, 'POST', data, function (response) {
        response = JSON.parse(response)
        reloadMenus();
        $('menuModal').modal('toggle');
        messenger('success');
    });
}