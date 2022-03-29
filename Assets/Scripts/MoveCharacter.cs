using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public Rigidbody2D character;

    public bool _canMove;
    public float _speed;
    public float _jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        character.velocity = new Vector2(_speed, character.velocity.y);

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                character.velocity = new Vector2(character.velocity.x, _jumpForce);
            }
        }
    }
}
