using System.Collections.Generic;

namespace HyperlinkInGridCell {
    public class Item {
        public int ID { get; set; }
        public string Name { get; set; }
        public string HelpLink { get; set; }
    }

    public class MainViewModel {
        public List<Item> Items { get; set; }

        public MainViewModel() {
            Items = GetData();
        }

        List<Item> GetData() {
            return new List<Item> {
                new Item() { ID = 1, Name = "HyperlinkEdit", HelpLink = "https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.HyperlinkEdit" },
                new Item() { ID = 2, Name = "GridControl", HelpLink = "https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl" },
                new Item() { ID = 3, Name = "DiagramControl", HelpLink = "https://docs.devexpress.com/WPF/115046/controls-and-libraries/diagram-control" },
                new Item() { ID = 4, Name = "TextEdit", HelpLink = "https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.TextEdit" },
                new Item() { ID = 5, Name = "DockLayoutManager", HelpLink = "https://docs.devexpress.com/WPF/6820/controls-and-libraries/layout-management/dock-windows/getting-started/dock-layout-manager" },
                new Item() { ID = 6, Name = "RibbonControl", HelpLink = "https://docs.devexpress.com/WPF/7954/controls-and-libraries/ribbon-bars-and-menu/ribbon/ribbon-structure/ribbon-control" },
                new Item() { ID = 7, Name = "PropertyGridControl", HelpLink = "https://docs.devexpress.com/WPF/15640/controls-and-libraries/property-grid" },
            };
        }
    }
}