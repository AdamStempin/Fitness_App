using Fitness_App.Getfitcode;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using System.Xml.Serialization;

namespace Fitness_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public List<Exercise> AllExercise { get; set; } = new List<Exercise>();
        public MainWindow()
        {
            InitializeComponent();
            Dnes();
        }

        private void Add_workout(object sender, RoutedEventArgs e)
        {
            var window = new Add_workout(AllExercise);
            window.ShowDialog();
            RefreshAllExercises();
            Dnes();

        }
        private void Dnes()
        {
            Datum.Content = DateTime.Now.ToShortDateString();
            var zajtra1 = DateTime.Now.AddDays(1);
            zajtra.Content = zajtra1.ToShortDateString();



            var cvik_dnes = AllExercise.Where(x => x.Date_pick.Date == DateTime.Now.Date).FirstOrDefault();
            var cvik_zajtra = AllExercise.Where(x => x.Date_pick.Date == DateTime.Now.AddDays(1).Date).FirstOrDefault();

            if (cvik_dnes != null)
            { 
              label_cvik_dnes.Content = cvik_dnes.Telo_combobox;
            }
            if(cvik_zajtra != null)
            {
              label_cvik_zajtra.Content = cvik_zajtra.Telo_combobox;
            }  
              
        }     



       


        private void RefreshAllExercises()
        {
            Exercises.Items.Clear();
            foreach (var exercise in AllExercise.ToList())
            {
                Exercises.Items.Add(exercise.ToString());
            }


        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddUser(object sender, MouseButtonEventArgs e)
        {
            var window = new AddUser();
            window.ShowDialog();
        }
       
    }
}
    
