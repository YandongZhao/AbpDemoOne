$(function () {
    $('#ReturnUrlHash').val(location.hash);

    var $loginForm = $('#LoginForm');

   

    $loginForm.submit(function (e) {
        e.preventDefault();
        
        debugger;
        abp.ajax({
            contentType: 'application/x-www-form-urlencoded',
            url: $loginForm.attr('action'),
            data: $loginForm.serialize()
        })
    });
    

    //$loginForm.find('input[type=text]:first-child').focus();
});
