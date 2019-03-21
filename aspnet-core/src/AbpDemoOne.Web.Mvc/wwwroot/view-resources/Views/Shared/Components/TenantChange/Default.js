(function () {
    $('.tenant-change-component a')
        .click(function (e) {
            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'Account/TenantChangeModal',
                type: 'GET',
                contentType: 'application/html',
                success: function (content) {
                    $('#TenantChangeModal div.modal-content').html(content);
                },
                error: function (e) {
                    console.log(e);
                    alert(e);
                    
                }
            });
        });
})();