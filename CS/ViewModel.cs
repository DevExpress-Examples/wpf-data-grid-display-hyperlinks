using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace fGrid11 {
    public class MyViewModel {
        public MyViewModel() {
            CreateList();
        }
        public ObservableCollection<Item> Items { get; set; }
        void CreateList() {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item() { ID = 1, Name = "HyperlinkEdit", HelpLink = "https://documentation.devexpress.com/#WPF/CustomDocument117458" });
            Items.Add(new Item() { ID = 2, Name = "GridControl", HelpLink = "https://documentation.devexpress.com/#WPF/clsDevExpressXpfGridGridControltopic" });
            Items.Add(new Item() { ID = 3, Name = "DiagramControl", HelpLink = "https://documentation.devexpress.com/#WPF/CustomDocument115046" });
            Items.Add(new Item() { ID = 4, Name = "TextEdit", HelpLink = "https://documentation.devexpress.com/#WPF/clsDevExpressXpfEditorsTextEdittopic" });
            Items.Add(new Item() { ID = 5, Name = "DockLayoutManager", HelpLink = "https://documentation.devexpress.com/#WPF/CustomDocument6820" });
            Items.Add(new Item() { ID = 6, Name = "RibbonControl", HelpLink = "https://documentation.devexpress.com/#WPF/CustomDocument7954" });
            Items.Add(new Item() { ID = 7, Name = "PropertyGridControl", HelpLink = "https://documentation.devexpress.com/#WPF/CustomDocument15640" });
        }
    }

    public class Item {
        public int ID {
            get;
            set;
        }
        public string Name {
            get;
            set;
        }
        public string HelpLink {
            get;
            set;
        }
    }
}
