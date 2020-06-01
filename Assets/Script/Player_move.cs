using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_move : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float speed;
    public Text scoreText;
    int score;

    
    void Start()
    {
        score = 0;
    }

    
    void Update()
    {

    }

    private void FixedUpdate()
    {
        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movementHorizontal, 0f, movementVertical);
        myRigidbody.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Pickup"))
        {
           
            other.gameObject.SetActive(false);

            score += other.gameObject.GetComponent<Pickup>().points;
            scoreText.text = "Score = " + score;
        }
    }
}
