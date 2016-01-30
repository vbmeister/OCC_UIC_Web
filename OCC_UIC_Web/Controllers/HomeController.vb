Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Title") = "Home Page"

        Return View()
    End Function
    Function map() As ActionResult
        ViewData("Title") = "map"

        Return View()
    End Function
End Class
