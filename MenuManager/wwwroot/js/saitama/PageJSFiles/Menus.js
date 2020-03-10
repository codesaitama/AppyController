$(document).ready(function () {

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

});