using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App.Getfitcode
{
    public class User
    {
        public int ID { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }
        
        public User(int iD, int weight,int height,string fullName, string city, DateTime birthDay, Gender gender)
        {
            ID = iD;
            Weight= weight;
            Height = height;
            FullName = fullName; 
            City = city;
            BirthDay = birthDay;
            Gender = gender;
        }

    }
    public enum Gender
    {
        male,
        female,
        

    }


}

    
