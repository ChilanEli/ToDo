$(document).ready(function () {
    $('.CurrentCheck').change(function () {
        var current = $(this);
        var id = current.attr('id');
        var value = current.prop('checked');

        $.ajax({
            url: '/ToDoes/AjaxEdit',
            data: {
                id: id,
                value:value
            },
            type:'POST',
            success: function (result) {
                $('#tableDiv').html(result);
            }
        })
    })
})