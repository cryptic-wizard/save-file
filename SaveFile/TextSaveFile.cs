using System;
using System.Collections.Generic;
using System.IO;

namespace CrypticWizard.SaveFile
{
    public class TextSaveFile
    {
        // String Variables
        private Dictionary<string, string> Strings      = new Dictionary<string, string>();
        private Dictionary<string, char> Chars          = new Dictionary<string, char>();
        private Dictionary<string, DateTime> DateTimes  = new Dictionary<string, DateTime>();

        // Signed Variables
        private Dictionary<string, bool> Bools          = new Dictionary<string, bool>();
        private Dictionary<string, sbyte> SBytes        = new Dictionary<string, sbyte>();
        private Dictionary<string, short> Shorts        = new Dictionary<string, short>();
        private Dictionary<string, int> Ints            = new Dictionary<string, int>();
        private Dictionary<string, long> Longs          = new Dictionary<string, long>();

        // Unsigned Variables
        private Dictionary<string, byte> Bytes          = new Dictionary<string, byte>();
        private Dictionary<string, ushort> UShorts      = new Dictionary<string, ushort>();
        private Dictionary<string, uint> UInts          = new Dictionary<string, uint>();
        private Dictionary<string, ulong> ULongs        = new Dictionary<string, ulong>();

        // Decimal Variables
        private Dictionary<string, double> Doubles      = new Dictionary<string, double>();
        private Dictionary<string, float> Floats        = new Dictionary<string, float>();
        private Dictionary<string, decimal> Decimals    = new Dictionary<string, decimal>();

        public enum DataTypes
        {
            String,
            Char,
            DateTime,

            Bool,
            SByte,
            Short,
            Int,
            Long,

            Byte,
            UShort,
            UInt,
            ULong,

            Double,
            Float,
            Decimal,
        }

        private static readonly Dictionary<DataTypes, string> DataTypeToString = new Dictionary<DataTypes, string>()
        {
            { DataTypes.String    , "string"     },
            { DataTypes.Char      , "char"       },
            { DataTypes.DateTime  , "datetime"   },
                                                 
            { DataTypes.Bool      , "bool"       },
            { DataTypes.SByte     , "sbyte"      },
            { DataTypes.Short     , "short"      },
            { DataTypes.Int       , "int"        },
            { DataTypes.Long      , "long"       },
                                                 
            { DataTypes.Byte      , "byte"       },
            { DataTypes.UShort    , "ushort"     },
            { DataTypes.UInt      , "uint"       },
            { DataTypes.ULong     , "ulong"      },
                                                 
            { DataTypes.Double    , "double"     },
            { DataTypes.Float     , "float"      },
            { DataTypes.Decimal   , "decimal"    },
        };

        private static readonly Dictionary<string, DataTypes> StringToDataType = new Dictionary<string, DataTypes>()
        {
            { "string"   ,   DataTypes.String    },
            { "char"     ,   DataTypes.Char      },
            { "datetime" ,   DataTypes.DateTime  },

            { "bool"     ,   DataTypes.Bool      },
            { "sbyte"    ,   DataTypes.SByte     },
            { "short"    ,   DataTypes.Short     },
            { "int"      ,   DataTypes.Int       },
            { "long"     ,   DataTypes.Long      },

            { "byte"     ,   DataTypes.Byte      },
            { "ushort"   ,   DataTypes.UShort    },
            { "uint"     ,   DataTypes.UInt      },
            { "ulong"    ,   DataTypes.ULong     },

            { "double"   ,   DataTypes.Double    },
            { "float"    ,   DataTypes.Float     },
            { "decimal"  ,   DataTypes.Decimal   },
        };

        public TextSaveFile()
        {

        }

        public static bool Exists(string fileName)
        {
            return File.Exists(fileName);
        }

