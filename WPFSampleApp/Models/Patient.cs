﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp1.Models
{
    //Data Binding
    //Two Way Binding -> UI Elements induces change to Business Entities and vice versa


    public class Patient: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private int id; 
        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }

        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }

        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged("Age"); }

        }


    }
}
