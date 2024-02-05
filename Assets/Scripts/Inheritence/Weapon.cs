using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon 
{
    private string weaponName;
    private int weaponStrength;

    protected string WeaponName { get => weaponName; set => weaponName = value; }
    protected int WeaponStrength { get => weaponStrength; set => weaponStrength = value; }

    protected virtual void UseWeapon(int damage)
    {
        WeaponStrength -= damage;
    }
}
