using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMainController : MonoBehaviour
{
    private MainManager mainManager;

    public void playGame()
    {
        SceneManager.LoadScene("GameScene");
        mainManager = MainManager.instance;
    }

    public void options()
    {
        SceneManager.LoadScene("Options");
    }

    public void exitGame()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
