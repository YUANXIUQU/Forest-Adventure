using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class obstacle : MonoBehaviour
{
    public GameObject spawnpoint;
    public GameObject player;

    void OnTriggerEnter2D(Collider2D player)
    {
        if(player.name == "character")
        { 
            health_management.health--;
            if(health_management.health <= 0)
            {
                gameObject.SetActive(false);
            }
            player.transform.position = spawnpoint.transform.position;
        }
    }

}
