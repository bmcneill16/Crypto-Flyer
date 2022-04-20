using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{

    public GameObject[] stonesPrefab;
    public GameObject gameOverScreen;
    public TextMeshProUGUI scoreText;
    private OffsetScrolling offsetScrolling;
    //private AudioSource sound;
    //public AudioClip backgroundMusic;
    private float score;
    //public float height;
    private float spawnRangeX = 14f;
    private float spawnRangeY = 5f;
    private float queueTime = 1.7f;
    private float time = 0;



    // Start is called before the first frame update
    void Start()
    {

        offsetScrolling = GameObject.Find("Space").GetComponent<OffsetScrolling>();
        //sound = GetComponent<AudioSource>();
        //sound.Play();

    }

    // Update is called once per frame
    void Update()
    {
        if (offsetScrolling.isGameActive == true)
        {
            score += Time.deltaTime;
            scoreText.SetText("Score: " + Mathf.Round(score));

            if (score >= 30)
            {
                queueTime = 1.2f;
            }
            if (score >= 60)
            {
                queueTime = .7f;
            }
            if (score >= 90)
            {
                queueTime = .4f;
            }

        }

    }


    public IEnumerator SpawnStones()
    {

        while (offsetScrolling.isGameActive)
        {
            yield return new WaitForSeconds(queueTime);
            int stoneIndex = Random.Range(0, stonesPrefab.Length);
            Vector3 spawnPos = new Vector3(spawnRangeX, Random.Range(-spawnRangeY, spawnRangeY), 0);
            Instantiate(stonesPrefab[stoneIndex], spawnPos, stonesPrefab[stoneIndex].transform.rotation);

        }
    }

    public void GameOver()
    {
        offsetScrolling.isGameActive = false;
        gameOverScreen.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
