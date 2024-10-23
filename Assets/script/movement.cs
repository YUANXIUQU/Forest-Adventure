using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D character;
    bool looking_right = true;
    public float Max_character_speed = 5;

    public SpriteRenderer character_Sprite;

    public Animator Animation;
    public bool grounded = false;
    public float JumpPower = 5;
    public float groundCheckradius = 2f;
    public LayerMask groundLayer;
    public Transform groundCheck;

    public ParticleSystem dusteffect;
    void Start()
    {
        character = GetComponent<Rigidbody2D>();
        character_Sprite = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        float Horizontal_control = Input.GetAxis("Horizontal");
        character.velocity = new Vector2(Horizontal_control * Max_character_speed,character.velocity.y);
        if (Horizontal_control > 0 && !looking_right)
        {
            Reverse();
        }
        else if (Horizontal_control < 0 && looking_right)
        {
            Reverse();
        }

        Animation.SetFloat("Run_speed", Mathf.Abs(Horizontal_control));

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckradius, groundLayer);
        Animation.SetBool("isgrounded", grounded);

        if (grounded && Input.GetAxis("Jump") > 0)
        {
            dusteffect.Play();
            Animation.SetBool("isgrounded", false);
            character.velocity = new Vector2(character.velocity.x, 0f);
            character.AddForce(new Vector2(0, JumpPower), ForceMode2D.Impulse);
            grounded = false;
        }
        
    }

    void Reverse()
    {
        looking_right = !looking_right;
        transform.Rotate(0, 180, 0);
        
    }

    
}
