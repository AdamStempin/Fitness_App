using Fitness_App.Getfitcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows; 
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Fitness_App.Getfitcode.Exercise;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fitness_App
{
    /// <summary>
    /// Interaction logic for Add_workout.xaml
    /// </summary>
    public partial class Add_workout : Window
    {
        

        public Add_workout()
        {
            InitializeComponent();
            telo_combobox.ItemsSource = Enum.GetValues(typeof(cast_tela));
           
            InitializeComponent();
            cviky_combobox.ItemsSource = Enum.GetValues(typeof(nohy));
            
           
           


        }

        private void Zavriet_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Ulozit_Click(object sender, RoutedEventArgs e)
        {
            var Exercise = Add_workout.Instance;

            var CastTela = (Exercise)Enum.Parse(typeof(cast_tela); 
            var Cviky = (Exercise)Enum.Parse(typeof(nohy). cviky_combobox.SelectedValue.ToString(), true); ;
            var Date = date_pick.SelectedDate.Value.Date;

            Exercise newExercise = new Exercise(CastTela, Cviky, Date,);
            Close();
        }
    }
}
