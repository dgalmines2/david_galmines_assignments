using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : Weapon
{
    protected override void UseWeapon(int damage)
    {
        base.UseWeapon(damage * 2);
    }
}
