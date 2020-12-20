﻿using System;
using System.Collections.Generic;
using System.Text;
using DO;

namespace DalApi
{
    /// <summary>
    /// Statement of functions for all class in DO
    /// CRUD Logic
    /// </summary>
    public interface IDal
    {
        #region Bus
        Bus getBus(int id);
        IEnumerable<Bus> Bus();
        void addBus(Bus b);
        void updateBus(Bus b);
        void deleteBus(Bus b);
        #endregion
        #region BusDrive
        BusDrive getBusDrive(int id);
        IEnumerable<BusDrive> BusDrives();
        void addBusDrive(BusDrive b);
        void updateBusDrive(BusDrive b);
        void deleteBusDrive(BusDrive b);

        #endregion
        #region BusStation
        BusStation getBusStation(int n);
        IEnumerable<BusStation> BusStations();
        void addBusStation(BusStation b);
        void updateBusStation(BusStation b);
        void deleteBusStation(BusStation b);

        #endregion
        #region BusLine
        BusLine getBusLine(int id);
        IEnumerable<BusLine> BusLines();
        void addBusLine(BusLine b);
        void updateBusLine(BusLine b);
        void deleteBusLine(BusLine b);
        #endregion
        #region BusLineStation
        BusLineStation getBusLineStation(int id);
        IEnumerable<BusLineStation> BusLineStations();
        void addBusLineStation(BusLineStation s);
        void updateBusLineStation(BusLineStation s);
        void deleteBusLineStation(BusLineStation s);
        #endregion
        #region LineWayOut
        LineOutForARide getLineWayOut(int id);
        IEnumerable<LineOutForARide> LinesWayOut();
        void addLineWayOut(LineOutForARide o);
        void updateLineWayOut(LineOutForARide o);
        void deleteLineWayOut(LineOutForARide o);
        TimeSpan TravelTime(LineOutForARide o);
        #endregion
        #region ConsecutiveStations
        ConsecutiveStations getConsecutiveStations(string id1, string id2);
        IEnumerable<ConsecutiveStations> ConsecutivesStations();
        void addConsecutiveStations(ConsecutiveStations s);
        void updateConsecutiveStations(ConsecutiveStations c);
        void deleteConsecutiveStations(ConsecutiveStations c);
        #endregion
    }
}
