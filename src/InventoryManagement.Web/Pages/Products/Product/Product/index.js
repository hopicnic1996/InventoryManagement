$(function () {

    var l = abp.localization.getResource('InventoryManagement');

    var service = inventoryManagement.products.product.product;
    //var createModal = new abp.ModalManager(abp.appPath + 'Products/Product/Product/CreateModal');
    var createModal = new abp.ModalManager({
        viewUrl: abp.appPath + 'Products/Product/Product/CreateModal',
        //scriptUrl: abp.appPath + 'Pages/Products/Product/Product/createModal.js'
        modalClass: 'productCreateModal',
    });
    var editModal = new abp.ModalManager(abp.appPath + 'Products/Product/Product/EditModal');

    var dataTable = $('#ProductTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('InventoryManagement.Product.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('InventoryManagement.Product.Delete'),
                                confirmMessage: function (data) {
                                    return l('ProductDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('ProductProductName'),
                data: "productName"
            },
            {
                title: l('ProductProductGroupName'),
                data: "productGroupName"
            },
            {
                title: l('ProductUnitName'),
                data: "unitName"
            },
            {
                title: l('ProductReferenceUnitName'),
                data: "referenceUnitName"
            },
            {
                title: l('ProductReferenceUnitQuantity'),
                data: "referenceUnitQuantity"
            }
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewProductButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
