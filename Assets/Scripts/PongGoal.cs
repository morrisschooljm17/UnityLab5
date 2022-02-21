using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PongGoal : MonoBehaviour
{
    [SerializeField] private PongBall ball;
    [SerializeField] private TMP_Text goalText;
    private int Score = 0;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Score++;
            ball.Restart();
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goalText.text = "" + Score;

    }
}
