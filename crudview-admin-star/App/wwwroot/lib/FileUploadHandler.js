ko.bindingHandlers.fileUpload = {
    datakey: null,
    init: function (element, valueAccessor) {
        $(element).after('<div class="progress"><div class="bar"></div><div class="percent">0%</div></div><div class="progressError"></div>');
    },
    update: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
        var options = ko.utils.unwrapObservable(valueAccessor());
        var url = ko.utils.unwrapObservable(options.url);
        var dataContent = ko.utils.unwrapObservable(options.dataContent);

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
                        data: dataContent,
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

                            var parsedData = JSON.parse(data);

                            if (parsedData !== null && parsedData !== undefined) {
                                if (parsedData.content !== null && parsedData.content !== undefined) {

                                    $(".progressError").hide();
                                    bindingContext.$data[options.modelProperty](parsedData.content);
                                }
                            }
                            else {
                                $("div.progressError").html('File uploaded and saved, local model property is not set appropriately. Use modelProperty property that automatically set ko model member property.');
                            }
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