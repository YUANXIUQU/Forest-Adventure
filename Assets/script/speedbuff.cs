using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "powerupeffect/speedbuff")]
public class speedbuff : powerupeffect
{
   public float amount;
   public override void Apply(GameObject target)
   {
       target.GetComponent<movement>().Max_character_speed += amount;
   }
}
