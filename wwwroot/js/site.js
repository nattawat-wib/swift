// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(()=>{
   $('#sidebar-toggle').click(function() {
       let btn_msg = $('#sidebar').hasClass('show-sidebar') ? 'MENU' : 'close'
       $(this).html(btn_msg)

       $('#sidebar').toggleClass('show-sidebar') 
   })

//    $.Thailand({ 
//         database: '/jquery-Thailand/jquery.Thailand.js/database/db.json', // path หรือ url ไปยัง database
//         $district: $('#district'), // input ของตำบล
//         $amphoe: $('#amphoe'), // input ของอำเภอ
//         $province: $('#province'), // input ของจังหวัด
//         $zipcode: $('#zipcode'), // input ของรหัสไปรษณีย์
//         autocomplete_size: 5,
//     });

    $('.js-delete-user').click(function (){
        const {user_id, user_name} = $(this).data()

        Swal.fire({
            title: 'Delete Account ?',
            html: `Are you sure you want to delete this account <br> <b> id : </b> ${user_id} <br> <b> name : </b> ${user_name}`,
            icon: 'warning',
            showDenyButton: true,
            confirmButtonText: '<i class="fas fa-check-circle"></i> CONFIRM',
            denyButtonText: ' <i class="fas fa-trash-alt"></i> CANCEL',
            confirmButtonColor: '#39c0ed',
        }).then(res => {
            if (res.isConfirmed) Swal.fire({title: 'SUCCESS',  icon: 'success', confirmButtonColor: '#39c0ed', showConfirmButton: false})
        })
    })
})
