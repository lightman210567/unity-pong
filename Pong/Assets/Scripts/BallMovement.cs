using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class BallMovement : MonoBehaviour
{
    // Initialise properties/variables
    public float randomXMaximum;
    public float randomYMaximum;
    public float randomXMinimum;
    public float randomYMinimum;
    public Rigidbody2D rigidBody;

    // A function to give the ball a random velocity
    private void RandomVelocity()
    {
        float randomX = Random.Range(randomXMinimum, randomXMaximum);
        float randomY = Random.Range(randomYMinimum, randomYMaximum);

        rigidBody.linearVelocityX = randomX;
        rigidBody.linearVelocityY = randomY;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RandomVelocity();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
