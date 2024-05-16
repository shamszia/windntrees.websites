using Microsoft.AspNetCore.Html;
using System;

namespace Controls.Core.Grid
{
    /// <summary>
    /// Grid composer control.
    /// </summary>
    public class GridComposer
    {
        /// <summary>
        /// Composes grid related basic views HTML content.
        /// </summary>
        /// <param name="formId">This is form id that is integrated within content.</param>
        /// <returns></returns>
        public static HtmlString composeBasicViews(string formId, bool modalForm = true, string newDialogAttributes = null, string editDialogAttributes = null)
        {
            string newFormAttributes = "data-bind=\"click: function(data, event) { resetForm(); }\" class='btn btn-sm btn-default btn-default-custom' data-toggle='modal' data-target='" + formId + "'";
            string editFormAttributes = "data-bind=\"click: function(data, event) { $parent.resetFormForEditing($index); }\" data-toggle='modal' data-target='" + formId + "'";

            if (!modalForm)
            {
                newFormAttributes = "data-bind=\"click: function(data, event) { resetForm(); $('" + formId + "').dialog('open'); }\" class='btn btn-sm btn-default btn-default-custom'";
                editFormAttributes = "data-bind=\"click: function(data, event) { $parent.resetFormForEditing($index); $('" + formId + "').dialog('open'); }\"";
            }

            newFormAttributes = newDialogAttributes != null ? newDialogAttributes : newFormAttributes;
            editFormAttributes = editDialogAttributes != null ? editDialogAttributes : editFormAttributes;

            string basicViews = "<section> " +
                                    "  <script type = 'text/html' id = 'actions'> " +
                                    "      <div class='form-group'> " +
                                    "       <div class='input-group'> " +
                                    "            <span class='input-group-btn'> " +
                                    "                <button " + newFormAttributes + " title='" + SharedLibrary.Core.Resources.Global.FormMessages.NewD + "'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.New + "</span></button> " +
                                    "            </span> " +
                                    "            <input data-bind='value: Keyword' type='text' placeholder='" + SharedLibrary.Core.Resources.Global.FormMessages.Keyword + "' class='form-control-sm form-control-sm-custom' /> " +
                                    "            <span class='input-group-btn'> " +
                                    "                <button data-bind='click: function() { find(1); }' class='btn btn-sm btn-default btn-default-custom' type='button' title='" + SharedLibrary.Core.Resources.Global.FormMessages.SearchD + "'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.Search + "</span></button> " +
                                    "            </span> " +
                                    "        </div> " +
                                    "    </div> " +
                                    "    <br /> " +
                                    "</script> " +

                                    "<script type = 'text/html' id='headings'> " +
                                    "    <tr> " +
                                    "        <th class='col-5'> " +
                                    "            <span title='" + SharedLibrary.Core.Resources.Global.FormMessages.FieldNameD + "'> " + SharedLibrary.Core.Resources.Global.FormMessages.FieldName + " </span> " +
                                    "        </th> " +
                                    "        <th class='col-5'> " +
                                    "            <span title='" + SharedLibrary.Core.Resources.Global.FormMessages.FieldDescriptionD + "'> " + SharedLibrary.Core.Resources.Global.FormMessages.FieldDescription + " </span> " +
                                    "        </th> " +
                                    "        <th class='col-2'>&nbsp;</th> " +
                                    "    </tr> " +
                                    "</script> " +

                                    "<script type = 'text/html' id='rows'> " +
                                    "    <tr> " +
                                    "        <td data-bind='text: name()'></td> " +
                                    "        <td data-bind='text: description()'></td> " +
                                    "        <td> " +
                                    "            <div class='hidden-phone visible-desktop action-buttons'> " +
                                    "                <a class='green' href='#' " + editFormAttributes + " title='" + SharedLibrary.Core.Resources.Global.FormMessages.EditD + "'><i class='fa fa-edit text-success'></i><span>" + SharedLibrary.Core.Resources.Global.FormMessages.Edit + "</span></a><br /> " +
                                    "                <a class='red' href='#' data-bind='click: function(data, event) { $parent.delete($data); }' title='" + SharedLibrary.Core.Resources.Global.FormMessages.DeleteD + "'><i class='fa fa-times text-danger'></i><span>" + SharedLibrary.Core.Resources.Global.FormMessages.Delete + "</span></a> " +
                                    "            </div> " +
                                    "        </td> " +
                                    "    </tr> " +
                                    "</script> " +

                                    "<script type = 'text/html' id='standard_listings'> " +
                                    "    <div class='col-2' style='margin-top:20px;'> " +
                                    "        <div class='input-group' dir='ltr'> " +
                                    "            <span class='input-group-addon'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.ListSize + "</span></span> " +
                                    "            <select class='' data-bind='value: ListSize, event: {change: function() { find(CurrentList()); }}'> " +
                                    "                <option value = '10'> 10 </option> " +
                                    "                <option value='20'>20</option> " +
                                    "                <option value = '50'> 50 </option> " +
                                    "                <option value='100'>100</option> " +
                                    "            </select> " +
                                    "        </div> " +
                                    "    </div> " +

                                    "    <div class=''> " +
                                    "        <div class='input-group'> " +
                                    "            <ul class='gridlist' data-bind='if: ListNavigator().calculateTotalPages() > 1'> " +
                                    "                <li class='input-group-addon' data-bind='css: {disabled: CurrentList() == 1}'><a href = '#' data-bind='click: function(){ if (CurrentList() > 1) {find(CurrentList() - 1); } }'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.PrevPage + "</span></a></li> " +
                                    "                <li class='input-group-addon'><select data-bind=\"value: CurrentList, options: ListNavigator().getLists(), optionsText: 'Number', optionsValue:'Number', event: {change: function() { find(CurrentList()); }}\" class='' /></li> " +
                                    "                <li class='input-group-addon' data-bind='css: {disabled: CurrentList() == ListNavigator().calculateTotalPages()}'><a href = '#' data-bind='click: function(){ if (CurrentList() <ListNavigator().calculateTotalPages()) {find(CurrentList() + 1); } }'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.NextPage + "</span></a></li> " +
                                    "            </ul> " +
                                    "        </div> " +
                                    "    </div> " +
                                    "</script> " +

                                    "<script type = 'text/html' id='detail_listings'> " +
                                    "    <div class='col-2' style='margin-top:20px;'> " +
                                    "        <div class='input-group' dir='ltr'> " +
                                    "            <span class='input-group-addon'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.ListSize + "</span></span> " +
                                    "            <select class='' data-bind=\"value: ListSize, event: {change: function() { selectDetail({'record': $parents[0].getContextualMasterKeyRecord(), 'page': CurrentList(), 'navigation': true }); }}\"> " +
                                    "                <option value = '10'> 10 </option> " +
                                    "                <option value='20'>20</option> " +
                                    "                <option value = '50'> 50 </option> " +
                                    "                <option value='100'>100</option> " +
                                    "            </select> " +
                                    "        </div> " +
                                    "    </div> " +

                                    "    <div class=''> " +
                                    "        <div class='input-group'> " +
                                    "            <ul class='gridlist' data-bind='if: ListNavigator().calculateTotalPages() > 1'> " +
                                    "                <li class='input-group-addon' data-bind='css: {disabled: CurrentList() == 1}'><a href = '#' data-bind=\"click: function(){ if (CurrentList() > 1) { selectDetail({'record': $parents[0].getContextualMasterKeyRecord(), 'page': CurrentList() - 1, 'navigation': true}); }}\"><span>" + SharedLibrary.Core.Resources.Global.FormMessages.PrevPage + "</span></a></li> " +
                                    "                <li class='input-group-addon'><select data-bind=\"value: CurrentList, options: ListNavigator().getLists(), optionsText: 'Number', optionsValue:'Number', event: {change: function() { selectDetail({'record': $parents[0].getContextualMasterKeyRecord(), 'page': CurrentList(), 'navigation': true}); }}\" id='form-field-select-paging' class='' /></li> " +
                                    "                <li class='input-group-addon' data-bind='css: {disabled: CurrentList() == ListNavigator().calculateTotalPages()}'><a href = '#' data-bind=\"click: function(){ if (CurrentList() <ListNavigator().calculateTotalPages()) { selectDetail({'record': $parents[0].getContextualMasterKeyRecord(), 'page': CurrentList() + 1, 'navigation': true}); }}\"><span>" + SharedLibrary.Core.Resources.Global.FormMessages.NextPage + "</span></a></li> " +
                                    "            </ul> " +
                                    "        </div> " +
                                    "    </div> " +
                                    "</script> " +
                                    "</section> ";

            return new HtmlString(basicViews);
        }
        
