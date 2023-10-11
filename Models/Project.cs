
using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace ProjectApi.Models

{


    public class Project
    {
      
       public int Id { get; set; }

      public Data? Data { get; set; }
    }

 

    public class Data
    {

        public int Id { get; set; }
        public  int Temperature { get; set; }
        public int Humidity { get; set; }
        public Boolean Occupancy { get; set; }
    } 

   
}
