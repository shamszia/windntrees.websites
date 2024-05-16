ko.bindingHandlers.fileUpload = {
    init: function (element, valueAccessor) {
        $(element).after('<div class="progress"><div class="bar"></div><div class="percent">0%</div></div><div class="progressError"></div>');
    },
    update: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
        var options = ko.utils.unwrapObservable(valueAccessor());
        var url = ko.utils.unwrapObservable(options.url);
        var keyField = ko.utils.unwrapObservable(options.keyField);
        var imageField = ko.utils.unwrapObservable(options.imageField);

        if (url !== null && url !== undefined && url !== "#") {
            $(element).change(function () {
                if (element.files.length) {
                    var $this = $(this),
                        fileName = $this.val();
                    // this uses jquery.form.js plugin
                    $(element.form).ajaxSubmit({
                        url: url,
                        type: "POST",
                        dataType: "text",
                        data: { "key": bindingContext.$data[keyField] },
                        headers: { "Content-Disposition": "attachment; filename=" + fileName },
                        beforeSubmit: function () {
                            $(".progress").show();
                            $(".progressError").hide();
                            $(".bar").width("0%")
                            $(".percent").html("0%");
                        },
                        uploadProgress: function (event, position, total, percentComplete) {
                            var percentVal = percentComplete + "%";
                            $(".bar").width(percentVal)
                            $(".percent").html(percentVal);
                        },
                        success: function (data) {
                            $(".progress").hide();
                            $(".progressError").hide();
                            // set viewModel property to filename
                            var parsedData = JSON.parse(data);
                            bindingContext.$data[imageField](parsedData.ImageFile());
                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                            $(".progress").hide();
                            $("div.progressError").html(jqXHR.responseText);
                        }
                    });
                }
            });
        }
    }
};