        /// <summary>
        /// Composes list related standard HTML content submission widgets or Controls.Core.
        /// </summary>
        /// <param name="formId">This is form id that is integrated within content.</param>
        /// <returns></returns>
        public static HtmlString composeStandardActions(string actionId, string formId, Boolean readOnly = false, string searchAction = null, string searchActionParams = null, bool modalForm = true, string newDialogAttributes = null, string actionContentId = null, string searchLink = null)
        {
            string newFormAttributes = "data-bind='click: function(data, event) { resetForm(); }' class='btn btn-sm btn-default btn-default-custom' data-toggle='modal' data-target='" + formId + "'";

            if (!modalForm)
            {
                newFormAttributes = "data-bind=\"click: function(data, event) { resetForm(); $('" + formId + "').dialog('open'); }\" class='btn btn-sm btn-default btn-default-custom'";
            }

            newFormAttributes = newDialogAttributes != null ? newDialogAttributes : newFormAttributes;

            var readOnlyContent = "";
            if (!readOnly)
            {
                readOnlyContent = "<span class='d-flex justify-content-start'><button " + newFormAttributes + " title='" + SharedLibrary.Core.Resources.Global.FormMessages.NewD + "'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.New + "</span></button></span>";
            }

            actionId = actionId == null ? "actions" : actionId;

            actionContentId = actionContentId == null ? "" : actionContentId;

            searchAction = searchAction == null ? "find" : searchAction;
            searchAction = searchActionParams == null ? string.Format("{0}(1);", searchAction) : string.Format("{0}({1});", searchAction, searchActionParams);
            searchLink = searchLink != null ? searchLink : "";

            string collapseClass = searchLink.Length > 0 ? "collapse" : "";

            string standardActions = "<script type = 'text/html' id='" + actionId + "'> " +
                                            searchLink +
                                        "   <div class='row " + collapseClass + "' id='" + actionContentId + "'> " +
                                        "       <div class='col-sm-12 col-md-1 col-lg-1 order-0'>" +
                                                    readOnlyContent +
                                        "       </div>" +
                                        "        <div class='col-sm-12 col-md-10 col-lg-10 order-1'> " +
                                        "            <input id='Keyword' class='form-control-sm form-control-sm-custom col-12' data-bind='value: Keyword' type='text' placeholder='" + SharedLibrary.Core.Resources.Global.FormMessages.Keyword + "' /> " +
                                        "        </div> " +
                                        "        <div class='col-sm-12 col-md-1 col-lg-1 order-2'>" +
                                        "           <span class='d-flex justify-content-end portable-start'>" +
                                        "                <button data-bind='click: function() { " + searchAction + " }' class='btn btn-sm btn-default btn-default-custom' type='button' title='" + SharedLibrary.Core.Resources.Global.FormMessages.SearchD + "'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.Search + "</span></button> " +
                                        "           </span>" +
                                        "       </div>" +
                                        "    </div> " +
                                        "</script> ";
            return new HtmlString(standardActions);
        }

