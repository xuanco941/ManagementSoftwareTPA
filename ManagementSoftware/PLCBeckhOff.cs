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
        public AmsAddress amsAddress = new AmsAddress(new AmsNetId(Common.AMSID), Common.PORT);
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
                string value = client.ReadAnyString(symbol.IndexGroup, symbol.IndexOffset, 50, Encoding.ASCII);
                //return value;
                byte[] asciiBytes = Encoding.UTF8.GetBytes(value); // Chuyển chuỗi sang byte array

                List<byte> listByte = new List<byte>();
                foreach (var item in asciiBytes)
                {
                    if (item != 0)
                    {
                        listByte.Add(item);
                    }
                    else
                    {
                        break;
                    }
                }

                byte[] bytes = new byte[listByte.Count];

                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = listByte[i];
                }


                string result = Encoding.UTF8.GetString(bytes);

                System.Diagnostics.Debug.WriteLine(result);

                return result;
            }
            catch
            {
                return null;
            }

        }
        //public string? ReadAVariableString(string variableName)
        //{

        //    try
        //    {
        //        var symbol = client.ReadSymbol(variableName);
        //        string value = client.ReadAnyString(symbol.IndexGroup, symbol.IndexOffset, 100, Encoding.ASCII);
        //        return value;
        //    }
        //    catch
        //    {
        //        return null;
        //    }

        //}




        public bool WriteAVariableNumber(string variableName, object value)
        {

            try
            {
                client.WriteValue(variableName, value);
                return true;
            }
            catch
            {
                return false;
            }

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