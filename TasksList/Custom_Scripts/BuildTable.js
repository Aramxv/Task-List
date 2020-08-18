$(document).ready(function () {

    $.ajax({
        url: '/Todoes/BuildTodoTable',
        success: function (result) {
            $('#tableDiv').html(result);
        }
    });
});