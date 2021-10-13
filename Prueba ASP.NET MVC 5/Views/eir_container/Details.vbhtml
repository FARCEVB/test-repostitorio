@ModelType Prueba_ASP.NET_MVC_5.eir_container
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>eir_container</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.contenedor)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.contenedor)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.sello)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.sello)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.empresa1.empresa_nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.empresa1.empresa_nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.responsable1.responsable_nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.responsable1.responsable_nombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.eir }) |
    @Html.ActionLink("Back to List", "Index")
</p>
