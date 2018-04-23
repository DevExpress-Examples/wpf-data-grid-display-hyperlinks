Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes


Namespace fGrid11
    Partial Public Class MainWindow
        Inherits Window

        Private vm As MyViewModel
        Public Sub New()
            InitializeComponent()
            vm = New MyViewModel()
            DataContext = vm

        End Sub
        Private Sub OnHyperlinkRequestNavigate(ByVal sender As Object, ByVal e As System.Windows.Navigation.RequestNavigateEventArgs)
            Process.Start(New ProcessStartInfo(e.Uri.AbsoluteUri))
            e.Handled = True
        End Sub
    End Class

    Public Class MyViewModel
        Public Sub New()
            CreateList()
        End Sub
        Public Property ListPerson() As ObservableCollection(Of Person)
        Private Sub CreateList()
            ListPerson = New ObservableCollection(Of Person)()
            For i As Integer = 0 To 9
                Dim p As New Person(i)
                ListPerson.Add(p)
            Next i
        End Sub
    End Class

    Public Class Person
        Public Sub New(ByVal i As Integer)
            FirstName = String.Format("FirstName {0}", i)
            LastName = String.Format("LastName {0}", i)
            Age = i * 10
            Group = i Mod 2 = 0
            Hyperlink = "https://www.devexpress.com"
        End Sub
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property Age() As Integer
        Public Property Group() As Boolean
        Public Property Hyperlink() As String
    End Class
End Namespace