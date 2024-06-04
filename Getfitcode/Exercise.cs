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
        public string Telo_combobox { get; set; }
        public string Cvičenia { get; set; }
       
        public DateTime Date_pick { get; }

        public Exercise( DatePicker date_pick,string telo , string cvicenie) 
        {
            Telo_combobox = telo;
            Cvičenia = cvicenie;
            Date_pick = date_pick.SelectedDate.Value.Date;
        }

        public override string? ToString()
        {
            string s1 = String.Format("{0:MM/dd/yyyy}", Date_pick); 
            return Telo_combobox+" "+Cvičenia+" "+s1;
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
