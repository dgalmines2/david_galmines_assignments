/**********************************************************************************************************************
// File Name : WeaponData.cs
// Author : David Galmines
// Creation Date : February 10th, 2024
//
// Brief Description : This scriptable object establishes data fields for weapon name, description, damage, origin, and
                       weight.
**********************************************************************************************************************/
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponData", menuName = "Weapon Data")]   //makes it visible in the "create" menu in unity
public class WeaponData : ScriptableObject
{
    [SerializeField] private string WeaponName;                                                        //name of weapon
    [SerializeField] private string WeaponDescription;                                    //brief description of weapon
    [SerializeField] private string WeaponOrigin;                                  //place where weapon originated from
    [SerializeField] private int WeaponDamage;                                       //how much damage the weapon deals
    [SerializeField] private float WeaponWeight;                                           //how much the weapon weighs

    //encapsulates variables to be accessed from WeaponController
    public string WeaponName1 { get => WeaponName; set => WeaponName = value; }
    public string WeaponDescription1 { get => WeaponDescription; set => WeaponDescription = value; }
    public string WeaponOrigin1 { get => WeaponOrigin; set => WeaponOrigin = value; }
    public int WeaponDamage1 { get => WeaponDamage; set => WeaponDamage = value; }
    public float WeaponWeight1 { get => WeaponWeight; set => WeaponWeight = value; }
}
