using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_info : MonoBehaviour
{
    public GameObject win_text;
    public GameObject lose_text;
    public static bool winstate;

    void Start()
    {
        winstate = false;
    }
    void OnCollisionEnter2D(Collision2D player)
    {
        if (player.gameObject.name == "character")
        {
            winstate = true;
            win_text.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void Update()
    {
        if(health_management.health <= 0)
        {
            winstate = false;
            lose_text.SetActive(true);
        }
    }

}
