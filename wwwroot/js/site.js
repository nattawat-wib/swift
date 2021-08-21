$(document).ready(() => {
    // toggle sidebar ตอน modile
    $('#sidebar-toggle').click(function () {
        let btn_msg = $('#sidebar').hasClass('show-sidebar') ? 'MENU' : 'close'
        $(this).html(btn_msg)

        $('#sidebar').toggleClass('show-sidebar')
    })

    // From สมัครสมาชิก
    $('#register_btn').click((e) => {
        if (fullFormValidate() == true) {
            Swal.fire({
                icon: 'success',
                title: 'Register successfully',
                confirmButtonText: 'Go to home page',
                confirmButtonColor: '#39c0ed',

            })
            .then(() => $('#form_register').submit())
        }
    })

    // ส่งข้อมูลจาก form ลืมรหัสผ่าน
    $('#forget_password_btn').click(() => {

        $.post('https://localhost:4001/Account/ForgetPassword', { email: $('#forget_password_email').val() })
            .then(resp => {
                Swal.fire({
                    icon: resp.status,
                    title: resp.status,
                    text: resp.msg,
                    confirmButtonText: 'close',
                    confirmButtonColor: '#39c0ed',
                }).then(() => {
                    if (resp.status === 'success') location.reload()
                })
            })
    })

    // LOGIN
    $('#loginModal').submit((e) => {
        e.preventDefault()

        const login_data = {
            Username: $('#login_username').val(),
            Password: $('#login_password').val()
        }

        $.post('https://localhost:4001/Account/LoginAction', login_data)
            .then(resp => {
                Swal.fire({
                    icon: resp.status,
                    title: resp.msg,
                    confirmButtonText: 'ปิด',
                    confirmButtonColor: '#39c0ed',
                }).then(() => { if (resp.status === "success") window.location.href = "/" })
            })
    })

    // ออกจากระบบ
    $('#logout-btn').click(() => {
        $.get('https://localhost:4001/Account/Logout')
            .then((resp) => {
                Swal.fire({
                    icon: resp.status,
                    title: resp.msg,
                    confirmButtonText: 'ปิด',
                    confirmButtonColor: '#39c0ed',
                }).then(() => { if (resp.status === "success") window.location.href = "/" })
            })
    })

    // modal ยืนยันการลบข้อมูลสมาชิก
    $('.delete-user').click(function () {
        const { user_id, user_name } = $(this).data()

        Swal.fire({
            title: 'Delete Account ?',
            html: `Are you sure you want to delete this account <br> <b> id : </b> ${user_id} <br> <b> name : </b> ${user_name}`,
            icon: 'warning',
            showDenyButton: true,
            confirmButtonText: '<i class="fas fa-check-circle"></i> CONFIRM',
            denyButtonText: ' <i class="fas fa-trash-alt"></i> CANCEL',
            confirmButtonColor: '#39c0ed',
        }).then(res => {
            if (res.isConfirmed) {
                $.post('https://localhost:4001/Admin/Delete', { id: user_id })
                    .then(resp => {
                        Swal.fire({ title: resp.msg, icon: resp.status, confirmButtonColor: '#39c0ed' })
                            .then(() => { if (resp.status === 'success') location.reload() })
                    })
            }
        })
    })

    $('.edit-user').click(function () {
        $('#edit_user_modal').modal('show')
        let { id, name, email, occupation, income, telephone, address, facebook, ig, dateofbirth } = $(this).data();

        $('.edit_user_modalLabel').html(`Edit user ID : ${id}`)
        $('[name="id"]').val(id)
        $('[name="username"]').val(name)
        $('[name="email"]').val(email)
        $(`[value="${occupation}"]`).attr('selected', true)
        $(`[value="${income}"]`).attr('selected', true)
        $('[name="telephone"]').val(telephone)
        $('[name="address"]').val(address)
        $('[name="facebook"]').val(facebook)
        $('[name="ig"]').val(ig)
        $('[name="dateOfBirth"]').val(dateofbirth)
    })

    $('.update-user').click(async (e) => {
        let result = await fullFormValidate()
        if (result) {
            const data = {
                id: $('[name="id"]').val(),
                email: $('[name="email"]').val(),
                occupation: $('[name="occupation"]').val(),
                income: $('[name="income"]').val(),
                telephone: $('[name="telephone"]').val(),
                address: $('[name="address"]').val(),
                dateOfBirth: $('[name="dateOfBirth"]').val(),
                facebook: $('[name="facebook"]').val(),
                ig: $('[name="ig"]').val(),
            }

            $.post('https://localhost:4001/Account/EditUser', data)
                .then((resp) => {
                    Swal.fire({
                        icon: resp.status,
                        title: resp.msg,
                        confirmButtonText: 'ปิด',
                        confirmButtonColor: '#39c0ed',
                    })
                    .then(() => { if (resp.status === "success") location.reload() })
                })
        }
        
    })

    $('.change-password').click(() => {
        const password_data = {
            password: $('[data-key-password]').val(),
            newPassword: $('[data-key-newPassword]').val(),
            newPasswordConfirm: $('[data-key-newPasswordConfirm]').val()
        }

        $.post('https://localhost:4001/Account/ChangePassword', password_data)
            .then((resp) => {
                Swal.fire({
                    icon: resp.status,
                    title: resp.status,
                    text: resp.msg,
                    confirmButtonText: 'ปิด',
                    confirmButtonColor: '#39c0ed',
                }).then(() => { if (resp.status === "success") location.reload() })
            })
    })


    //! ฟังก์ชันสำหรับ validate ฟอร์มทั้งหมด
    const fullFormValidate = async () => {
        var result = true;

        const respError = (me, msg) => {
            $(me).removeClass('valid')
            $(me).addClass('invalid')
            setTimeout(() => {
                $(me).parent().find('small').remove()
                $(me).after(`<small class="text-danger position-absolute"> ${msg} </small>`)
            }, 0)
            return msg
        }

        //! เช็คค่าว่างงงงง ทุก field นะจ๊ะ
        for (let i = 0; i < $('[name]').length; i++) {
            let current_input = $('[name]')[i]
            $(current_input).removeClass('invalid')
            $(current_input).addClass('valid')
            $(current_input).parent().find('small').remove()

            if (current_input.value <= 0) {
                result = 'กรุณากรอกข้อมูลให้ครบทุกช่อง'
                setTimeout(() => {

                    $(current_input).parent().find('small').remove()
                    $(current_input).after(`<small class="text-danger position-absolute"> กรุณากรอก ${$(current_input).attr('name')} </small>`)
                    $(current_input).removeClass('valid')
                    $(current_input).addClass('invalid')
                }, 0)
            }
        }

        //! สำหรับตอนสมัครเท่านั้น 
        const username = $('[data-validate-pk]');

        if(username.length > 0) {
            //! username ห้ามต่ำกว่า 3 และ ไม่เกิน 12
            if (username.val() && username.val().length < 3 || username.val().length > 12) result = respError(username, 'username ต้องมีความยาวไม่ต่ำกว่า 3 และไม่เกิน 12 ตัวอักษร')
            
            //! check pk  
            await $.post('https://localhost:4001/Account/IsUsernameExist', { value: username.val() })
            .then(resp => {
                if (!resp) result = respError(username, 'มี username นี้ในระบบแล้ว')
            })
        }

        //! ตรวจสอบฟอร์มอีเมล์
        const email = $('[name="email"]')
        const isEmailForm = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
        if (email.val() && !isEmailForm.test(email.val())) result = respError(email, 'รูปแบบอีเมล์ไม่ถูกต้อง')

        const tel = $('[name="telephone"]')
        if(tel.val().length < 10) result = respError(tel, 'รูปแบบเบอร์โทรศัพท์ไม่ถูกต้อง')

        //! ยืนยันรหัสผ่านไม่ตรง
        const pass = $('[name="password"]')
        const passConfirm = $('[name="passwordConfirm"]')
        if (passConfirm.val() && pass.val() !== passConfirm.val()) {
            $(pass).removeClass('valid')
            $(pass).addClass('invalid')
            result = respError(passConfirm, 'ยืนยันรหัสผ่านไม่ถูกต้อง')
        }

        //! ต้องติ๊ก checkbox นะจ๊ะ
        // if (!$('[type="checkbox"]').is(":checked")) return 'Please accept our condition'
        
        if (result === true) {
            return result
        }
        else {
            Swal.fire({
                icon: 'error',
                title: 'ERORRR !!!',
                text: result,
                confirmButtonText: 'Close',
                confirmButtonColor: '#fc4c4c',
            })
        }
    }

    $('[name]').on('keyup change', function () {
        if ($(this).val().length > 0) {
            $(this).removeClass('invalid')
            $(this).parent().find('small').remove()
        } else {
            $(this).addClass('invalid')
            $(this).removeClass('valid')
            $(this).parent().find('small').remove()
            $(this).after(`<small class="text-danger position-absolute"> กรุณากรอก ${$(this).attr('name')} </small>`)
        }
    })

    $(".datepicker").datepicker({
        maxDate: 0,
        dateFormat: 'dd/mm/yy'
    });

    //! check pk
    $('[data-validate-pk]').keyup(function () {
        $.post('https://localhost:4001/Account/IsUsernameExist', { value: $(this).val() })
            .then(resp => {
                if (!resp) {
                    $(this).removeClass('valid')
                    $(this).addClass('invalid')
                    $(this).parent().find('small').remove()
                    $(this).after(`<small class="text-danger position-absolute"> มี username นี้ในระบบแล้ว </small>`)
                }
            })
    })
})

