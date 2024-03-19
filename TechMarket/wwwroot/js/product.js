$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'title', "width": "25%" },
            { data: 'price', "width": "10%" },
            { data: 'brand.name', "width": "20%" },
            { data: 'subCategory.name', "width": "15%" }
        ]
    });
}