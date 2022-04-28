var abp = abp || {};

abp.modals.productCreateModal = function () {
    var initModal = function (publicApi, args) {
            var service = inventoryManagement.products.product.product;

        if ($('#ViewModel_UnitId').val() == '') {
            $('#addReferenceUnitBtn').prop('disabled', true);
        } else {
            $('#addReferenceUnitBtn').prop('disabled', false);
        }

        $('#addReferenceUnitBtn').on('click', function () {
            document.getElementById('referenceUnitForm').hidden = false;
            document.getElementById('addReferenceUnitBtn').hidden = true;
            document.getElementById('removeReferenceUnitBtn').hidden = false;
        });
        $('#removeReferenceUnitBtn').on('click', function () {
            document.getElementById('referenceUnitForm').hidden = true;
            document.getElementById('addReferenceUnitBtn').hidden = false;
            document.getElementById('removeReferenceUnitBtn').hidden = true;
        });

        $('#ViewModel_UnitId').on('change', function () {
            var currentId = $('#ViewModel_UnitId').val();

            if ($('#ViewModel_UnitId').val() == '') {
                $('#addReferenceUnitBtn').prop('disabled', true);
                document.getElementById('referenceUnitForm').hidden = true;
                document.getElementById('addReferenceUnitBtn').hidden = false;
                document.getElementById('removeReferenceUnitBtn').hidden = true;
            } else {
                $('#ViewModel_ReferenceUnitId').empty();

                var option = new Option('-', '');
                $('#ViewModel_ReferenceUnitId').append(option);
                service.getReferentceProductUnitLookup(currentId).done(function (data) {
                    $.each(data.items, function (index, value) {
                        option = new Option(value.unitName, value.id);
                        $('#ViewModel_ReferenceUnitId').append(option);
                        console.log(option);
                    });
                });
                $('#addReferenceUnitBtn').prop('disabled', false);
            }
        });
    };

    return {
        initModal: initModal
    };
};

////$(function () {
////    var service = inventoryManagement.products.product.product;

////    if ($('#ViewModel_UnitId').val() == '') {
////        $('#addReferenceUnitBtn').prop('disabled', true);
////    } else {
////        $('#addReferenceUnitBtn').prop('disabled', false);
////    }

////    $('#addReferenceUnitBtn').on('click', function () {
////        document.getElementById('referenceUnitForm').hidden = false;
////        document.getElementById('addReferenceUnitBtn').hidden = true;
////        document.getElementById('removeReferenceUnitBtn').hidden = false;
////    });
////    $('#removeReferenceUnitBtn').on('click', function () {
////        document.getElementById('referenceUnitForm').hidden = true;
////        document.getElementById('addReferenceUnitBtn').hidden = false;
////        document.getElementById('removeReferenceUnitBtn').hidden = true;
////    });

////    $('#ViewModel_UnitId').on('change', function () {
////        var currentId = $('#ViewModel_UnitId').val();

////        if ($('#ViewModel_UnitId').val() == '') {
////            $('#addReferenceUnitBtn').prop('disabled', true);
////            document.getElementById('referenceUnitForm').hidden = true;
////            document.getElementById('addReferenceUnitBtn').hidden = false;
////            document.getElementById('removeReferenceUnitBtn').hidden = true;
////        } else {
////            $('#ViewModel_ReferenceUnitId').empty();
            
////            var option = new Option('-', '');
////            $('#ViewModel_ReferenceUnitId').append(option);
////            service.getReferentceProductUnitLookup(currentId).done(function (data) {
////                $.each(data.items, function (index, value) {
////                    option = new Option(value.unitName, value.id);
////                    $('#ViewModel_ReferenceUnitId').append(option);
////                    console.log(option);
////                });
////            });
////            $('#addReferenceUnitBtn').prop('disabled', false);
////        }
////    });
////});