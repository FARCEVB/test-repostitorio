@ModelType Prueba_ASP.NET_MVC_5.eir_container
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