        public void Write(string fileName, char delimiter = '=')
        {
            string d = delimiter.ToString();

            using(StreamWriter sw = new StreamWriter(File.OpenWrite(fileName)))
            {
                // String Variables
                foreach (KeyValuePair<string, string> kvp in Strings)
                {
                    if (kvp.Value.Contains(delimiter))
                    {
                        throw new FormatException(kvp.Value + " contains the delimiter " + delimiter.ToString());
                    }
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.String]    + d + kvp.Value);
                }                                                                                               
                foreach (KeyValuePair<string, char> kvp in Chars)                                               
                {                                                                                               
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.Char]      + d + kvp.Value.ToString());
                }                                                                                                     
                foreach (KeyValuePair<string, DateTime> kvp in DateTimes)                                             
                {                                                                                                     
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.DateTime]  + d + kvp.Value.ToString());
                }                                                                                                     
                                                                                                                      
                // Signed Variables                                                                                   
                foreach (KeyValuePair<string, bool> kvp in Bools)                                                     
                {                                                                                                     
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.Bool]      + d + kvp.Value.ToString());
                }                                                                                                     
                foreach (KeyValuePair<string, sbyte> kvp in SBytes)                                                   
                {                                                                                                     
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.SByte]     + d + kvp.Value.ToString());
                }                                                                                                     
                foreach (KeyValuePair<string, short> kvp in Shorts)                                                   
                {                                                                                                     
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.Short]     + d + kvp.Value.ToString());
                }                                                                                                     
                foreach (KeyValuePair<string, int> kvp in Ints)                                                       
                {                                                                                                     
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.Int]       + d + kvp.Value.ToString());
                }                                                                                                     
                foreach (KeyValuePair<string, long> kvp in Longs)                                                     
                {                                                                                                     
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.Long]      + d + kvp.Value.ToString());
                }                                                                                                     
                                                                                                                      
                // Unsigned Variables                                                                                 
                foreach (KeyValuePair<string, byte> kvp in Bytes)                                                     
                {                                                                                                     
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.Byte]      + d + kvp.Value.ToString());
                }                                                                                                     
                foreach (KeyValuePair<string, ushort> kvp in UShorts)                                                 
                {                                                                                                     
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.UShort]    + d + kvp.Value.ToString());
                }                                                                                                     
                foreach (KeyValuePair<string, uint> kvp in UInts)                                                     
                {                                                                                                     
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.UInt]      + d + kvp.Value.ToString());
                }                                                                                                     
                foreach (KeyValuePair<string, ulong> kvp in ULongs)                                                   
                {                                                                                                     
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.ULong]     + d + kvp.Value.ToString());
                }                                                                                                     
                                                                                                                      
                // Decimal Variables                                                                                  
                foreach (KeyValuePair<string, double> kvp in Doubles)                                                 
                {                                                                                                     
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.Double]    + d + kvp.Value.ToString());
                }                                                                                                     
                foreach (KeyValuePair<string, float> kvp in Floats)                                                   
                {                                                                                                     
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.Float]     + d + kvp.Value.ToString());
                }                                                                                                     
                foreach (KeyValuePair<string, decimal> kvp in Decimals)                                               
                {                                                                                                     
                    sw.WriteLine(kvp.Key + d + DataTypeToString[DataTypes.Decimal]   + d + kvp.Value.ToString());
                }
            }
        }

        public static TextSaveFile Read(string filekey, char delimeter = '=')
        {
            // Check if file exists
            if (!Exists(filekey))
            {
                return null;
            }

            // Read the file
            TextSaveFile settingsTextFile = new TextSaveFile();
            List<string> lines = new List<string>(File.ReadAllLines(filekey));
            string[] settingsFileEntry;
            DataTypes dataType;

            // Parse each line
            foreach(string line in lines)
            {
                settingsFileEntry = line.Split(delimeter);

                if(settingsFileEntry.Length != 3)
                {
                    throw new InvalidDataException();
                }

                // Allow enum parse exception to be thrown to user
                dataType = StringToDataType[settingsFileEntry[1]];

                // Add entry based on data type
                // String Variables
                if(dataType == DataTypes.String)
                {
                    settingsTextFile.Add(settingsFileEntry[0], settingsFileEntry[2]);
                }
                else if(dataType == DataTypes.Char)
                {
                    settingsTextFile.Add(settingsFileEntry[0], char.Parse(settingsFileEntry[2]));
                }
                else if (dataType == DataTypes.DateTime)
                {
                    settingsTextFile.Add(settingsFileEntry[0], DateTime.Parse(settingsFileEntry[2]));
                }

                // Signed Variables
                else if (dataType == DataTypes.Bool)
                {
                    settingsTextFile.Add(settingsFileEntry[0], bool.Parse(settingsFileEntry[2]));
                }
                else if (dataType == DataTypes.SByte)
                {
                    settingsTextFile.Add(settingsFileEntry[0], sbyte.Parse(settingsFileEntry[2]));
                }
                else if (dataType == DataTypes.Short)
                {
                    settingsTextFile.Add(settingsFileEntry[0], short.Parse(settingsFileEntry[2]));
                }
                else if (dataType == DataTypes.Int)
                {
                    settingsTextFile.Add(settingsFileEntry[0], int.Parse(settingsFileEntry[2]));
                }
                else if (dataType == DataTypes.Long)
                {
                    settingsTextFile.Add(settingsFileEntry[0], long.Parse(settingsFileEntry[2]));
                }

                // Unsigned Variables
                else if (dataType == DataTypes.Byte)
                {
                    settingsTextFile.Add(settingsFileEntry[0], byte.Parse(settingsFileEntry[2]));
                }
                else if (dataType == DataTypes.UShort)
                {
                    settingsTextFile.Add(settingsFileEntry[0], ushort.Parse(settingsFileEntry[2]));
                }
                else if (dataType == DataTypes.UInt)
                {
                    settingsTextFile.Add(settingsFileEntry[0], uint.Parse(settingsFileEntry[2]));
                }
                else if (dataType == DataTypes.ULong)
                {
                    settingsTextFile.Add(settingsFileEntry[0], ulong.Parse(settingsFileEntry[2]));
                }

                // Decimal Variables
                else if (dataType == DataTypes.Double)
                {
                    settingsTextFile.Add(settingsFileEntry[0], double.Parse(settingsFileEntry[2]));
                }
                else if (dataType == DataTypes.Float)
                {
                    settingsTextFile.Add(settingsFileEntry[0], float.Parse(settingsFileEntry[2]));
                }
                else if (dataType == DataTypes.Decimal)
                {
                    settingsTextFile.Add(settingsFileEntry[0], decimal.Parse(settingsFileEntry[2]));
                }
            }

            return settingsTextFile;
        }

        #region Add

        /// <summary>
        /// Adds a string to the save file
        /// </summary>
        public void Add(string key, string value)
        {
            Strings.Add(key, value);
        }
        /// <summary>
        /// Adds a char to the save file
        /// </summary>
        public void Add(string key, char value)
        {
            Chars.Add(key, value);
        }
        /// <summary>
        /// Adds a DateTime to the save file
        /// </summary>
        public void Add(string key, DateTime value)
        {
            DateTimes.Add(key, value);
        }
        /// <summary>
        /// Adds a bool to the save file
        /// </summary>
        public void Add(string key, bool value)
        {
            Bools.Add(key, value);
        }
        /// <summary>
        /// Adds an sbyte to the save file
        /// </summary>
        public void Add(string key, sbyte value)
        {
            SBytes.Add(key, value);
        }
        /// <summary>
        /// Adds a short to the save file
        /// </summary>
        public void Add(string key, short value)
        {
            Shorts.Add(key, value);
        }
        /// <summary>
        /// Adds an int to the save file
        /// </summary>
        public void Add(string key, int value)
        {
            Ints.Add(key, value);
        }
        /// <summary>
        /// Adds a long to the save file
        /// </summary>
        public void Add(string key, long value)
        {
            Longs.Add(key, value);
        }
        /// <summary>
        /// Adds a byte to the save file
        /// </summary>
        public void Add(string key, byte value)
        {
            Bytes.Add(key, value);
        }
        /// <summary>
        /// Adds a ushort to the save file
        /// </summary>
        public void Add(string key, ushort value)
        {
            UShorts.Add(key, value);
        }
        /// <summary>
        /// Adds a uint to the save file
        /// </summary>
        public void Add(string key, uint value)
        {
            UInts.Add(key, value);
        }
        /// <summary>
        /// Adds a ulong to the save file
        /// </summary>
        public void Add(string key, ulong value)
        {
            ULongs.Add(key, value);
        }

        /// <summary>
        /// Adds a double to the save file
        /// </summary>
        public void Add(string key, double value)
        {
            Doubles.Add(key, value);
        }
        /// <summary>
        /// Adds a float to the save file
        /// </summary>
        public void Add(string key, float value)
        {
            Floats.Add(key, value);
        }
        /// <summary>
        /// Adds a decimal to the save file
        /// </summary>
        public void Add(string key, decimal value)
        {
            Decimals.Add(key, value);
        }

        #endregion

        #region Get

        /// <summary>
        /// Gets a string from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public string GetString(string key)
        {
            if (Strings.ContainsKey(key))
            {
                return Strings[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets a char from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public char? GetChar(string key)
        {
            if (Chars.ContainsKey(key))
            {
                return Chars[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets a DateTime from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public DateTime? GetDateTime(string key)
        {
            if (DateTimes.ContainsKey(key))
            {
                return DateTimes[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets a bool from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public bool? GetBool(string key)
        {
            if (Bools.ContainsKey(key))
            {
                return Bools[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets an sbyte from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public sbyte? GetSByte(string key)
        {
            if (SBytes.ContainsKey(key))
            {
                return SBytes[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets a short from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public short? GetShort(string key)
        {
            if (Shorts.ContainsKey(key))
            {
                return Shorts[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets an int from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public int? GetInt(string key)
        {
            if (Ints.ContainsKey(key))
            {
                return Ints[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets a long from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public long? GetLong(string key)
        {
            if (Longs.ContainsKey(key))
            {
                return Longs[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets a byte from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public byte? GetByte(string key)
        {
            if (Bytes.ContainsKey(key))
            {
                return Bytes[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets a ushort from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public ushort? GetUShort(string key)
        {
            if (UShorts.ContainsKey(key))
            {
                return UShorts[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets a uint from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public uint? GetUInt(string key)
        {
            if (UInts.ContainsKey(key))
            {
                return UInts[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets a ulong from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public ulong? GetULong(string key)
        {
            if (ULongs.ContainsKey(key))
            {
                return ULongs[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets a double from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public double? GetDouble(string key)
        {
            if (Doubles.ContainsKey(key))
            {
                return Doubles[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets a float from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public float? GetFloat(string key)
        {
            if (Floats.ContainsKey(key))
            {
                return Floats[key];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets a decimal from the save file
        /// </summary>
        /// <param name="key"></param>
        /// <returns> null if key not found </returns>
        public decimal? GetDecimal(string key)
        {
            if (Decimals.ContainsKey(key))
            {
                return Decimals[key];
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}
