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
using sam_unpack_lib;

namespace SammyKitchen
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "SMD files (*.smd, *.wp8, *.csc)|*.smd;*.wp8;*.csc|MBN files (*.mbn)|*.mbn";
            dlg.Multiselect = false;
            dlg.AddExtension = true;
            dlg.ShowDialog();
            List<SMD.Section> sections = SMD.GetSections(dlg.FileName, true);
            lbxSections.DataContext = sections;
        }
    }
}
