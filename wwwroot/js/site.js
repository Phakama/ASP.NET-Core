// Write your JavaScript code.
$(document).ready(function () {
    $(function () {
        $("#datepicker").datepicker();
    });

    $("#userlist").DataTable({
        ajax: "../AppUser/UsersList"
        //processing: true,
        //serverSide: true,
        //rowReorder: true,
        //deferRender: true,
        //lengthMenu: [[10, 25, 50, 100, -1], [10, 25, 50, 100, "All"]],
        //sAjaxSource: "../AppUser/UsersList",
        //columns: [
        //    { data: "FirstName" },
        //    { data: "LastName" },
        //    { data: "CellNumber" },
        //    { data: "EmailAddress" }
        //]
        //, fnDrawCallback: function () {

        //    $('#errorTable tbody tr').click(function () {
        //        var data = table.row($(this)).data();
        //        var id = JSON.stringify(data["candyErrId"]);
        //        document.location.href = '../Error/index/' + id;
        //    });
        //} 
    });

});