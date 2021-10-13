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
    Public Class responsablesController
        Inherits System.Web.Mvc.Controller

        Private db As New Entities_movil360

        ' GET: responsables
        Function Index() As ActionResult
            Return View(db.responsables.ToList())
        End Function

        ' GET: responsables/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim responsable As responsable = db.responsables.Find(id)
            If IsNothing(responsable) Then
                Return HttpNotFound()
            End If
            Return View(responsable)
        End Function

        ' GET: responsables/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: responsables/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="reponsable,responsable_nombre")> ByVal responsable As responsable) As ActionResult
            If ModelState.IsValid Then
                db.responsables.Add(responsable)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(responsable)
        End Function

        ' GET: responsables/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim responsable As responsable = db.responsables.Find(id)
            If IsNothing(responsable) Then
                Return HttpNotFound()
            End If
            Return View(responsable)
        End Function

        ' POST: responsables/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="reponsable,responsable_nombre")> ByVal responsable As responsable) As ActionResult
            If ModelState.IsValid Then
                db.Entry(responsable).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(responsable)
        End Function

        ' GET: responsables/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim responsable As responsable = db.responsables.Find(id)
            If IsNothing(responsable) Then
                Return HttpNotFound()
            End If
            Return View(responsable)
        End Function

        ' POST: responsables/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim responsable As responsable = db.responsables.Find(id)
            db.responsables.Remove(responsable)
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
