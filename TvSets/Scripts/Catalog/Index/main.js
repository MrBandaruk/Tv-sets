$(document).ready(function() {
    $('.li-search input').change(function () {
        if (!$('.li-search input').val()) {
            $.redirect("/Tv"); 
        }
    });
});

function deleteItem(id) {
    $.confirm({
        title: 'Are you sure?',
        content: 'Are you sure, you want to delete this TV-set?',
        autoClose: 'cancel|9000',
        theme: 'material',
        type: 'red',
        buttons: {
            confirm: {
                text: 'Delete',
                btnClass: 'btn-danger',
                keys: ['enter'],
                action: function () {
                    $.ajax({
                        url: 'http://localhost:50567/Tv/Delete/' + id,
                        success: function () {
                            location.reload();
                        }
                    });
                }
            },
            cancel: {}
        }
    });
}
