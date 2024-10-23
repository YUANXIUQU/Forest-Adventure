using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="powerupeffect/jumpbuff")]
public class jumpbuff : powerupeffect
{
    public float amount;
    public override void Apply(GameObject target)
    {
        target.GetComponent<movement>().JumpPower += amount;
    }
}

    
