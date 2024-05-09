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
using System.Windows.Shapes;

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
         exerice.genre.ItemsSource = Enum.GetValues(typeof());  
                
           
        }
    }
}
