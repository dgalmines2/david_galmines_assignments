/**********************************************************************************************************************
// File Name : Hydrogen.cs
// Author : David Galmines
// Creation Date : February 5, 2024
//
// Brief Description : This derived class sets values for the atom class to process
**********************************************************************************************************************/
using UnityEngine;

public class Hydrogen : Atom
{
    /// <summary>
    /// Calls function from Atom class but with Hydrogen's parameters
    /// </summary>
    public Hydrogen() : base()
    {
        //calls function in base class, setting values for one proton and one electron
        AtomData(1, 1);
    }

    /// <summary>
    /// Overrides the print function of the base class to only display the number of protons in an atom
    /// </summary>
    protected override void Print()
    {
        Debug.Log("This atom has " + Protons + " protons.");
    }
    
    /// <summary>
    /// Resets proton and electron counts in base class upon destruction
    /// </summary>
    ~Hydrogen()
    {
        //calls function in base class, subtracting the current proton and electron values to zero everything out
        AtomData(-Protons, -Electrons);
    }
}
