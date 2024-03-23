using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileHandler
{

    private string _dataDirPath;
    private string _dataFileName;

    public FileHandler(string dataDirPath, string dataFileName)
    {
        _dataDirPath = dataDirPath;
        _dataFileName = dataFileName;
    }

    public GameData Load()
    {
        string fullPath = Path.Combine(_dataDirPath, _dataFileName);
        GameData data = null;
        if (File.Exists(fullPath))
        {
            try
            {
                string dataToLoad = "";
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        dataToLoad = reader.ReadToEnd();
                    }

                    data = JsonUtility.FromJson<GameData>(dataToLoad);
                }
            } catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
        }
        return data;
    }

    public void Save(GameData gameData)
    {
        string fullPath = Path.Combine(_dataDirPath, _dataFileName);
        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

            string dataToStore = JsonUtility.ToJson(gameData, true);

            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataToStore);
                }
            }

        } catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
    }
}
