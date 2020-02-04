Imports System.IO
Imports System.Reflection
''' <summary>
''' Helpful functions for CIS230
''' </summary>
Public Class Helpers

    Public Function GetAssemblyDirectory() As String
        Dim codeBase = Assembly.GetExecutingAssembly().CodeBase
        Dim uriCB = New UriBuilder(codeBase)
        Dim pathCB = Uri.UnescapeDataString(uriCB.Path)
        Return Path.GetDirectoryName(pathCB)
    End Function
End Class
