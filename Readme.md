<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653668/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1379)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Data Grid for WPF - How to Display Hyperlinks in Cells

This example demonstrates how to display hyperlinks in [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) cells. To do that, bind a column to the field that contains a hyperlink in the data source. Define a [DataTemplate](https://docs.microsoft.com/en-us/dotnet/api/system.windows.datatemplate) and assign it to the [CellTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.CellTemplate) property. The template should include the [HyperlinkEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.HyperlinkEdit) editor. Use the [HyperlinkEdit.Text](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.HyperlinkEdit.Text) property to specify a custom caption instead of a URL.

```xaml
<dxg:GridColumn FieldName="HelpLink">
    <dxg:GridColumn.CellTemplate>
        <DataTemplate>
            <dxe:HyperlinkEdit Name="PART_Editor"
                               AllowAutoNavigate="True"
                               Text="{Binding RowData.Row.Name}"/>
        </DataTemplate>
    </dxg:GridColumn.CellTemplate>
</dxg:GridColumn>
```

![](/hyperlinks-example.png)

<!-- default file list -->

## Files to Look At

- [MainWindow.xaml](./CS/MainWindow.xaml) ([MainWindow.xaml](./VB/MainWindow.xaml))
- [MainViewModel.cs](./CS/MainViewModel.cs) ([MainViewModel.vb](./VB/MainViewModel.vb))

<!-- default file list end -->

## Documentation
- [HyperlinkEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.HyperlinkEdit)
