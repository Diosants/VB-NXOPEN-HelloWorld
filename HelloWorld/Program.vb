Option Explicit Off
Imports NXOpen

Public Class HelloApp
    Public Shared Sub Main()

        Dim theSession As Session = Session.GetSession()

        Guide.InfoWriteLine("Hello world!")
    End Sub
End Class