Imports System.Collections.Generic

Namespace HyperlinkInGridCell

    Public Class Item

        Public Property ID As Integer

        Public Property Name As String

        Public Property HelpLink As String
    End Class

    Public Class MainViewModel

        Public Property Items As List(Of Item)

        Public Sub New()
            Items = GetData()
        End Sub

        Private Function GetData() As List(Of Item)
            Return New List(Of Item) From {New Item() With {.ID = 1, .Name = "HyperlinkEdit", .HelpLink = "https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.HyperlinkEdit"}, New Item() With {.ID = 2, .Name = "GridControl", .HelpLink = "https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl"}, New Item() With {.ID = 3, .Name = "DiagramControl", .HelpLink = "https://docs.devexpress.com/WPF/115046/controls-and-libraries/diagram-control"}, New Item() With {.ID = 4, .Name = "TextEdit", .HelpLink = "https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.TextEdit"}, New Item() With {.ID = 5, .Name = "DockLayoutManager", .HelpLink = "https://docs.devexpress.com/WPF/6820/controls-and-libraries/layout-management/dock-windows/getting-started/dock-layout-manager"}, New Item() With {.ID = 6, .Name = "RibbonControl", .HelpLink = "https://docs.devexpress.com/WPF/7954/controls-and-libraries/ribbon-bars-and-menu/ribbon/ribbon-structure/ribbon-control"}, New Item() With {.ID = 7, .Name = "PropertyGridControl", .HelpLink = "https://docs.devexpress.com/WPF/15640/controls-and-libraries/property-grid"}}
        End Function
    End Class
End Namespace
