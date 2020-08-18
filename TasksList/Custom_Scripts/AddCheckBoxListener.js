$(document).ready(function () {

    $('.ActiveCheck').change(function () {
        // Reference itself
        var self = $(this);
        // Find the Id
        var id = self.attr('id');
        var value = self.prop('checked');

        $.ajax({
            url: '/Todoes/AJAXEdit',
            data: {
                id: id,
                value: value
            },
            type: 'POST',
            success: function (result) {
                $('#tableDiv').html(result);
            }
        });
    });
});