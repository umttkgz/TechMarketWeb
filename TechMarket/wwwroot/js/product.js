var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'title', "width": "25%" },
            { data: 'price', "width": "15%" },
            { data: 'brand.name', "width": "20%" },
            { data: 'subCategory.name', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2">
                     <i class="bi bi-pencil-square"></i> Düzenle
                     </a>               
                     <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-danger mx-2"> 
                     <i class="bi bi-trash-fill"></i> Sil
                     </a>
                    </div>`
                },
                "width": "25%"
            }
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: 'Emin misiniz?',
        text: "Bu işlem geri döndürülemez!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        cancelButtonText: "Vazgeç",
        confirmButtonText: 'Evet, eminim!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    })
}