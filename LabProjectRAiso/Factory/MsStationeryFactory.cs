using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Factory
{
    public class MsStationeryFactory
    {
        public static MsStationery CreateMsStationery(string StationeryName, int StationeryPrice)
        {
            MsStationery msStationery = new MsStationery()
            {
                StationeryName = StationeryName,
                StationeryPrice = StationeryPrice
            };
            return msStationery;
        }
    }
}