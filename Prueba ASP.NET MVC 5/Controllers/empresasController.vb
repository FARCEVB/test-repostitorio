Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Prueba_ASP.NET_MVC_5

Namespace Controllers
    Public Class empresasController
        Inherits System.Web.Mvc.Controller

        Private db As New Entities_movil360

        ' GET: empresas
        Function Index() As ActionResult
            Return View(db.empresas.ToList())
        End Function

        ' GET: empresas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empresa As empresa = db.empresas.Find(id)
            If IsNothing(empresa) Then
                Return HttpNotFound()
            End If
            Return View(empresa)
        End Function

        ' GET: empresas/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: empresas/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="empresa1,empresa_nombre")> ByVal empresa As empresa) As ActionResult
            If ModelState.IsValid Then
                db.empresas.Add(empresa)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(empresa)
        End Function

        ' GET: empresas/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empresa As empresa = db.empresas.Find(id)
            If IsNothing(empresa) Then
                Return HttpNotFound()
            End If
            Return View(empresa)
        End Function

        ' POST: empresas/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="empresa1,empresa_nombre")> ByVal empresa As empresa) As ActionResult
            If ModelState.IsValid Then
                db.Entry(empresa).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(empresa)
        End Function

        ' GET: empresas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empresa As empresa = db.empresas.Find(id)
            If IsNothing(empresa) Then
                Return HttpNotFound()
            End If
            Return View(empresa)
        End Function

        ' POST: empresas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim empresa As empresa = db.empresas.Find(id)
            db.empresas.Remove(empresa)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
