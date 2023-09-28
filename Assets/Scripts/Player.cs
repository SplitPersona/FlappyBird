using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public bool IsDead = false;
    public float velocity = 2.4f;
    public Rigidbody2D rigidbody;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            rigidbody.velocity = Vector2.up * velocity;  
        }      
    }

    private void OnCollisionEnter20(Collision2D other)
    {
            IsDead = true;
            gameManager.GameOver();
    }
}


