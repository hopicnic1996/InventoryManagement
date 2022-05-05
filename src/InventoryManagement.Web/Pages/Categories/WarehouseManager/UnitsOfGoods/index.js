$(function () {

    var l = abp.localization.getResource('InventoryManagement');

    var service = inventoryManagement.categories.warehouseManager.unitsOfGoods;
    var createModal = new abp.ModalManager(abp.appPath + 'Categories/WarehouseManager/UnitsOfGoods/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Categories/WarehouseManager/UnitsOfGoods/EditModal');

    var dataTable = $('#UnitsOfGoodsTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('InventoryManagement.UnitsOfGoods.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('InventoryManagement.UnitsOfGoods.Delete'),
                                confirmMessage: function (data) {
                                    return l('UnitsOfGoodsDeletionConfirmationMessage', data.record.id);
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
                title: l('UnitsOfGoodsUnitId'),
                data: "unitId"
            },
            {
                title: l('UnitsOfGoodsUnitName'),
                data: "unitName"
            },
            {
                title: l('UnitsOfGoodsGoodsId'),
                data: "goodsId"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewUnitsOfGoodsButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
