@ModelType IEnumerable(Of Prueba_ASP.NET_MVC_5.responsable)
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
            @Html.DisplayNameFor(Function(model) model.responsable_nombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.responsable_nombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.reponsable }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.reponsable }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.reponsable })
        </td>
    </tr>
Next

</table>
