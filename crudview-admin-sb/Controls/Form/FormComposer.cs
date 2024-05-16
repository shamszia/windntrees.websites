using Microsoft.AspNetCore.Html;
using System;

namespace Controls.Core.Form
{
    /// <summary>
    /// Form composer control.
    /// </summary>
    public class FormComposer
    {   
        /// <summary>
        /// Composes HTML form based on form id, content and form actions.
        /// </summary>
        /// <param name="dialogFormId">This is form id.</param>
        /// <param name="content">These are content input and or result output fields.</param>
        /// <param name="actions">These are form submission buttons.</param>
        /// <returns></returns>
        public static HtmlString composeForm(string dialogFormId, string formObject = null, string title = null, string formTitle = null, string content = null, string actions = null, string createFunction = null, string updateFunction = null, string scopeObject = null, bool modal = true, bool display = false, bool includeFormElement = true, string formElementId = "__uploadform", bool submitButton = true)
        {   
            string modalFormAttributes = string.Empty;
            string modalFormCrossButton = string.Empty;
            string formCloseButton = string.Empty;
            string formOkButton = string.Empty;
            string modalDialogAttributes = string.Empty;
            string modalContentAttributes = string.Empty;

            if (modal)
            {
                //modal form then take on following inputs
                modalFormAttributes = " class='modal fade' tabindex='-1' role='dialog' aria-labelledby='myModalLabel' aria-hidden='true' " + (display ? "" : " style='display: none;' ");
                modalFormCrossButton = "<button tabindex=-10 type = 'button' class='col order-1 close d-flex justify-content-end' data-dismiss='modal'> <span aria-hidden='true'>&times;</span><span class='sr-only'>" + SharedLibrary.Core.Resources.Global.FormMessages.Close + "</span></button> ";
                formCloseButton = "<button type = 'button' id ='btnCloseAddForm' class='btn btn-sm btn-default' data-dismiss='modal'><span>Close</span></button>";
                formOkButton = "<button type = 'button' id='btnOK' class='btn btn-sm btn-primary' data-dismiss='modal'> <span>" + SharedLibrary.Core.Resources.Global.FormMessages.Done + "</span></button>";
                modalDialogAttributes = "class='modal-dialog modal-dialog-centered'";
                modalContentAttributes = "class='modal-content'";
            }
            else
            {
                formCloseButton = "<button type = \"button\" onclick=\"javascript: $('#" + dialogFormId + "').dialog('close');\" id=\"btnCloseAddForm\" class=\"btn btn-sm btn-default\"><span>" + SharedLibrary.Core.Resources.Global.FormMessages.Close + "</span></button>";
                formOkButton = "<button type = \"button\" onclick=\"javascript: $('#" + dialogFormId + "').dialog('close');\" id=\"btnOK\" class=\"btn btn-sm btn-primary\"><span>" + SharedLibrary.Core.Resources.Global.FormMessages.Done + "</span></button>";
            }

            //form content
            string formContent = "<div class='form-group form-group-sm'> " +
                                        "   <div class='col-sm-12 col-md-3 col-lg-3'> " +
                                        "       <label class='control-label' for='Name'> " +
                                        "           <span>" + SharedLibrary.Core.Resources.Global.FormMessages.FieldName + "</span> " +
                                        "       </label> " +
                                        "       <input data-bind='value: $parent.EditMode() ? name : name' id='Name' type='text' title='" + SharedLibrary.Core.Resources.Global.FormMessages.FieldNameD + "' maxlength='50' placeholder='' class='form-control' /><span class='error' data-bind='validationMessage: name'></span> " +
                                        "   </div> " +
                                        "   <div class='col-sm-12 col-md-9 col-lg-9'> " +
                                        "       <label class='control-label' for='Description'> " +
                                        "           <span>" + SharedLibrary.Core.Resources.Global.FormMessages.FieldDescription + "</span> " +
                                        "       </label> " +
                                        "       <input data-bind='value: $parent.EditMode() ? description : description' id='Description' type='text' title='" + SharedLibrary.Core.Resources.Global.FormMessages.FieldDescriptionD + "' maxlength='200' placeholder='' class='form-control' /><span class='error' data-bind='validationMessage: description'></span> " +
                                        "   </div> " +
                                        "</div> " +
                                        "<div class='clear-fix'> " +
                                        "</div> ";

            formContent = content != null ? content : formContent;

            scopeObject = scopeObject == null ? "" : scopeObject;


            createFunction = createFunction == null ? "create()" : createFunction;
            updateFunction = updateFunction == null ? "update()" : updateFunction;

            createFunction = scopeObject + createFunction;
            updateFunction = scopeObject + updateFunction;
            string editMode = scopeObject + "getEditMode()";

            string buttonType = (submitButton ? "submit" : "button");

            //form actions
            string saveActions = "<div>" + formCloseButton +
                                    "   <button type = '" + buttonType + "' data-bind='click: function() { " + editMode +" ? " + updateFunction + " : " + createFunction + "; }' id='btnAddEdit' class='btn btn-sm btn-primary'>  " +
                                    "       <span>" + SharedLibrary.Core.Resources.Global.FormMessages.Save + "</span>  " +
                                    "   </button>  " +
                                    "</div>";

            //form ok
            string uploadActions = string.Format("{0}{1}", formCloseButton, formOkButton);
            //form ok
            string viewActions = string.Format("{0}{1}", formCloseButton, formOkButton);

            String formActions = saveActions;
            if (actions != null)
            {
                if (actions.Equals("save"))
                {
                    formActions = saveActions;
                }
                else if (actions.Equals("upload"))
                {
                    formActions = uploadActions;
                }
                else if (actions.Equals("view"))
                {
                    formActions = viewActions;
                }
                else
                {
                    formActions = actions;
                }
            }

            if (title == null)
            {
                title = "";
            }

            if (formTitle == null)
            {
                formTitle = "<span data-bind='text: getEditMode() ? getEditModeCaption() : getNewModeCaption()'></span>";
            }

            formObject = formObject == null ? "data-bind='with: getObservableFormObject()'" : formObject;

            var messages = string.Format("<span class='col-sm-12 col-md-10 col-lg-10 order-first {0}' data-bind=\"template: {{name: 'results_messages'}}\"></span>", (modal ? "result-modal" : "result"));
            var status = "<span class='col-sm-12 col-md-2 col-lg-2 order-last status' data-bind=\"template: {name: 'results_processing'}\"></span>";

            //form
            string form = "<div id='" + dialogFormId + "' " + modalFormAttributes + " title='" + title + "' > " +
                                (includeFormElement ? "    <form id='" + formElementId + "' >" : "") +
                                "    <div id = '" + dialogFormId + "DialogAttributes' " + modalDialogAttributes + "> " +
                                "        <div id = '" + dialogFormId + "ContentAttributes' " + modalContentAttributes + "> " +
                                "            <div class='modal-header'> " +
                                "                <h4 class='modal-title order-0 d-flex justify-content-start' id='modalFormLabel'> " +
                                                            formTitle +
                                "                </h4> " +
                                                    modalFormCrossButton +
                                "            </div> " +
                                "            <div class='modal-body'> " +
                                "               <div class='row' data-bind='visible: (RequestProgress() > 0 &&  RequestProgress() < 100)'> " +
                                "                   <div class='col-sm-12 col-md-12 col-lg-12 progress' style='display: flex' data-bind=\"template: {name: 'request_progress'}\"></div> " +
                                "               </div> " +
                                "               <div class='row'> " +
                                                    messages +
                                                    status +
                                "               </div> " +
                                "               <div class='row'>" +
                                "                   <div class='col-sm-12 col-md-12 col-lg-12' data-bind='if: Errors().length > 0'> " +
                                "                       <ul class='errorlist' data-bind=\"template: {name: 'list_error_messages', foreach: Errors}\"></ul> " +
                                "                   </div> " +
                                "               </div>" +
                                "               <div " + formObject + " > " +
                                                        formContent + // form content
                                "               </div> " +
                                "            </div> " +
                                "            <div class='modal-footer'> " +
                                                    formActions + // form actions
                                "            </div> " +
                                "        </div> " +
                                "    </div> " +
                                (includeFormElement ? "    </form>" : "") +
                                "</div> ";

            return new HtmlString(form);
        }
    }
}
