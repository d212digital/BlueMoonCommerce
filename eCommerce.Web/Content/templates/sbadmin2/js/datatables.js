// Call the dataTables jQuery plugin
$(document).ready(function () {
    $('#dataTableProducts').dataTable({
        "bInfo": true,
        "bPaginate": false      
    });
});

$(document).ready(function () {
    $('#dataTableOrders').dataTable({
        "bInfo": true,
        "bPaginate": false
    });
});
$(document).ready(function () {
    $('#dataTableCustomers').dataTable({
        "bInfo": true,
        "bPaginate": false
    });
});
$(document).ready(function () {
    $('#dataTableCategories').dataTable({
        "bInfo": true,
        "bPaginate": false
    });
});
