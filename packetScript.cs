using Unity.Collections.Tests.CoreCLR.TestJobs;
using UnityEngine;

public class packetScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
   public LogicScript logic;
   public bool packetIsSafe = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && packetIsSafe)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
    }

   private void OnCollisionEnter2D(Collision2D collision)
{
    logic.gameOver();
    packetIsSafe = false;
}
}
