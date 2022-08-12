using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Options : MonoBehaviour
{

    public List<AudioSource> musicChoices;
    public TMP_Dropdown musicChoice;
    
    
    // Start is called before the first frame update
    void Start()
    {
        musicChoices[0].Stop(); //Used to stop the music from playing upon opening the scene. 
        musicChoices[1].Stop();
        musicChoices[2].Stop(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectMusic()
    {
        if (musicChoice.value == 0)
        {
            musicChoices[0].Play();
            musicChoices[1].Stop();
            musicChoices[2].Stop();
        }
        if (musicChoice.value == 1)
        {
            musicChoices[1].Play();
            musicChoices[0].Stop();
            musicChoices[2].Stop();
        }
        if (musicChoice.value == 2)
        {
            musicChoices[2].Play();
            musicChoices[0].Stop();
            musicChoices[1].Stop();
        }
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

   
}
