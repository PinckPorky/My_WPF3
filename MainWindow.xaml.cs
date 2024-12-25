using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace My_WPF3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            _tabItem2.Header = "tabItem";
            Content = _grid;
            _stackPanel.Children.Add(_textBlock);
            _stackPanel.Children.Add(_button);
            _stackPanel.Children.Add(_textBox);


            _tabItem1.Content = _stackPanel;

            _grid.Children.Add(_tabControl);

            _tabControl.Items.Add(_tabItem1);
            _tabControl.Items.Add(_tabItem2);



        }

        Grid _grid = new Grid();


        TabControl _tabControl = new TabControl();
        TabItem _tabItem1 = new TabItem()
        {
            Header = "My_tab"
        };
        TabItem _tabItem2 = new TabItem();
        TextBlock _textBlock = new TextBlock()
        {
            Text ="Mytext",

        };



        Button _button = new Button()
        {
            Content = "My_Button",
            Margin = new Thickness(10)
        };
        TextBox _textBox = new TextBox();
        StackPanel _stackPanel = new StackPanel()
        {
            Orientation = Orientation.Vertical,
            Margin = new Thickness(10, 30, 10, 100),
            Height = 90,
            Width = 100,
            Background = Brushes.Gray

        };


       
    }
}