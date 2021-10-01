using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public enum StorageType
{
    File,
    PlayerPrefs
}

public class StorageExample : MonoBehaviour
{
    private const string DirectoryPath = "D:\\Temp";
    private const string FileName = "PlayerStorage";
    private const string FileExtension = ".json";

    [SerializeField] private StorageType _storageType;

    private GameStorage _gameStorage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SaveToPlayerPrefs(string storageRaw)
    {
        PlayerPrefs.SetString(FileName, storageRaw);
    }

    private string LoadFromPlayerPrefs()
    {
        return PlayerPrefs.GetString(FileName, string.Empty);
    }

    private void SaveToFile(string storageRaw)
    {
        if (!Directory.Exists(DirectoryPath))
        {
            Directory.CreateDirectory(DirectoryPath);
        }
        var reservedPath = Application.persistentDataPath;

        var fullFileName = $"{DirectoryPath}\\{FileName}{FileExtension}";
        var fullFileName2 = Path.Combine(DirectoryPath, $"{FileName}{FileExtension}");

        using (FileStream fileStream = new FileStream(fullFileName, FileMode.OpenOrCreate))
        {
            byte[] array = System.Text.Encoding.Default.GetBytes(storageRaw);
            fileStream.Write(array, 0, array.Length);
            Debug.Log("Storage was saved");
        }
    }

    private string GetStorageFromFile()
    {
        var fullFileName2 = Path.Combine(DirectoryPath, $"{FileName}{FileExtension}");
        if (!File.Exists(fullFileName2))
        {
            Debug.Log($"File with full path: {fullFileName2} did not exist");
            return null;
        }

        string result = string.Empty;

        using (FileStream fileStream = File.OpenRead(fullFileName2))
        {
            byte[] array = new byte[fileStream.Length];

            fileStream.Read(array, 0, array.Length);

            result = System.Text.Encoding.Default.GetString(array);
            Debug.Log($"Was loaded raw data: {result}");
        }

        return result;
    }

    private GameStorage GetGameStorage()
    {
        return new GameStorage()
        {
            LiveCount = UnityEngine.Random.Range(1, 5),
            Coins = UnityEngine.Random.Range(10, 500),
            LastPosition = UnityEngine.Random.insideUnitCircle
        };
    }

    [ContextMenu("Test Load Data")]
    private void TestLoadData()
    {
        var dataStorageRaw = _storageType == StorageType.File ? GetStorageFromFile() : LoadFromPlayerPrefs();
        if (string.IsNullOrEmpty(dataStorageRaw))
        {
            return;
        }

        Debug.Log($"Data Storage Raw: {dataStorageRaw}");

        _gameStorage = JsonUtility.FromJson<GameStorage>(dataStorageRaw);
        PrintGameStorageData(_gameStorage);
    }

    [ContextMenu("Test Save Data")]
    private void TestSaveStorageData()
    {
        _gameStorage = GetGameStorage();
        PrintGameStorageData(_gameStorage);
        var dataStorageRaw = JsonUtility.ToJson(_gameStorage, true);
        if (_storageType == StorageType.File)
        {
            SaveToFile(dataStorageRaw);
        }
        else
        {
            SaveToPlayerPrefs(dataStorageRaw);
        }
    }

    private void PrintGameStorageData(GameStorage gameStorage)
    {
        Debug.Log($"Storage Data: LiveCount: {gameStorage.LiveCount}, Coins: {gameStorage.Coins}, LastPosition: {gameStorage.LastPosition}");
    }
}

[System.Serializable]
public class GameStorage
{
    public int LiveCount;
    public int Coins;
    public Vector3 LastPosition;
}

