using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class MainManager : MonoBehaviour
{
    public static MainManager instance;
    public AudioSource audioSource;
    public List<AudioSource> musicChoices;
    public float bestScore = 0;
    public Options options;
    // Start is called before the first frame update
    void Start()
    {
        musicChoices[0].Play(); //Used to stop the music from playing upon opening the scene. 
        musicChoices[1].Stop();
        musicChoices[2].Stop();

        if (instance == null)  //checks to see if an instance of the gameobject already exists before carrying over the current one.
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject); //Used to transfer over saved data, as well as music selection.

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    [Serializable]
    class SaveData
    {
        public float bestScore;
    }
        

    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.bestScore = bestScore;

        string jsonScore = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + " /savefile.json", jsonScore);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + " /savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(path);

            bestScore = data.bestScore;
        }
    }
}
