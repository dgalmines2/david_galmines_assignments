/**********************************************************************************************************************
// File Name : WeaponController.cs
// Author : David Galmines
// Creation Date : February 10th, 2024
//
// Brief Description : This script gathers data from WeaponData, and prints it in the console in complete sentences.
**********************************************************************************************************************/
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private WeaponData WD;          //gives script access to scriptable object through unity inspector

    /// <summary>
    /// Prints the information of each weapon upon start up
    /// </summary>
    void Start()
    {
        //prints weapon sentences in console
        print("The " + WD.WeaponName1 + " is a " + WD.WeaponDescription1 + ".");
        print("Originating from " + WD.WeaponOrigin1 + ", this " + WD.WeaponWeight1 + " pound weapon deals " + 
            WD.WeaponDamage1 + " damage!");
    }
}
