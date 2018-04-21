using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour
{

    [Header("PUBLIC")]
    public float jumpForce;
    public static bool grounded;
    public LayerMask whatIsGround;
    private Rigidbody2D myRigidbody;
    private Collider2D myCollider;
    public GameObject player;
    public GameObject player2;
    public KeyCode tecla;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        if (Troca.trocou == false)
        {
            tecla = KeyCode.W;
        }
        else {
            tecla = KeyCode.UpArrow;        
        }

            if (Input.GetKeyDown(tecla)){
                if (grounded && this.gameObject == player.gameObject)            {
                    myRigidbody.AddForce(new Vector2(0, 30), ForceMode2D.Impulse);
                }
                
                if (grounded && this.gameObject == player2.gameObject) {
                    myRigidbody.AddForce(new Vector2(0, -30), ForceMode2D.Impulse);
                }
        }
        
    }
}