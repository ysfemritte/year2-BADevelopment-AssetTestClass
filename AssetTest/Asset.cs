using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTest
{
    class Asset
    {
        //1. IV - private var - associated with Implemented Properties
        private double assetValue, depRate;


        //2. Auto-Implemented Properties - Do not require VALIDATION
        public string AssetName { get; set; }

        //3. Implemented Properties - Require Validation
        public double AssetValue
        {
            get 
            {
                return assetValue;
            }
            set
            {
                if (value > 0.0)
                {
                    assetValue = value;
                }
            }
        }

        public double DepRate
        {
            get
            {
                return depRate;
            }
            set
            {
                if (value > 0.0)
                {
                    depRate = value;
                }
            }
        }

        //4. Parameterised Constructor - Public Asset(Properties)
        public Asset(string _assetName, double _assetValue, double _depRate)
        {
            //Properties = Parameters
            AssetName = _assetName;
            AssetValue = _assetValue;
            DepRate = _depRate;
        }

        
        //5. Methods
        public double AmtDepreciation()
        {
            return AssetValue * DepRate / 100;
        }

        public double ValueDepreciation()
        {
            return AssetValue - AmtDepreciation();
        }
        //End AssetClass

    }
}
