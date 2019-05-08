using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApplication.Library
{
    public class Location
    {
        private int _storeid;
        public int storeid { get; set; }
        //private string _storelocation;
        // public string storelocation { get; set; }
        //public string storelocation()
        //{
        private string _address1;
        //private string _address2;
        private string _city;
        private string _state;
        private string _zipcode;
        public string address1 { get; set; }
        //public string address2 { get; set; }

        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }


   
    }
}
