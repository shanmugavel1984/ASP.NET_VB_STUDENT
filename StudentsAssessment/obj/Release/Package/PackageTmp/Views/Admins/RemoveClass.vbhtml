﻿@Code
    ViewData("Title") = "RemoveClass"
End Code

@ModelType StudentsAssessment.ClassData
<script src="~/Scripts/jquery-1.12.4.min.js"></script>

@*<link rel="stylesheet" media="screen" href="@Url.Content("~/Content/Superfish/src/css/superfish.css")">
    <link href="@Url.Content("~/Content/Superfish/css/superfish-vertical.css")" rel="stylesheet" />
    <script src="@Url.Content("~/Content/Superfish/js/jquery.js")"></script>
    <script src="@Url.Content("~/Content/Superfish/js/superfish.js")"></script>
    <script src="@Url.Content("~/Content/Superfish/js/hoverIntent.js")"></script>*@

<link href="~/Content/Superfish/css/superfish.css" rel="stylesheet" media="screen" />
<link href="~/Content/Superfish/css/superfish-vertical.css" rel="stylesheet" media="screen" />
<script src="~/Content/Superfish/js/jquery.js"></script>
<script src="~/Content/Superfish/js/superfish.js"></script>
<script src="~/Content/Superfish/js/hoverIntent.js"></script>

<h2>@Session("Greetings").ToString </h2>

<div class="row">
    <div class="col-sm-3"></div>
    <div class="col-sm-3" style="background-color:#fff;margin-top:50px;position:absolute;padding:5px;width:550px;">
        <div style="margin-left:25px;">
            <h3 style="text-align:center;">REMOVE CLASS</h3>
            <br /><br />
            @Using (Html.BeginForm())
                @Html.AntiForgeryToken()
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                @<table id="tblCreateClass" border="0" cellpadding="2" cellspacing="2" style="margin-top:-40px;">
                    <colgroup>
                        <col width="300" />
                        <col width="250" />
                    </colgroup>
                    <tr id="trClasses">
                        <td>
                            @Html.LabelFor(Function(model) model.ClassesList, htmlAttributes:=New With {.class = "control-label col-md-2", .style = "width:100%;"})
                        </td>
                        <td>
                            @Html.DropDownListFor(Function(model) model.SelectedClass, Model.ClassesList)
                            @Html.ValidationMessageFor(Function(model) model.SelectedClass, "", New With {.class = "text-danger"})
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align:center;">
                            <input type="submit" value="REMOVE" class="btn btn-success" />
                            <input type="button" id="Back" name="Back" value="Back" Class="btn btn-success" onclick="location.href='@Url.Action("Index", "Home")'" />

                        </td>
                    </tr>
                    <tr>

                        <td colspan="2">
                            @If String.IsNullOrEmpty(ViewBag.StatusMessage) = True Then
                                @<div id="divStatusMessage" class="field-validation-error">
                                    @ViewBag.StatusMessage
                                </div>
                            Else
                                @<div id="divStatusMessage" class="field-validation-error">
                                    @Html.Raw(ViewBag.StatusMessage)
                                </div>
                            End If
                        </td>
                    </tr>
                </table>
            End Using
        </div>

    </div>
    <div class="col-sm-3"></div>
    <div class="col-sm-3" style="margin-left:60%;margin-top:50px;position:absolute;">
        @Html.Partial("SideMenu")
    </div>
</div>

