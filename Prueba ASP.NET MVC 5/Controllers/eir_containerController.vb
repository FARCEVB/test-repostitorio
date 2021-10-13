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
    Public Class eir_containerController
        Inherits System.Web.Mvc.Controller

        Private db As New Entities_movil360

        ' GET: eir_container
        Function Index(ByVal searchString As String) As ActionResult
            ' Dim eir_container = db.eir_container.Include(Function(e) e.empresa1).Include(Function(e) e.responsable1)
            ' Return View(eir_container.ToList())
            Dim eir_container1 = From m In db.eir_container Select m
            If Not String.IsNullOrEmpty(searchString) Then
                eir_container1 = eir_container1.Where(Function(movie) movie.eir.Contains(searchString))
            End If
            Return View(eir_container1)
        End Function

        ' GET: eir_container/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim eir_container As eir_container = db.eir_container.Find(id)
            If IsNothing(eir_container) Then
                Return HttpNotFound()
            End If
            Return View(eir_container)
        End Function

        ' GET: eir_container/Create
        Function Create() As ActionResult
            ViewBag.empresa = New SelectList(db.empresas, "empresa1", "empresa_nombre")
            ViewBag.responsable = New SelectList(db.responsables, "reponsable", "responsable_nombre")
            Return View()
        End Function

        ' POST: eir_container/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="eir,contenedor,sello,responsable,empresa")> ByVal eir_container As eir_container) As ActionResult
            If ModelState.IsValid Then
                db.eir_container.Add(eir_container)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.empresa = New SelectList(db.empresas, "empresa1", "empresa_nombre", eir_container.empresa)
            ViewBag.responsable = New SelectList(db.responsables, "reponsable", "responsable_nombre", eir_container.responsable)
            Return View(eir_container)
        End Function

        ' GET: eir_container/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim eir_container As eir_container = db.eir_container.Find(id)
            If IsNothing(eir_container) Then
                Return HttpNotFound()
            End If
            ViewBag.empresa = New SelectList(db.empresas, "empresa1", "empresa_nombre", eir_container.empresa)
            ViewBag.responsable = New SelectList(db.responsables, "reponsable", "responsable_nombre", eir_container.responsable)
            Return View(eir_container)
        End Function

        ' POST: eir_container/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="eir,contenedor,sello,responsable,empresa")> ByVal eir_container As eir_container) As ActionResult
            If ModelState.IsValid Then
                db.Entry(eir_container).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.empresa = New SelectList(db.empresas, "empresa1", "empresa_nombre", eir_container.empresa)
            ViewBag.responsable = New SelectList(db.responsables, "reponsable", "responsable_nombre", eir_container.responsable)
            Return View(eir_container)
        End Function

        ' GET: eir_container/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim eir_container As eir_container = db.eir_container.Find(id)
            If IsNothing(eir_container) Then
                Return HttpNotFound()
            End If
            Return View(eir_container)
        End Function

        ' POST: eir_container/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim eir_container As eir_container = db.eir_container.Find(id)
            db.eir_container.Remove(eir_container)
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
