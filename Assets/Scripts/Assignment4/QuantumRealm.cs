/**********************************************************************************************************************
// File Name : QuantumRealm.cs
// Author : David Galmines
// Creation Date : February 5, 2024
//
// Brief Description : This script instantiates the Hydrogen class
**********************************************************************************************************************/
using UnityEngine;

public class QuantumRealm : MonoBehaviour
{
    public Hydrogen HydrogenAtom;                                      //grants access to everything in Hydrogen class
    /// <summary>
    /// Instantiates the Hydrogen class upon startup
    /// </summary>
    void Start()
    {
        HydrogenAtom = new Hydrogen();
    }
}
