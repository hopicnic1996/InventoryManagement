$(function () {

    var l = abp.localization.getResource('InventoryManagement');

    var service = inventoryManagement.categories.warehouseManager.warehouse;
    var createModal = new abp.ModalManager(abp.appPath + 'Categories/WarehouseManager/Warehouse/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Categories/WarehouseManager/Warehouse/EditModal');

    var dataTable = $('#WarehouseTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getListAll),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('InventoryManagement.Warehouse.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('InventoryManagement.Warehouse.Delete'),
                                confirmMessage: function (data) {
                                    return l('WarehouseDeletionConfirmationMessage', data.record.id);
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
                title: l('WarehouseWarehouseName'),
                data: "warehouseName"
            },
            {
                title: l('WarehouseWarehouseAddress'),
                data: "warehouseAddress"
            },
            {
                title: l('WarehouseWarehouseNote'),
                data: "warehouseNote"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewWarehouseButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
