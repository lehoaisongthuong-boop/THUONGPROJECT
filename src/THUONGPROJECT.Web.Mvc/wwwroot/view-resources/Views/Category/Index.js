(function ($) {
    $(document).ready(function () {

        var _categoryService = abp.services.app.category;
        var _$tableBody = $('#categoryTable tbody');
        var _$modal = $('#CategoryCreateModal');
        var _$form = _$modal.find('form');

        // 1. Hàm lấy dữ liệu
        function getCategories() {
            var keyword = $('#txtSearchKeyword').val() || '';
            var sortingValue = $('#ddlSort').val() || '';

            console.log("Bắt đầu gửi lệnh xuống máy chủ. Sắp xếp theo: " + sortingValue);

           
            abp.ajax({
                url: '/api/services/app/Category/GetAll', // Đường dẫn thẳng tới Backend
                type: 'GET',
                data: {
                    keyword: keyword,
                    sorting: sortingValue,
                    maxResultCount: 999,
                    skipCount: 0
                }
            }).done(function (result) {
                _$tableBody.empty();
                $.each(result.items, function (index, category) {
                    var catName = category.name || category.Name;
                    var catDesc = category.description || category.Description || '';
                    var catId = category.id || category.Id;

                    var row = `<tr>
    <td class="pl-4 font-weight-bold text-dark">${catName}</td>
    <td class="text-muted" style="white-space: normal; max-width: 300px;">${catDesc}</td>
    <td class="text-center">
        <button class="btn btn-sm btn-outline-info btn-modern btn-edit shadow-sm mr-2" data-id="${catId}" title="Chỉnh sửa">
            <i class="fas fa-pen"></i>
        </button>
        <button class="btn btn-sm btn-outline-danger btn-modern btn-delete shadow-sm" data-id="${catId}" title="Xóa">
            <i class="fas fa-trash-alt"></i>
        </button>
    </td>
</tr>`;
                    _$tableBody.append(row);
                });
            });
        }

        getCategories();

        // 2. Nút tìm kiếm
        $('#btnSearch').click(function () {
            getCategories();
        });

        // 3. Nút mở Form Thêm Mới
        $('#btnCreateCategory').click(function () {
            _$form[0].reset();
            _$modal.modal('show');
        });

        // 4. Nút Lưu dữ liệu
        _$form.find('.save-button').click(function (e) {
            e.preventDefault();
            var categoryData = _$form.serializeFormToObject();

            abp.ui.setBusy(_$modal);
            _categoryService.create(categoryData).done(function () {
                _$modal.modal('hide');
                abp.notify.success('Đã thêm danh mục thành công!');
                getCategories();
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        // 5. Nút Xóa
        $(document).on('click', '.btn-delete', function () {
            var categoryId = $(this).attr("data-id");
            abp.message.confirm(
                "Bạn có chắc chắn muốn xóa danh mục này?",
                "Cảnh báo",
                function (isConfirmed) {
                    if (isConfirmed) {
                        _categoryService.delete({ id: categoryId }).done(function () {
                            abp.notify.info('Đã xóa thành công!');
                            getCategories();
                        });
                    }
                }
            );
        });

        // 6. CHỨC NĂNG BẬT BẢNG SỬA (Lấy dữ liệu cũ đổ vào Form)
        $(document).on('click', '.btn-edit', function () {
            var categoryId = $(this).attr("data-id");

            _categoryService.get({ id: categoryId }).done(function (result) {
                var _$editModal = $('#CategoryEditModal');
                var _$editForm = _$editModal.find('form');

                _$editForm.find('input[name=Id]').val(result.id);
                _$editForm.find('input[name=Name]').val(result.name || result.Name);
                _$editForm.find('textarea[name=Description]').val(result.description || result.Description);

                _$editModal.modal('show');
            });
        });

        // 7. CHỨC NĂNG LƯU DỮ LIỆU ĐÃ SỬA
        $('#CategoryEditModal').find('.save-button').click(function (e) {
            e.preventDefault();
            var _$editModal = $('#CategoryEditModal');
            var _$editForm = _$editModal.find('form');
            var categoryData = _$editForm.serializeFormToObject();

            abp.ui.setBusy(_$editModal);

            _categoryService.update(categoryData).done(function () {
                _$editModal.modal('hide');
                abp.notify.success('Cập nhật dữ liệu thành công!');
                getCategories();
            }).always(function () {
                abp.ui.clearBusy(_$editModal);
            });
        });
        $('#ddlSort').change(function () {
            getCategories();
        });
    });
  
})(jQuery);