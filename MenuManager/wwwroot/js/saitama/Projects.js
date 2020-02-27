$(document).ready(function () {
    let projectsTable;

    if ($("#projects-table").length !== 0) {
        projectsTable = $("#projects-table").DataTable({
            //dom: '<"top">rt<"panel-footer"<"row"<"col-md-4"<"bottom"l>><"col-md-4"<"bottom"i>><"col-md-4"<"bottom"p>>>><"clear">',
            lengthMenu: DataTablelengthMenu,
            searching: false,
            scrollY: "40vh",
            pagingType: "simple",
            fixedHeader: {
                header: true,
                headerOffset: $("#header").height()
            },
            responsive: true,
            columns: [{
                width: "11.8%",
                title: "Employee ID",
                data: "empId"
            },
            {
                title: "First Name",
                data: "firstName"
            },
            {
                title: "Last Name",
                data: "lastName"
            },
            {
                width: "9%",
                orderable: false,
                title: "Action",
                data: null,
                defaultContent: '<ul class="list-inline"><li>' +
                    '<a href="#" class="text-inverse btnEditEmp" title="Edit"><i class="fa fa-pencil f-s-15"></i></a>' +
                    "</li>" +
                    "<li>" +
                    '<a href="#" class="text-danger btnDeleteEmp" title="Delete"><i class="fa fa-trash f-s-15"></i></a>' +
                    "</li>" +
                    "<li>" +
                    '<a href="#" class="text-info btnHistory" title="History"><i class="fa fa-history f-s-15"></i></a>' +
                    "</li>" +
                    "</ul>"
            }
            ]
        });
    }
});