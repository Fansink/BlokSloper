using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public Paddle paddle;
    public Rigidbody2D rb;

    private bool hasStarted = false;
    private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
        paddleToBallVector = transform.position - paddle.transform.position;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted)
        {
            // De bal wordt vergezet op de paddle
            transform.position = paddle.transform.position + paddleToBallVector;
            
            // Wachten op de muisklik
            if (Input.GetMouseButtonDown(0))
            {
                print("Pressed left click, bal afvuren");
                hasStarted = true;
                rb.velocity = new Vector2 (2f, 10f);
            }
        }
    }
}