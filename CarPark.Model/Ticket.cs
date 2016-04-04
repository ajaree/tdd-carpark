﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Model
{
    public class Ticket
    {
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public decimal ParkingFee
        {
            get
            {
                decimal fee = 0m;
                TimeSpan diff = DateOut - DateIn;
                if (diff.TotalMinutes <= 15)
                    fee = 0m;
                else 
                {
                    fee = 50m;
                    if (diff.TotalMinutes > 180)
                    {
                        double minute = diff.TotalMinutes - 180;
                        while (minute > 15)
                        {
                            fee = fee + 30m;
                            minute = minute - 60;
                        }
                    }
                  
                    
                }
                

                return fee;
            }
          
        }

        public string PlateNo { get; set; }
    }
}
