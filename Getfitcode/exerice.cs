using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App.Getfitcode
{
    public class Exercise
    {
        public string Nohy { get; set; }
        public string Ramena { get; set; }
        public string Ruky { get; set; }
        public string Brucho { get; set; }

        public Exercise(string nohy,string ramena,string ruky, string brucho) 
        { 
         Nohy = nohy;
         Ramena = ramena;
         Ruky = ruky;
         Brucho = brucho;
        }
        public enum nohy
        {
            squats,
            legpress,
            Predkopávanie,
            výpady,
            Deadlift,
        }
        public enum ramena
        {
            LateralRaises,
            Prednézdvíhanie,
            ArnoldPress,
            Zdvíhanieramien,
            MilitaryPress,
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

        

       




    }
}