        /// <summary>
        /// Composes grid related standard listing content.
        /// </summary>
        /// <param name="formId">This is form id that is integrated within content.</param>
        /// <returns></returns>
        public static HtmlString composeStandardListing(string listingId, string formId, Boolean navLinks = false, string searchAction = null, string selectList = null, string nextList = null, string prevList = null, string postSelectionAction = null, bool hideNavLinks = false)
        {

            listingId = listingId == null ? "standard_listings" : listingId;

            searchAction = searchAction == null ? "find" : searchAction;

            var navSelectList = selectList == null ? "Number" : selectList;
            selectList = selectList == null ? "CurrentList()" : selectList;
            nextList = nextList == null ? "CurrentList() + 1" : nextList;
            prevList = prevList == null ? "CurrentList() - 1" : prevList;
            postSelectionAction = postSelectionAction == null ? "" : postSelectionAction;

            var selectAction = string.Format("{0}({1});{2}", searchAction, selectList, postSelectionAction);
            var navLinkSizeSelectList = string.Format("{0}({1});", searchAction, "CurrentList()", "");

            var navSelectAction = string.Format("{0}({1});{2}", searchAction, navSelectList, postSelectionAction);
            var searchActionNext = string.Format("{0}({1});{2}", searchAction, nextList, postSelectionAction);
            var searchActionPrev = string.Format("{0}({1});{2}", searchAction, prevList, postSelectionAction);

            var selectListings = "<div class='input-group justify-content-end' data-bind='if: ListNavigator().calculateTotalPages() > 1'> " +
                "<span class='input-group-prepend' data-bind='css: {disabled: CurrentList() == 1}'><a href = '#' data-bind='click: function(){ if (CurrentList() > 1) { " + searchActionPrev + " } }'><span class='form-control-sm input-group-text'>" + SharedLibrary.Core.Resources.Global.FormMessages.PrevPage + "</span></a></li> " +
                "<select class='' data-bind=\"value: CurrentList, options: ListNavigator().getLists(), optionsText: 'Number', optionsValue:'Number', event: {change: function() { " + selectAction + " }}\" id='form-field-select-paging' /> " +
                "<span class='input-group-append' data-bind='css: {disabled: CurrentList() == ListNavigator().calculateTotalPages()}'><a href = '#' data-bind='click: function(){ if (CurrentList() < ListNavigator().calculateTotalPages()) { " + searchActionNext + " } }'><span class='form-control-sm input-group-text'>" + SharedLibrary.Core.Resources.Global.FormMessages.NextPage + "</span></a></li> " +
                "</div>";

            var navListings = "<nav class=\"d-flex justify-content-end portable-start\" aria-label=\"Listings\">" +
                "<ul class=\"pagination\">" +
                "<li class=\"page-item\" data-bind=\"css: {disabled: CurrentList() == 1}\"><a class=\"page-link\" href=\"#\" data-bind=\"click: function() { " + searchActionPrev + " }\">" + SharedLibrary.Core.Resources.Global.FormMessages.PrevPage + "</a></li>" +
                "<!-- ko foreach: ListNavigator().getLists() -->" +
                "<li class=\"page-item\"><a class=\"page-link\" href=\"#\" data-bind=\"click: function() { " + string.Format("{0}.{1}", "$parent", navSelectAction) + " }\"><span data-bind=\"text: Number\"></span></a></li>" +
                "<!-- /ko -->" +
                "<li class=\"page-item\" data-bind=\"css: {disabled: CurrentList() == ListNavigator().calculateTotalPages()}\"><a class=\"page-link\" href=\"#\" data-bind=\"click: function() { " + searchActionNext + " }\">" + SharedLibrary.Core.Resources.Global.FormMessages.NextPage + "</a></li>" +
                "</ul>" +
                "</nav>";

            if (hideNavLinks) {

                navListings = "";
                selectListings = "";
            }

            var localeEnd = "";
            if (System.Globalization.CultureInfo.CurrentCulture.TextInfo.IsRightToLeft)
            {
                localeEnd = "locale-end";
            }

            string standardListing = "   <script type = 'text/html' id='" + listingId + "'> " +
                                        "   <div class='col order-first'> " +
                                        "        <div class='input-group justify-content-start "+ localeEnd +"' dir='ltr'> " +
                                        "            <span class='input-group-prepend'><span class='form-control-sm input-group-text'>" + SharedLibrary.Core.Resources.Global.FormMessages.ListSize + "</span></span> " +
                                        "            <select class='' data-bind=\"value: ListSize, event: {change: function() { " + (navLinks ? navLinkSizeSelectList : selectAction) + " }}\" id='form-field-select-1'> " +
                                        "                <option value = '10'> 10 </option> " +
                                        "                <option value ='20'>20</option> " +
                                        "                <option value = '50'> 50 </option> " +
                                        "                <option value ='100'>100</option> " +
                                        "                <option value ='500'>500</option> " +
                                        "                <option value ='1000'>1000</option> " +
                                        "                <option value ='5000'>5000</option> " +
                                        "                <option value ='10000'>10000</option> " +
                                        "            </select> " +
                                        "        </div> " +
                                        "    </div> " +

                                        "    <div class='col order-last'> " +
                                             (navLinks ? navListings : selectListings) +
                                        "    </div> " +
                                        "</script> ";

            return new HtmlString(standardListing);
        }

