using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Fitness_App.Getfitcode
{
    public class Exercise
    {
        internal static object Instance;

        public string Nohy { get; set; }
        public string Ramena { get; set; }
        public string Ruky { get; set; }
        public string Brucho { get; set; }
        public ComboBox Telo_combobox { get; }
        public ComboBox Cviky_combobox { get; }
        public DatePicker Date_pick { get; }

        public Exercise(string nohy,string ramena,string ruky, string brucho) 
        { 
         Nohy = nohy;
         Ramena = ramena;
         Ruky = ruky;
         Brucho = brucho;
        }

        public Exercise(ComboBox telo_combobox, ComboBox cviky_combobox, DatePicker date_pick)
        {
            Telo_combobox = telo_combobox;
            Cviky_combobox = cviky_combobox;
            Date_pick = date_pick;
        }

        public enum cast_tela
        {
            nohy,
            chrbat,
            ruky,
            brucho,
        }
        
        
        public enum nohy
        {
            Squats,
            Legpress,
            Predkopávanie,
            Výpady,
            Deadlift,
        }
        public enum chrbat
        {
            PullUps,
            BentOverBarbellRow,
            Deadlift,
            SeatedCableRow,
            Hyperextension,
        }
        public enum ruky
        {
            Pushups,
            TricepExtension,
            Dips,
            Curl,
            Flies,
        }
        public enum brucho
        {
            Plank,
            Crunches,
            LegRaises,
            BicycleCrunches,
            RussianTwists,
        }

        internal static object Write(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
