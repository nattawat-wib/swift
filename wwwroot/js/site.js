$(document).ready(() => {
    // toggle sidebar ตอน modile
    $('#sidebar-toggle').click(function () {
        let btn_msg = $('#sidebar').hasClass('show-sidebar') ? 'MENU' : 'close'
        $(this).html(btn_msg)

        $('#sidebar').toggleClass('show-sidebar')
    })

    // From สมัครสมาชิก
    $('#register_btn').click(() => {

        const register_validate = () => {
            if ($('[name="Username"]').val().length < 3 || $('[name="Username"]').val().length > 12) return 'ชื่อต้องมีความยาวไม่ต่ำกว่า 3 ตัวอักษร และไม่เกิน 12 ตัวอักษร'

            //! เช็คค่าว่างงงงง ทุก field นะจ๊ะ
            for (let i = 0; i < $('[name]').length; i++) {
                let current_input = $('[name]')[i]
                $(current_input).attr('style', 'box-shadow: 0 0 0 0 transparent')

                if (current_input.value <= 0) {
                    console.log(current_input)
                    // $(current_input).attr('style', 'box-shadow: 2px 2px 2px 2px #ff0000')
                    $(current_input).attr('style', 'box-shadow: 0px 0px 3px 3px rgb(245,137,137);')
                    return (`กรุณากรอก ${$(current_input).attr('name')}`)
                }
            }

            //! ต้องติ๊ก checkbox นะจ๊ะ
            if (!$('[type="checkbox"]').is(":checked")) return 'Please accept our condition'

            return true
        }

        if (register_validate() === true) {
            Swal.fire({
                icon: 'success',
                title: 'Register successfully',
                confirmButtonText: 'Go to home page',
                confirmButtonColor: '#39c0ed',

            })
                .then(() => $('#form_register').submit())
        }
        else {
            Swal.fire({
                icon: 'error',
                title: 'ERORRR !!!',
                text: register_validate(),
                confirmButtonText: 'Close',
                confirmButtonColor: '#fc4c4c',
            })
        }
    })

    $('#testAPI').click(() => {
        axios.get('https://localhost:4001/Account/TestFunctionAjax').then(resp => {
            console.log(resp)
        })
    })

    // ส่งข้อมูลจาก form ลืมรหัสผ่าน
    $('#forget_password_btn').click(() => {

        $.post('https://localhost:4001/Account/ForgetPassword', { email: $('#forget_password_email').val() })
            .then(resp => {
                console.log(resp)
                Swal.fire({
                    icon: resp.status,
                    title: resp.status,
                    text: resp.msg,
                    confirmButtonText: 'close',
                    confirmButtonColor: '#39c0ed',
                }).then(() => {
                    // if (resp.status === 'success') location.reload()
                })
            })
    })

    // LOGIN
    $('#loginModal').submit((e) => {
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
            }).then(() => { if (resp.status === "success") location.reload() })
        })
        e.preventDefault()
    })

    // ออกจากระบบ
    $('#logout-btn').click(() => {
        $.get('https://localhost:4001/Account/Logout')
            .then((resp) => {
                console.log(resp)
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
                        console.log(resp)
                        Swal.fire({ title: resp.msg, icon: resp.status, confirmButtonColor: '#39c0ed' })
                            .then(() => { if (resp.status === 'success') location.reload() })
                    })
            }
        })
    })

    $('.edit-user').click(function () {
        $('#edit_user_modal').modal('show')
        let { id, name, email, occupation, income, telephone, address, facebook, ig } = $(this).data();

        $('.edit_user_modalLabel').html(`Edit user ID : ${id}`)

        $('[name="id"]').val(id)
        $('[name="username"]').val(name)
        $('[name="email"]').val(email)
        $('[name="occupation"]').val(occupation)
        $('[name="income"]').val(income)
        $('[name="telephone"]').val(telephone)
        $('[name="address"]').val(address)
        $('[name="facebook"]').val(facebook)
        $('[name="ig"]').val(ig)
    })

    $('.update-user').click(() => {
        const data = {
            id: $('[name="id"]').val(),
            email: $('[name="email"]').val(),
            occupation: $('[name="occupation"]').val(),
            income: $('[name="income"]').val(),
            telephone: $('[name="telephone"]').val(),
            address: $('[name="address"]').val(),
            facebook: $('[name="facebook"]').val(),
            ig: $('[name="ig"]').val(),
        }

        console.log(data)
        $.post('https://localhost:4001/Account/EditUser', data)
            .then((resp) => {
                console.log(resp)
                Swal.fire({
                    icon: resp.status,
                    title: resp.msg,
                    confirmButtonText: 'ปิด',
                    confirmButtonColor: '#39c0ed',
                }).then(() => { if (resp.status === "success") location.reload() })
            })
    })

    $('.change-password').click(() => {
        const password_data = {
            password: $('[name="password"]').val(),
            newPassword: $('[name="newPassword"]').val(),
            newPasswordConfirm: $('[name="newPasswordConfirm"]').val()
        }

        $.post('https://localhost:4001/Account/ChangePassword', password_data)
            .then((resp) => {
                console.log(resp)
                Swal.fire({
                    icon: resp.status,
                    title: resp.status,
                    text: resp.msg,
                    confirmButtonText: 'ปิด',
                    confirmButtonColor: '#39c0ed',
                }).then(() => { if (resp.status === "success") location.reload() })
            })        
    })
})