        /// <summary>
        /// Composes grid related detail HTML content submission widgets or Controls.Core.
        /// </summary>
        /// <param name="formId">This is form id that is integrated within content.</param>
        /// <returns></returns>
        public static HtmlString composeDetailActions(string formId)
        {
            string detailActions = "<section> " +
                                    "   <script type = 'text/html' id='detail_actions'> " +
                                    "        <div class='form-group'> " +
                                    "        <div class='input-group'> " +
                                    "            <span class='input-group-btn' data-bind='visible: $parents[0].getContextualMasterKeyRecord() === null'> " +
                                    "                <button data-bind='click: function() { resetForm(); }' class='btn btn-sm btn-default btn-default-custom' data-toggle='modal' data-target='" + formId + "' title='" + SharedLibrary.Core.Resources.Global.FormMessages.NewD + "'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.New + "</span></button> " +
                                    "            </span> " +
                                    "            <span class='input-group-btn' data-bind='visible: $parents[0].getContextualMasterKeyRecord() !== null'> " +
                                    "                <button data-bind=\"click: function() { resetDetailForm({ '_relatedrecordtype': 'level1-record-id', '_relatedrecordid': $parents[0].getContextualMasterKeyRecord().getKey() }); }\" class='btn btn-sm btn-default btn-default-custom' data-toggle='modal' data-target='" + formId + "' title='" + SharedLibrary.Core.Resources.Global.FormMessages.FieldNewDetailD + "'><span> " + SharedLibrary.Core.Resources.Global.FormMessages.FieldNewDetail + " </span></button> " +
                                    "            </span> " +
                                    "            <input class='form-control-sm form-control-sm-custom' data-bind='value: Keyword' type='text' placeholder='" + SharedLibrary.Core.Resources.Global.FormMessages.Keyword + "' /> " +
                                    "            <span class='input-group-btn' data-bind='visible: $parents[0].getContextualMasterKeyRecord() === null'> " +
                                    "                <button data-bind='click: function() { find(1); }' class='btn btn-sm btn-default btn-default-custom' type='button' title='" + SharedLibrary.Core.Resources.Global.FormMessages.SearchD + "'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.Search + "</span></button> " +
                                    "            </span> " +
                                    "            <span class='input-group-btn' data-bind='visible: $parents[0].getContextualMasterKeyRecord() !== null'> " +
                                    "                <button data-bind='click: function() { findDetail(1); }' class='btn btn-sm btn-default btn-default-custom' type='button' title='" + SharedLibrary.Core.Resources.Global.FormMessages.SearchD + "'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.Search + "</span></button> " +
                                    "            </span> " +
                                    "        </div> " +
                                    "    </div> " +
                                    "    <br /> " +
                                    "</script> " +
                                    "</section>";

            return new HtmlString(detailActions);
        }

