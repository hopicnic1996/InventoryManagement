$(function () {

    var l = abp.localization.getResource('InventoryManagement');

    var service = inventoryManagement.inventories.inventory.inventory;
    var createModal = new abp.ModalManager(abp.appPath + 'Inventories/Inventory/Inventory/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Inventories/Inventory/Inventory/EditModal');

    var dataTable = $('#InventoryTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('InventoryManagement.Inventory.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('InventoryManagement.Inventory.Delete'),
                                confirmMessage: function (data) {
                                    return l('InventoryDeletionConfirmationMessage', data.record.id);
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
                title: l('InventoryInventoryName'),
                data: "inventoryName"
            },
            {
                title: l('InventoryAddress'),
                data: "address"
            },
            {
                title: l('InventoryDescription'),
                data: "description"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewInventoryButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
