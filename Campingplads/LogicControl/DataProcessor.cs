using Campingplads.DataControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Campingplads.LogicControl
{
    public class DataProcessor
    {
        private DatabaseInterface _dbInterface;

        public DataProcessor()
        {
            _dbInterface = new DatabaseInterface();
        }

        public CampingSpotTypeInformation GetSpotTypeInformation(int spotType)
        {
            return _dbInterface.GetCampingSpotTypeInformation(spotType);
        }


    }


}