        /// <summary>
        /// Composes grid related detail listing contents.
        /// </summary>
        /// <param name="formId">This is form id that is integrated within content.</param>
        /// <returns></returns>
        public static HtmlString composeDetailListing(string formId)
        {
            string detailListing = "<section> " +
                                    "  <script type = 'text/html' id='detail_listings'> " +
                                    "       <div class='col-2' style='margin-top:20px;'> " +
                                    "        <div class='input-group' dir='ltr' data-bind='visible: $parents[0].getContextualMasterKeyRecord() === null'> " +
                                    "            <span class='input-group-addon'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.ListSize + "</span></span> " +
                                    "            <select class='' data-bind='value: ListSize, event: {change: function() { find(CurrentList()); }}' id='form-field-select-1'> " +
                                    "                <option value = '10'> 10 </option> " +
                                    "                <option value ='20'>20</option> " +
                                    "                <option value = '50'> 50 </option> " +
                                    "                <option value ='100'>100</option> " +
                                    "            </select> " +
                                    "        </div>  " +
                                    "        <div class='input-group' dir='ltr' data-bind='visible: $parents[0].getContextualMasterKeyRecord() !== null' > " +
                                    "            <span class='input-group-addon'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.ListSize + "</span></span> " +
                                    "            <select class='' data-bind=\"value: ListSize, event: {change: function() { selectDetail({'record': $parents[0].getContextualMasterKeyRecord(), 'page': CurrentList(), 'navigation': true}); }}\" id='form-field-select-detail'> " +
                                    "                <option value = '10'> 10 </option> " +
                                    "                <option value ='20'>20</option> " +
                                    "                <option value = '50'> 50 </option> " +
                                    "                <option value ='100'>100</option> " +
                                    "            </select> " +
                                    "        </div> " +
                                    "    </div> " +

                                    "    <div class=''> " +
                                    "        <div class='input-group' data-bind='visible: $parents[0].getContextualMasterKeyRecord() === null'> " +
                                    "            <ul class='gridlist' data-bind='if: ListNavigator().calculateTotalPages() > 1'> " +
                                    "                <li class='input-group-addon' data-bind='css: {disabled: CurrentList() == 1}'><a href = '#' data-bind='click: function(){ if (CurrentList() > 1) {find(CurrentList() - 1); } }'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.PrevPage + "</span></a></li> " +
                                    "                <li class='input-group-addon'><select class='' data-bind=\"value: CurrentList, options: ListNavigator().getLists(), optionsText: 'Number', optionsValue:'Number', event: {change: function() { find(CurrentList()); }}\" id='form-field-select-paging' /></li> " +
                                    "                <li class='input-group-addon' data-bind='css: {disabled: CurrentList() == ListNavigator().calculateTotalPages()}'><a href = '#' data-bind='click: function(){ if (CurrentList() < ListNavigator().calculateTotalPages()) {find(CurrentList() + 1); } }'><span>" + SharedLibrary.Core.Resources.Global.FormMessages.NextPage + "</span></a></li> " +
                                    "            </ul> " +
                                    "        </div> " +
                                    "        <div class='input-group' data-bind='visible: $parents[0].getContextualMasterKeyRecord() !== null'> " +
                                    "            <ul class='gridlist' data-bind='if: ListNavigator().calculateTotalPages() > 1'> " +
                                    "                <li class='input-group-addon' data-bind='css: {disabled: CurrentList() == 1}'><a href = '#' data-bind=\"click: function(){ if (CurrentList() > 1) { selectDetail({'record': $parents[0].getContextualMasterKeyRecord(), 'page': CurrentList() - 1, 'navigation': true}); } }\"><span>" + SharedLibrary.Core.Resources.Global.FormMessages.PrevPage + "</span></a></li> " +
                                    "                <li class='input-group-addon'><select class='' data-bind=\"value: CurrentList, options: ListNavigator().getLists(), optionsText: 'Number', optionsValue:'Number', event: {change: function() { selectDetail({'record': $parents[0].getContextualMasterKeyRecord(), 'page': CurrentList(), 'navigation': true}); }}\" id='form-field-select-paging' /></li> " +
                                    "                <li class='input-group-addon' data-bind='css: {disabled: CurrentList() == ListNavigator().calculateTotalPages()}'><a href = '#' data-bind=\"click: function(){ if (CurrentList() < ListNavigator().calculateTotalPages()) { selectDetail({'record': $parents[0].getContextualMasterKeyRecord(), 'page': CurrentList() + 1, 'navigation': true}); }}\"><span>" + SharedLibrary.Core.Resources.Global.FormMessages.NextPage + "</span></a></li> " +
                                    "            </ul> " +
                                    "        </div> " +
                                    "    </div> " +
                                    "</script> " +
                                    "</section>";

            return new HtmlString(detailListing);
        }

