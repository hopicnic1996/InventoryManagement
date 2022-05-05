$(function () {

    var l = abp.localization.getResource('InventoryManagement');

    var service = inventoryManagement.categories.warehouseManager.goods;
    //var createModal = new abp.ModalManager(abp.appPath + 'Categories/WarehouseManager/Goods/CreateModal');
    var createModal = new abp.ModalManager({
        viewUrl: abp.appPath + 'Categories/WarehouseManager/Goods/CreateModal',
        modalClass: 'goodsCreateModal',
    });
    var editModal = new abp.ModalManager(abp.appPath + 'Categories/WarehouseManager/Goods/EditModal');

    var dataTable = $('#GoodsTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('InventoryManagement.Goods.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('InventoryManagement.Goods.Delete'),
                                confirmMessage: function (data) {
                                    return l('GoodsDeletionConfirmationMessage', data.record.id);
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
                title: l('GoodsGoodsName'),
                data: "goodsName"
            },
            //{
            //    title: l('GoodsGoodsCode'),
            //    data: "goodsCode"
            //},
            {
                title: l('GoodsNote'),
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

    $('#NewGoodsButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
