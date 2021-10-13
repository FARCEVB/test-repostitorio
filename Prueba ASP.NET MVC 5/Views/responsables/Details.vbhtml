﻿@ModelType Prueba_ASP.NET_MVC_5.responsable
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>responsable</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.responsable_nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.responsable_nombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.reponsable }) |
    @Html.ActionLink("Back to List", "Index")
</p>
