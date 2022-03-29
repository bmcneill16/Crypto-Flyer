using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{
    private Spawner spawner;
    private float leftLimit = -11f;
    private float bottomLimit = -6f;


    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.Find("Obstacle Spawner").GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < bottomLimit)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            spawner.GameOver();
        }
    }
}
