using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public string dropDownTrackOne;
    public AudioClip trackOne;
    public AudioClip trackTwo;
    public AudioClip trackThree;
    private Dropdown musicChoice;       
    // Start is called before the first frame update
    void Start()
    {
        musicChoice = GetComponent<Dropdown>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelectMusic()
    {
        if (musicChoice.value == 0)
        {
            
        }
    }
}
