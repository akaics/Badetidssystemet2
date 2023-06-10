using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badetidssystemet2
{
    internal class Badetidsperiode
    {
        //Properties: 

        private string type;
        private DayOfWeek ugeDag;
        private DateTime startTidspunkt;
        private DateTime slutTidspunkt;

        // Constructor:

        public Badetidsperiode(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt)
        {
            Type = type;
            ugeDag = ugeDag;
            StartTidspunkt = startTidspunkt;
            SlutTidspunkt = slutTidspunkt;
        }

        // getters and setters

        public string Type { get; set; }
        public DayOfWeek UgeDag { get; set; }
        public DateTime StartTidspunkt { get; set; }
        public DateTime SlutTidspunkt { get; set; }



        //Laver en to string method: 
        public override string ToString()
        {
            return $"Badetidsperiode info: {Type}, {UgeDag}, {StartTidspunkt}, {SlutTidspunkt}";
        }
    }
}
