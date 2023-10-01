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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyScore.text = currentEnemyScore.ToString();
        playerScore.text = currentPlayerScore.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Gates"))
        {
            print("goal");
            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (collision.gameObject.name.Contains("Player Gates"))
        {
            currentEnemyScore++;
        }
        if (collision.gameObject.name.Contains("Enemy Gates"))
        {
            currentPlayerScore++;
        
        }
    }

    
}
