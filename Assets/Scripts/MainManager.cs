using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class MainManager : MonoBehaviour
{
    public static MainManager instance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [Serializable]
    class SaveData
    {
        public float score;
        public AudioSource audioSource;
    }
        

    public void SaveMusicTrack()
    {

    }

    public void LoadMusicTrack()
    {

    }

    public void SaveScore()
    {

    }

    public void LoadScore()
    {

    }
}
