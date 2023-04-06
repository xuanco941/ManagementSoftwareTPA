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
               
                return CheckState();
            }
            catch
            {
                return false;
            }
        }


        public bool CheckState()
        {
            if (client.IsConnected == true)
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
            else
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
        public T? ReadAVariableNumber<T>(string variableName) where T : struct
        {
            try
            {
                T? value = (T)client.ReadValue(variableName, typeof(T));
                return value;
            }
            catch
            {
                return null;
            }

        }


        //read DateTime
        public T? ReadAVariableNumber_ReadAny<T>(string variableName) where T : struct
        {

            try
            {
                var symbol = client.ReadSymbol(variableName);

                T? value = (T)(client.ReadAny(symbol.IndexGroup, symbol.IndexOffset, typeof(T)));

                return value;
            }
            catch
            {
                return null;
            }



        }


        //read String
        public string? ReadAVariableString(string variableName)
        {

            try
            {
                var symbol = client.ReadSymbol(variableName);
                string? value = client.ReadAnyString(symbol.IndexGroup, symbol.IndexOffset, 9999, Encoding.ASCII);
                return value;
            }
            catch
            {
                return null;
            }


        }



        public bool WriteAVariableNumber(string variableName, object value)
        {
            //if (value != null)
            //{
            try
            {
                client.WriteValue(variableName, value);
                return true;
            }
            catch
            {
                return false;
            }
            //}
            //{
            //    return false;
            //}
        }
        public void WriteAVariableString(string variableName, string value)
        {
            if (value != null)
            {
                client.WriteAnyString(variableName, value, value.Length, Encoding.ASCII);
            }
        }

    }
}