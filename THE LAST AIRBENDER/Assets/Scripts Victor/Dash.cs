﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour {

    [Header("Normal Variables")]
    private BoxCollider2D myCollider;
    private Rigidbody2D myRigidbody;
    public Vector2 savedVelocity;

    [Header("Dash Variables")]
    public float dashDistance;
    public DashState dashState;
    public float dashTimer;
    public float maxDash = 20f;
    private float dashForce = 5000f;
    private KeyCode tecla;

    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate() {
        switch (dashState) {

            case DashState.Ready:
                if (Troca.trocou == false)
                {
                    tecla = KeyCode.UpArrow;
                }
                else {
                    tecla = KeyCode.W;
                }

                if (Input.GetKeyDown(tecla))
                    {
                        savedVelocity.x = myRigidbody.velocity.x;
                        myRigidbody.AddForce(new Vector2 (dashForce*2f, 0));
                        //myRigidbody.velocity = new Vector2(myRigidbody.velocity.x * 20f, myRigidbody.velocity.y);
                        dashState = DashState.Dashing;
                        playerJump.grounded = true;
                        player2Jump.grounded = true;
                        Debug.Log(myRigidbody.velocity);
                          
                    }
                
                break;

            case DashState.Dashing:
                dashTimer += Time.deltaTime * 3f;
                if (dashTimer >= maxDash)
                {
                    dashTimer = maxDash;
                    myRigidbody.velocity = savedVelocity;
                    dashState = DashState.CoolDown;
                    playerJump.grounded = false;
                    player2Jump.grounded = false;
                }
                break;

            case DashState.CoolDown:
                dashTimer -= Time.deltaTime;
                if (dashTimer <= 0)
                {
                    dashTimer = 0;
                    dashState = DashState.Ready;
                }
                break;
        }
    }


    public enum DashState { 

        Ready,Dashing,CoolDown
}
}
