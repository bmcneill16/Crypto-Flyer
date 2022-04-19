using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private Spawner spawner;

    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.Find("Obstacle Spawner").GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            spawner.GameOver();
            Debug.Log("Gameover!");
        }
    }
}
