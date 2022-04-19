$(function () {

    var l = abp.localization.getResource('InventoryManagement');

    var service = inventoryManagement.categories.productGroup.productGroup;
    var createModal = new abp.ModalManager(abp.appPath + 'Categories/ProductGroup/ProductGroup/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Categories/ProductGroup/ProductGroup/EditModal');

    var dataTable = $('#ProductGroupTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('InventoryManagement.ProductGroup.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('InventoryManagement.ProductGroup.Delete'),
                                confirmMessage: function (data) {
                                    return l('ProductGroupDeletionConfirmationMessage', data.record.id);
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
                //title: l('ProductGroupproductGroupName'),
                data: "productGroupName"
            },
            {
                //title: l('ProductGroupproductGroupDescription'),
                data: "productGroupDescription"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewProductGroupButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