        /// <summary>
        /// Composes HTML grid based on css class, title, content submission widgets (or actions), headings, rows and listing.
        /// </summary>
        /// <param name="cssClass">CSS styling class.</param>
        /// <param name="title">Grid title heading.</param>
        /// <param name="actions">Grid data action or submission widgets.</param>
        /// <param name="headings">Grid rows heading content.</param>
        /// <param name="rows">Grid rows data content</param>
        /// <param name="listing">Grid list customization content.</param>
        /// <returns></returns>
        public static HtmlString composeGrid(string gridId, string cssClass, string gridClass, string title, string formTitle, string actions, string headings, string rows, string summary, string listing, string messages = null, string status = null)
        {
            gridId = gridId == null ? "" : "id='" + gridId + "'";
            cssClass = cssClass == null ? "container" : cssClass;
            gridClass = gridClass == null ? "table table-hover grid-style-0" : gridClass;
            title = title == null ? "" : title;
            formTitle = formTitle == null ? "" : formTitle;
            actions = actions == null ? "<div data-bind=\"template: {name: 'actions'}\"></div>" : actions;
            headings = headings == null ? "<thead data-bind=\"template: {name: 'headings'}\"></thead>" : headings;
            rows = rows == null ? "<tbody data-bind =\"template: {name: 'rows', foreach: Records}\"></tbody>" : rows;
            listing = listing == null ? "<div class=\"row\" data-bind=\"template: {name: 'standard_listings' }\"></div>" : listing;
            summary = summary == null ? "" : summary;
            messages = messages == null ? "<span class='col-sm-12 col-md-11 col-lg-11 order-first result-grid' data-bind=\"template: {name: 'results_messages'}\"></span> " : messages;
            status = status == null ? "<span class='col-sm-12 col-md-1 col-lg-1 order-last status-grid' data-bind=\"template: {name: 'results_processing'}\"></span> " : status;

            string grid = "<div " + gridId + " class='page-content' title='" + title + "' > " +
                            "<div class='" + cssClass + "'> " + // css class
                                formTitle + // title
                            "   <div class='card'> " +
                            "       <div class='card-header'> " +
                            "           <div class='row'> " +
                                            messages +
                                            status +
                            "           </div> " +
                            "           <div class='row'>" +
                            "               <div class='col-12' data-bind='if: Errors().length > 0'> " +
                            "                   <ul class='errorlist' data-bind=\"template: {name: 'list_error_messages', foreach: Errors}\"></ul> " +
                            "               </div> " +
                            "           </div>" +
                            "       </div>" +
                            "       <div class='card-body'> " +
                                        actions + // actions
                            "           <div class='table-responsive'> " +
                            "               <table class='" + gridClass + "'> " +
                                                headings + // headings
                                                rows + // rows
                                                summary + // summary
                            "               </table> " +
                            "           </div> " +
                            "       </div> " +
                            "       <div class='card-footer'> " +
                                        listing + // listing
                            "       </div> " +
                            "   </div> " +
                            "</div> " +
                            "</div> ";

            return new HtmlString(grid);
        }
    }
}
