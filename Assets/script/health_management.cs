using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class health_management : MonoBehaviour
{
    public static int health = 3;
    public Image[] hearts;
    public Sprite fullheart;
    public Sprite emptyheart;
    public timecount timecount;

    void Update()
    {
        foreach(Image img in hearts)
        {
            img.sprite = emptyheart;
        }
        for (int i = 0; i < health; i++)
        {
            hearts[i].sprite = fullheart;
        }


        if(health <= 0)
        {
            timecount.GetComponent<timecount>().Endgametime();
            Time.timeScale = 0;
        }
    }
}
