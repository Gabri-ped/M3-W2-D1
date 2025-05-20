using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int playerNumber;
    [SerializeField] float speed;
    private float _jumpTimer = 0;
    private bool _isJumping = false;
    private string playerHorinzotal;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        playerHorinzotal = "P" + playerNumber + "Horizontal";
    }

    void Update()
    {

        if (playerNumber == 1)
        {

            if (Input.GetButtonDown("P1Jump"))
            {
                Debug.Log("Jump Button Down");
                _isJumping = true;
            }
            if (_isJumping)
            {
                _jumpTimer = Time.deltaTime;

                _rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);

                _isJumping = false;
            }



        }
        if (playerNumber == 2)
        {

            if (Input.GetButtonDown("P2Jump")) 
            {
                Debug.Log("Jump Button Down");
                _isJumping = true;
            }

            if (_isJumping)
            {
                _jumpTimer = Time.deltaTime;

                _rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);

                _isJumping = false;
            }

        }
    }


        void FixedUpdate()
        {
                
            float h = Input.GetAxis(playerHorinzotal);
            Vector2 dir = new Vector2(h, 0);
            Vector2 velocity = _rb.velocity;

            velocity.x = dir.x * speed;
            _rb.velocity = velocity;

            // _rb.MovePosition(_rb.position + (dir * (speed * Time.deltaTime)));



        }
}
