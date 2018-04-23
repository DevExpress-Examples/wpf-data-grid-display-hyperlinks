Imports Microsoft.VisualBasic
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
		Private privateListPerson As ObservableCollection(Of Person)
		Public Property ListPerson() As ObservableCollection(Of Person)
			Get
				Return privateListPerson
			End Get
			Set(ByVal value As ObservableCollection(Of Person))
				privateListPerson = value
			End Set
		End Property
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
			FirstName = "FirstName" & i
			LastName = "LastName" & i
			Age = i * 10
			Group = i Mod 2 = 0
			Hyperlink = "https://www.devexpress.com"
		End Sub
		Private privateFirstName As String
		Public Property FirstName() As String
			Get
				Return privateFirstName
			End Get
			Set(ByVal value As String)
				privateFirstName = value
			End Set
		End Property
		Private privateLastName As String
		Public Property LastName() As String
			Get
				Return privateLastName
			End Get
			Set(ByVal value As String)
				privateLastName = value
			End Set
		End Property
		Private privateAge As Integer
		Public Property Age() As Integer
			Get
				Return privateAge
			End Get
			Set(ByVal value As Integer)
				privateAge = value
			End Set
		End Property
		Private privateGroup As Boolean
		Public Property Group() As Boolean
			Get
				Return privateGroup
			End Get
			Set(ByVal value As Boolean)
				privateGroup = value
			End Set
		End Property
		Private privateHyperlink As String
		Public Property Hyperlink() As String
			Get
				Return privateHyperlink
			End Get
			Set(ByVal value As String)
				privateHyperlink = value
			End Set
		End Property
	End Class
End Namespace
