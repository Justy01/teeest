using CollageJsonWPF.Data;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace CollageJsonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            OpenFileDialog dialog = new OpenFileDialog { Filter = "Json files | *.json" };
            if (dialog.ShowDialog() != true || !File.Exists(dialog.FileName))
            {
                MessageBox.Show("Error open file!");
                Application.Current.Shutdown();
                return;
            }

            try
            {
                Student? student = JsonSerializer.Deserialize<Student>(File.ReadAllText(dialog.FileName!));
                if (student == null)
                {
                    MessageBox.Show("Error read file!");
                    Application.Current.Shutdown();
                    return;
                }
                DataContext = student;
            }
            catch
            {
                MessageBox.Show("Error read file!");
                Application.Current.Shutdown();
            }

            





            //
            InitializeComponent();
        }
    }
}
