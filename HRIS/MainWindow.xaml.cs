using HRIS.Controller;
using HRIS.Teaching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HRIS.View;

namespace HRIS

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string STAFF_LIST_KEY = "StaffList";
        private const string UNIT_LIST_KEY = "UnitList";
        private const string CLASS_LIST_KEY = "ClassList";
        private StaffController staffcontroller;
        private UnitController unitController;
        private ClassListView classListView;
        

        public MainWindow()
        {
            InitializeComponent();
            staffcontroller = (StaffController)(Application.Current.FindResource(STAFF_LIST_KEY) as ObjectDataProvider).ObjectInstance;
            unitController = (UnitController)(Application.Current.FindResource(UNIT_LIST_KEY) as ObjectDataProvider).ObjectInstance;
            classListView = (ClassListView)(Application.Current.FindResource(CLASS_LIST_KEY) as ObjectDataProvider).ObjectInstance;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            staffcontroller.FilterByCategory((Category)Enum.Parse(typeof(Category), CategoryBox.SelectedItem.ToString()));
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DetailGrid.DataContext = StaffList.SelectedItem;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            unitController.FilterByInput(UnitName.Text);

        }

        private void UnitBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            classListView.FilterByCode(UnitBox.SelectedItem.ToString());
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            classListView.FilterByCampus((Campus)Enum.Parse(typeof(Campus), CampusBox.SelectedItem.ToString()));

        }

        private void NameBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            staffcontroller.FilterByInput(NameBox.Text);
        }


    }
}