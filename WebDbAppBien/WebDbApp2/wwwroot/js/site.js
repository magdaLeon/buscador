// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    new DataTable('#buscador', {
        ajax: {url: '/api/Materia/GetMaterias', dataSrc: ''},
        columns: [
            {data: 'decanato'},
            {data: 'departamento'},
            {data: 'codigoClase'},
            {data: 'periodo'},
            {data: 'descripcion'},
            {
                data: 'urlCurso',
                "fnCreatedCell": function (nTd, sData, oData, iRow, iCol) {
                    $(nTd).html("<a href='" + oData.urlCurso + "' target=\"_blank\" rel=\"noopener noreferrer\">Link</a>");
                }
            },
            {
                data: 'urlDownload',
                "fnCreatedCell": function (nTd, sData, oData, iRow, iCol) {
                    $(nTd).html("<a href='" + oData.urlCurso + "' target=\"_blank\" rel=\"noopener noreferrer\">Descargar Curso</a>");
                }
            }
        ],
        language: {
            "lengthMenu": "Mostrando _MENU_ registros por página",
            "zeroRecords": "No se encontró nada! 😭",
            "info": "Mostrando _PAGE_ de _PAGES_",
            "infoEmpty": "No se encontró nada! 😭",
            "infoFiltered": "(Filtrando de _MAX_ registros)",
            "search": "Búsqueda"
        }
    });
});
