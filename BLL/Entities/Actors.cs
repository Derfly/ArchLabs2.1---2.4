﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace BLL.Entities 
    {
        public class Actors
        {
            public string FName { get; private set; }
            public string LName { get; private set; }

            public Actors(string FName, string LName)
            {
                this.FName = FName;
                this.LName = LName;
            }

        }
    }

