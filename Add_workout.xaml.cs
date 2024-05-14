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

            cviky_combobox.ItemsSource = Enum.GetValues(typeof(nohy));

        }

        public void UpdateCviky(object sender, RoutedEventArgs e)
        {
            var cast = telo_combobox.SelectedValue.ToString();
            switch (cast) 
            {
                case "nohy" :
                    cviky_combobox.ItemsSource = Enum.GetValues(typeof(nohy));
                    break;
                case "ruky":
                    cviky_combobox.ItemsSource = Enum.GetValues(typeof(ruky));
                    break;
                case "chrbat":
                    cviky_combobox.ItemsSource = Enum.GetValues(typeof(chrbat));
                    break;
                case "brucho":
                    cviky_combobox.ItemsSource = Enum.GetValues(typeof(brucho));
                    break;

            }
        }

        private void Zavriet_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Ulozit_Click(object sender, RoutedEventArgs e)
        {

            var posledne_treningy = Exercise.Instance;

            var CastTela = telo_combobox.Text;
            var Cviky = cviky_combobox.Text;
            var date = date_pick.SelectedDate.Value.Date;
            var newExercise = new Exercise(CastTela , Cviky , date);
            posledne_treningy.Add(newExercise);
            Close();
        }
           

            
    }
}
