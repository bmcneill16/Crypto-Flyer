using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;



public class Options : MonoBehaviour
{

    public TMP_Dropdown musicChoice;
    public MainManager mainManager;
    
    
    // Start is called before the first frame update
    void Start()
    {
        mainManager = MainManager.instance;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectMusic()
    {
        if (musicChoice.value == 0)//determines the choice from the dropdown items
        {
            mainManager.audioSource = mainManager.musicChoices[0];//Carry over the selected track into the MainManager script, so it can be used in other scenes
            mainManager.audioSource.Play();//Plays selected track
            mainManager.musicChoices[1].Stop();//Stops other tracks that may have been previously selected. 
            mainManager.musicChoices[2].Stop();
        }
        if (musicChoice.value == 1)
        {
            mainManager.audioSource = mainManager.musicChoices[1];
            mainManager.audioSource.Play();
            mainManager.musicChoices[0].Stop();
            mainManager.musicChoices[2].Stop();
        }
        if (musicChoice.value == 2)
        {
            mainManager.audioSource = mainManager.musicChoices[2];
            mainManager.audioSource.Play();
            mainManager.musicChoices[0].Stop();
            mainManager.musicChoices[1].Stop();
        }
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
