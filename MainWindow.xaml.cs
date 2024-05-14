using Fitness_App.Getfitcode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
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

namespace Fitness_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Dnes();
        }

        private void Add_workout(object sender, RoutedEventArgs e)
        {
            var window = new Add_workout();
            window.ShowDialog();
            
        }
        private void Dnes()
        {
            Datum.Content = DateTime.Now.ToShortDateString();
            var zajtra1 = DateTime.Now.AddDays(1);
            zajtra.Content = zajtra1.ToShortDateString();
        }
            


        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            posledne_treningy.Items.Clear();
            foreach (var exercise in Exercise.Write(x => !x.posledne_treningy).ToList())
            {
                posledne_treningy.Items.Add(exercise.ToString());
            }
        }
    }
}
