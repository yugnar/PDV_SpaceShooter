using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public GameObject bullet;
    private SpriteRenderer shipRenderer;

    private int lives = 5;

    void Start()
    {
        shipRenderer = gameObject.GetComponent<SpriteRenderer>();
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
        if(lives == 0)
        {
            GManager.instance.protocolEndgame();
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collisionObject)
    {
        if (collisionObject.gameObject.CompareTag("Missile") || collisionObject.gameObject.CompareTag("Meteor") || collisionObject.gameObject.CompareTag("EnemyShip"))
        {
            lives = lives - 1;
            GManager.instance.updateHP(lives);
            damageDisplay();
        }
    }

    void damageDisplay()
    {
        shipRenderer.color = new Color(0.8509804f, 0.1882353f, 0.1882353f);
        Invoke("colorNormalize", 1.0f);
    }

    void colorNormalize()
    {
        shipRenderer.color = Color.white;
    }
}
