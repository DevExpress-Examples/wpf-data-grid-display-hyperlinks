Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text

Namespace fGrid11
    Public Class MyViewModel
        Public Sub New()
            CreateList()
        End Sub
        Public Property Items() As ObservableCollection(Of Item)
        Private Sub CreateList()
            Items = New ObservableCollection(Of Item)()
            Items.Add(New Item() With {.ID = 1, .Name = "HyperlinkEdit", .HelpLink = "https://documentation.devexpress.com/#WPF/CustomDocument117458"})
            Items.Add(New Item() With {.ID = 2, .Name = "GridControl", .HelpLink = "https://documentation.devexpress.com/#WPF/clsDevExpressXpfGridGridControltopic"})
            Items.Add(New Item() With {.ID = 3, .Name = "DiagramControl", .HelpLink = "https://documentation.devexpress.com/#WPF/CustomDocument115046"})
            Items.Add(New Item() With {.ID = 4, .Name = "TextEdit", .HelpLink = "https://documentation.devexpress.com/#WPF/clsDevExpressXpfEditorsTextEdittopic"})
            Items.Add(New Item() With {.ID = 5, .Name = "DockLayoutManager", .HelpLink = "https://documentation.devexpress.com/#WPF/CustomDocument6820"})
            Items.Add(New Item() With {.ID = 6, .Name = "RibbonControl", .HelpLink = "https://documentation.devexpress.com/#WPF/CustomDocument7954"})
            Items.Add(New Item() With {.ID = 7, .Name = "PropertyGridControl", .HelpLink = "https://documentation.devexpress.com/#WPF/CustomDocument15640"})
        End Sub
    End Class

    Public Class Item
        Public Property ID() As Integer
        Public Property Name() As String
        Public Property HelpLink() As String
    End Class
End Namespace
