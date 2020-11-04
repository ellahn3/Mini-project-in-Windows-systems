﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_02_3747_8971
{
    class BusStation
    {
        private string BusStationKey;
        public struct location
        {
            public double Latitude;
            public double Longitude;
        };
        protected location Landmark;
        
        public location LANDMARCK
        {
            get { return Landmark; }
            private set
            {
                Random r = new Random();
                Landmark.Latitude = r.NextDouble() * (33.3 - 31) + 31;
                Landmark.Longitude = r.NextDouble() * (35.5 - 34.3) + 34.3;
            }
        }
        public string BUS_STATION_KEY
        {
            get { return BusStationKey; }
            set { BusStationKey = value; }
        }
        public override string ToString()
        {
            return $"Bus Station Code: {BusStationKey}, {Landmark.Latitude}°N {Landmark.Longitude}°E";
        }
    }
}