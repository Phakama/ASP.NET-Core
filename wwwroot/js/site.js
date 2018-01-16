// Write your JavaScript code.
$(document).ready(function () {
    $(function () {
        $("#datepicker").datepicker();
    });

    $("#userlist").DataTable({
        "columnDefs": [
            { "orderable": false, "targets": [2, 3, 4] }
        ]
    });
});