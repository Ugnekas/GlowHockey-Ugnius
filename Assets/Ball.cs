using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public TMP_Text enemyScore;
    public TMP_Text playerScore;
    public int currentEnemyScore = 0;
    public int currentPlayerScore = 0;

    private AudioSource playerGoalSource;
    private AudioSource enemyGoalSource;
    private AudioSource collisionSource;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyScore.text = currentEnemyScore.ToString();
        playerScore.text = currentPlayerScore.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collisionSource.pitch = Random.Range(0.0f, 2.2f);
        collisionSource.Play();

        if (collision.gameObject.name.Contains("Gates"))
        {
            print("goal");
            
        }

        if (collision.gameObject.name.Contains("Player Gates"))
        {
            currentEnemyScore++;
            transform.position = Vector3.left;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            playerGoalSource.Play();
        }
        if (collision.gameObject.name.Contains("Enemy Gates"))
        {
            currentPlayerScore++;
            transform.position = Vector3.right;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            enemyGoalSource.Play();
        }
    }

    
}
