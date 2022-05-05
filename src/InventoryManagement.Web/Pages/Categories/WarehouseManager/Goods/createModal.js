var abp = abp || {};
abp.modals.goodsCreateModal = function () {
    var initModal = function (publicApi, args) {
        var l = abp.localization.getResource('InventoryManagement');

        var service = inventoryManagement.categories.warehouseManager.units;

        var unitLeftDataTable = $('#UnitLeftTable').DataTable({
            processing: true,
            paging: false,
            searching: false,
            autoWidth: false,
            scrollCollapse: true,
            info: false,
            order: false,
            columns: [
                {
                    title: l('UnitsName'),
                    data: "name"
                },
                {
                    width: '10%',
                    targets: -1,
                    render: function (data, type, row, meta) {
                        return '<button class="moveToRight btn btn-secondary">=></button>';
                    }
                },
            ]
        });

        var unitRightDataTable = $('#UnitRightTable').DataTable({
            processing: true,
            paging: false,
            searching: false,
            autoWidth: false,
            scrollCollapse: true,
            info:false,
            order: false,
            columns: [
                {
                    width: '10%',
                    targets: -1,
                    render: function (data, type, row, meta) {
                        return '<button class="moveToLeft btn btn-secondary"><=</button>';
                    }
                },
                {
                    title: l('UnitsName'),
                    data: "name"
                },
            ]
        });

        service.getUnitForLeftTable().done(function (data) {
            data.items.forEach(function (e) {
                unitLeftDataTable.row.add(e).draw();
            });
        });

        $('#UnitRightTable').on('click', 'button.moveToLeft', function (e) {
            e.preventDefault();
            var rowValue = unitRightDataTable.row($(this).parents('tr')).data();
            var unitOfGoodVal = $('#ViewModel_UnitOfGood').val();
            var unitOfGoodValChanged = unitOfGoodVal.replace(',' + rowValue.id, '');
            unitOfGoodValChanged = unitOfGoodValChanged.replace(rowValue.id, '');
            $('#ViewModel_UnitOfGood').val(unitOfGoodValChanged);
            unitLeftDataTable.row.add(rowValue).draw();
            unitRightDataTable.row($(this).parents('tr')).remove().draw();
        });

        $('#UnitLeftTable').on('click', 'button.moveToRight', function (e) {
            e.preventDefault();
            var rowValue = unitLeftDataTable.row($(this).parents('tr')).data();
            console.log(unitLeftDataTable.row($(this).parents('tr')).data());
            if ($('#ViewModel_UnitOfGood').val() == '') {
                $('#ViewModel_UnitOfGood').val(rowValue.id);
            } else {
                var unitOfGoodVal = $('#ViewModel_UnitOfGood').val() + ',' + rowValue.id;
                $('#ViewModel_UnitOfGood').val(unitOfGoodVal);
            }
            unitRightDataTable.row.add(rowValue).draw();
            unitLeftDataTable.row($(this).parents('tr')).remove().draw();
        })
    };

    return {
        initModal: initModal
    };
};