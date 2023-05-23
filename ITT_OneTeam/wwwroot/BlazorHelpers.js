
export var Helpers = {

    Confirm: async (title, message, icon ='question', confirmButtonText = 'Continue', confirmButtonColor = '#3085d6') => {

        var result = await Swal.fire({
            title: title,
            text: message,
            icon: icon,

            showCancelButton: true,
            cancelButtonColor: 'gray',

            confirmButtonColor: confirmButtonColor,
            confirmButtonText: confirmButtonText,
        });

        return (result.isConfirmed ? true : false);

    },

    ShowAlert: async (title, message, icon = null, footer = null, confirmButtonText = null) => {

        console.log(title, message, icon, footer);

        Swal.fire({
            icon: (icon == null) ? 'success' : icon,
            title: title,
            text: message,
            footer: footer,
            confirmButtonColor: '#0d6efd',
            confirmButtonText: (confirmButtonText == null) ? "Dismiss" : confirmButtonText,
        });

    },

    ShowToast: async (title, text = null, icon = 'info', position = 'bottom-end', timer = 6000) => {

        Swal.mixin({
            toast: true,
            position: position,
            showConfirmButton: false,
            timer: timer,
            timerProgressBar: true,
            didOpen: (toast) => {
                toast.addEventListener('mouseenter', Swal.stopTimer)
                toast.addEventListener('mouseleave', Swal.resumeTimer)
            }
        }).fire({
            icon: icon,
            title: title,
            text: text,
        });

    },

    GetTimezoneOffset: async () => {
        console.log(new Date().getTimezoneOffset());
        return new Date().getTimezoneOffset()
    },

    ImportCSS: async (fileUrl) => {

        document.getElementsByTagName('head')[0].insertAdjacentHTML(
            'beforeend',
            '<link rel="stylesheet" href="' + fileUrl + '" />');

    },

};