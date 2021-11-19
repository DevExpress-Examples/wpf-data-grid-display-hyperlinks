
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace fGrid11 {
    public partial class MainWindow : Window {
        MyViewModel vm;
        public MainWindow() {
            InitializeComponent();
            vm = new MyViewModel();
            DataContext = vm;

        }
        void OnHyperlinkRequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e) {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }

    public class MyViewModel {
        public MyViewModel() {
            CreateList();
        }
        public ObservableCollection<Person> ListPerson { get; set; }
        void CreateList() {
            ListPerson = new ObservableCollection<Person>();
            for (int i = 0; i < 10; i++) {
                Person p = new Person(i);
                ListPerson.Add(p);
            }
        }
    }

    public class Person {
        public Person(int i) {
            FirstName = string.Format("FirstName {0}", i);
            LastName = string.Format("LastName {0}", i);
            Age = i * 10;
            Group = i % 2 == 0;
            Hyperlink = "https://www.devexpress.com";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool Group { get; set; }
        public string Hyperlink { get; set; }
    }
}