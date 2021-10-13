@ModelType IEnumerable(Of Prueba_ASP.NET_MVC_5.eir_container)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<center>
    <h2>Consultar EIR</h2></center>
    <table class="table" align="center">
        @For Each item In Model
            @<tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.eir)
                </th>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.eir)
                </td>
                <th>
                    @Html.DisplayNameFor(Function(model) model.contenedor)
                </th>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.contenedor)
                </td>
                <th>
                    @Html.DisplayNameFor(Function(model) model.sello)
                </th>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.sello)
                </td>
                <th>
                    @Html.DisplayNameFor(Function(model) model.empresa1.empresa_nombre)
                </th>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.empresa1.empresa_nombre)
                </td>
                <th>
                    @Html.DisplayNameFor(Function(model) model.responsable1.responsable_nombre)
                </th>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.responsable1.responsable_nombre)
                </td>
            </tr>
        Next
    </table>
