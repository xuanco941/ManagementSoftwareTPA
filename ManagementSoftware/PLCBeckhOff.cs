using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinCAT.Ads;
using System.Collections.Generic;

namespace ManagementSoftware
{
    public class PLCBeckhOff
    {
        public AmsAddress amsAddress = new AmsAddress(new AmsNetId("5.100.108.136.1.1"), 851);
        public AdsClient client;

        public PLCBeckhOff()
        {
            client = new AdsClient();
        }

        public bool Connect()
        {
            try
            {
                client.Connect(amsAddress);
                var state = client.ReadState();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool CheckState()
        {
            try
            {
                var state = client.ReadState();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Disconnect()
        {
            try
            {
                return client.Disconnect();
            }
            catch
            {
                return false;
            }
        }


        //Read bool, float, uint
        public T ReadAVariableNumber<T>(string variableName)
        {
            T value = (T)client.ReadValue(variableName, typeof(T));
            return value;
        }


        //read TimeSpan
        public T ReadAVariableNumber_ReadAny<T>(string variableName)
        {
            var symbol = client.ReadSymbol(variableName);

            T value = (T)(client.ReadAny(symbol.IndexGroup, symbol.IndexOffset, typeof(T)));

            return value;
        }


        //read String
        public string ReadAVariableString(string variableName)
        {
            var symbol = client.ReadSymbol(variableName);
            string value = client.ReadAnyString(symbol.IndexGroup, symbol.IndexOffset, 9999, Encoding.ASCII);
            return value;
        }

    }
}