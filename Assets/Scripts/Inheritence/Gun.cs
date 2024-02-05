using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    public Gun() : base()
    {
        base.WeaponName = "TommyGun";
        WeaponStrength = 700;
    }

    public Gun(string wName)
    {
        WeaponName = wName;
        WeaponStrength += 10;
    }
}
