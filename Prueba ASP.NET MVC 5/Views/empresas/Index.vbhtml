@ModelType IEnumerable(Of Prueba_ASP.NET_MVC_5.empresa)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.empresa_nombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.empresa_nombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.empresa1 }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.empresa1 }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.empresa1 })
        </td>
    </tr>
Next

</table>
