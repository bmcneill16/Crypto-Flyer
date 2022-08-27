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
    // Start is called before the first frame update
    void Start()
    {
        musicChoices[0].Stop(); //Used to stop the music from playing upon opening the scene. 
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
        public float score;
    }
        

    public void SaveScore()
    {

    }

    public void LoadScore()
    {

    }
}
