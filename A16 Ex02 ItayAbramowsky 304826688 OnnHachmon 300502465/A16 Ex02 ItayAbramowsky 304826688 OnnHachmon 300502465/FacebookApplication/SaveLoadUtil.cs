using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace FacebookApplication
{
    public class SaveLoadUtil
    {
        public static bool SaveAppData(string i_pathToSave, ApplicationConfigurationData i_AppData)
        {
            bool resultOfSaveOperation = false;
            StreamWriter dataWriter = null;
            try
            {
                XmlSerializer XmlAppConfigSerializer = new XmlSerializer(i_AppData.GetType());
                dataWriter = new StreamWriter(i_pathToSave);
                XmlAppConfigSerializer.Serialize(dataWriter, i_AppData);
                resultOfSaveOperation = true;
            }            
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (dataWriter != null)
                {
                    dataWriter.Close();
                }
            }

            return resultOfSaveOperation;
        }

        public static bool LoadAppData(string i_PathToLoad, ref ApplicationConfigurationData i_AppData)
        {
            bool resultOfLoad = false;
            StreamReader dataReader = null;

            if (File.Exists(i_PathToLoad))
            {
                try
                {
                    XmlSerializer XmlAppConfigDeserializer = new XmlSerializer(i_AppData.GetType());
                    dataReader = new StreamReader(i_PathToLoad);
                    i_AppData = (ApplicationConfigurationData)XmlAppConfigDeserializer.Deserialize(dataReader);
                    if (i_AppData != null)
                    {
                        resultOfLoad = true;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    if (dataReader != null)
                    {
                        dataReader.Close();
                    }
                }
            }

            return resultOfLoad;
        }
    }
}
