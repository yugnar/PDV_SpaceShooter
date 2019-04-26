using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public GameObject bullet;

    void Start()
    {

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        var position = gameObject.transform.position;
        position.x += moveHorizontal * speed;
        position.y += moveVertical * speed;
        gameObject.transform.position = position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletInstance = Instantiate(bullet, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.Euler(0,0,-90));
        }
    }
}
