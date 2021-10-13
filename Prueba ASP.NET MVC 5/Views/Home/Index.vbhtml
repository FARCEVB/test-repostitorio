@ModelType IEnumerable(Of Prueba_ASP.NET_MVC_5.eir_container)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<p>
    <center>
        <h2>Consultar EIR</h2>
    </center>
</p>

    @Using Html.BeginForm("Index", "eir_container", FormMethod.Get)
        @<p><center>EIR : @Html.TextBox("SearchString") <br /></center> </p>
        @<p><center><input type="submit" value="Buscar" /></center> </p>
End Using
   
