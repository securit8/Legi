using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class User
    {
        public string Sex { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string Tel { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}, Sex: {Sex}, Tel: {Tel}, Address: {Address}, BD: {Birthday}";
        }
    }
}
