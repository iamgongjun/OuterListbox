using System.Collections.ObjectModel;
using System.Windows;

namespace OuterListbox
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<Question> questions = new ObservableCollection<Question>();
            for (int index = 0; index < 125; index++)
            {
                questions.Add(new Question()
                {
                    Text = "条1",
                    Qestions = new ObservableCollection<Person>()
                    {
                        new Person()
                        {
                            Name="名字"+index,Age="年龄"+index
                        },
                        new Person()
                        {
                            Name="名字",Age="年龄"
                        },
                        new Person()
                        {
                            Name="名字",Age="年龄"
                        },
                        new Person()
                        {
                            Name="名字",Age="年龄"
                        },
                        new Person()
                        {
                            Name="名字",Age="年龄"
                        },
                        new Person()
                        {
                            Name="名字",Age="年龄"
                        },
                        new Person()
                        {
                            Name="名字",Age="年龄"
                        },
                        new Person()
                        {
                            Name="名字",Age="年龄"
                        },
                         new Person()
                        {
                            Name="名字",Age="年龄"
                        },
                        new Person()
                        {
                            Name="名字",Age="年龄"
                        }
                    }
                });

            }
            lb1.ItemsSource = questions;
        }
    }
}
