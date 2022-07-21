using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class SaveSystem 
{
    static string path = Application.persistentDataPath + "/PlayerData.aps";
    
    public static void Save()
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        PlayerData data = new PlayerData();

        FileStream file = File.Create(path);
        binaryFormatter.Serialize(file, data);
        file.Close();
    }

    public static PlayerData Load()
    {
        if (File.Exists(path))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = File.Open(path, FileMode.Open);
            PlayerData data = binaryFormatter.Deserialize(file) as PlayerData;
            file.Close();

            return data;
        }
        else
        {
            return null;
        }
    }

    public static void Delete()
    {
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }


}
