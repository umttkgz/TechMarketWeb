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
                     <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Düzenle</a>               
                     <a class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Sil</a>
                    </div>`
                },
                "width": "25%"
            }
        ]
    });
}