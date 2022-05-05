$(function () {

    var l = abp.localization.getResource('InventoryManagement');

    var service = inventoryManagement.categories.warehouseManager.units;
    var createModal = new abp.ModalManager(abp.appPath + 'Categories/WarehouseManager/Units/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Categories/WarehouseManager/Units/EditModal');

    var dataTable = $('#UnitsTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: true,
        autoWidth: false,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('InventoryManagement.Units.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('InventoryManagement.Units.Delete'),
                                confirmMessage: function (data) {
                                    return l('UnitsDeletionConfirmationMessage', data.record.id);
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
                title: l('UnitsName'),
                data: "name"
            },
            {
                title: l('UnitsSymbol'),
                data: "symbol"
            },
            //{
            //    title: l('UnitsLevel'),
            //    data: "level"
            //},
            {
                title: l('UnitsNote'),
                data: "note"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewUnitsButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
