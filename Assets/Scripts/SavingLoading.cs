using UnityEngine;
using System.IO;
using Unity.VisualScripting;

public static class SavingLoading
{
    public static void savePlayer(Player player)
    {
        string path = Application.persistentDataPath + "player.save";
        // BinaryFormatter formatter = new BinaryFormatter();
        // FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(player);

        // New Save function
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(path, json);


        // formatter.Serialize(stream, data);
        // stream.Close();
    }

    public static PlayerData loadPlayer()
    {
        string path = Application.persistentDataPath + "player.save";
        if (File.Exists(path))
        {
            
            // BinaryFormatter formatter = new BinaryFormatter();
            
            // FileStream stream = new FileStream(path, FileMode.Open);

            // PlayerData data = formatter.Deserialize(stream) as PlayerData;

            //Newsave
            string json = File.ReadAllText(path);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);

            return data;
        }
        else
        {
            Debug.LogError("Save File not Found" + path);
            return null;
        } 
    }

}
