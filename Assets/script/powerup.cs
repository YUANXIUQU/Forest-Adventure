using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class powerup : MonoBehaviour
{
    public powerupeffect buff;
    public TMP_Text sign_text;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "character")
        {
           Destroy(gameObject);
           Destroy(sign_text);
           buff.Apply(other.gameObject);
        }
    }
}
