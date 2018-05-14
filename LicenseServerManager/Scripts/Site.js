$(document).ready(function () {
    $("#AcceptTermsButton").on("click", "", function () {
        if ($('#AcceptTermsCheckbox').is(':checked') == false) {
            //alert("Is terms accepted " + $('#AcceptTermsCheckbox').is(':checked'));
            BootstrapDialog.show({
                type: BootstrapDialog.TYPE_PRIMARY,
                title: 'Accept Terms & Conditions',
                message: 'You must accept the Terms and Conditions as stated in this form to be able to continue.',
                buttons: [{
                    label: 'OK',
                    cssClass: 'btn-primary',
                    action: function (dialogItself) {
                        dialogItself.close();
                    }
                }]
            });
        }
        else {
            window.location = "activation";
        }
    });

    $("#GetLicenseKey").on("click", "", function () {
        event.stopPropagation();
        //BootstrapDialog.alert('Getting the license key');


        var data = $('#ActivationKey').val();
        var url = "../../api/values?value=" + data;

        //request.Resource = "api/values?value=" + encodedData;
        //request.AddParameter("application/json", encodedData, ParameterType.RequestBody);
        //request.AddBody(encodedData);
        //IRestResponse response = client.Execute(request);

        //$.get(url, data, RetrieveLicenseKey, "text")

        $.ajax({
            type: "POST",
            url: url,
            data: data,
            success: function (value) {
                $('#LicenseKey').val(value);
                $('#LicenseKeyHelpText').removeClass('hidden');
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                BootstrapDialog.alert(XMLHttpRequest.responseText);
            }
        });
    });

    function success() {
        $('#LicenseKey').val('result');
    }

    function error() {
        BootstrapDialog.alert('Getting the license key');
    }
});

