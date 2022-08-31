using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetScrolling : MonoBehaviour
{
    
    private Renderer renderer;
    private Spawner spawner;
    public float scrollSpeed;
    public bool isGameActive;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        spawner = GameObject.Find("Obstacle Spawner").GetComponent<Spawner>();
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(x, 0);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }

    void StartGame()
    {
        isGameActive = true;
        spawner.StartCoroutine(spawner.SpawnStones());
    }
}
