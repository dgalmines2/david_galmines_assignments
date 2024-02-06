/**********************************************************************************************************************
// File Name : Atom.cs
// Author : David Galmines
// Creation Date : February 5, 2024
//
// Brief Description : This base class establishes properties of atoms, like proton count and electron count
**********************************************************************************************************************/
using UnityEngine;

public class Atom 
{
    private int protonCount;                                                   //int keeping track of number of protons
    private int electronCount;                                               //int keeping track of number of electrons

    //implicitly sets and gets ProtonCount value to be accessed from other classes with the Protons property
    protected int Protons { get => protonCount; set => protonCount = value; }

    //implicitly sets and gets ElectronCount value to be accessed from other classes with the Electrons property
    protected int Electrons { get => electronCount; set => electronCount = value; }

    /// <summary>
    /// Updates proton and electron count with parameters from derived atom classes
    /// </summary>
    /// <param name="Protons">number of protons in the atom</param>
    /// <param name="Electrons">number of electrons in the atom</param>
    protected void AtomData(int Protons, int Electrons)
    {
        //updates proton and electron counts from derived class
        protonCount += Protons;
        electronCount += Electrons;

        //calls the function that prints the data in the console
        Print();
    }

    /// <summary>
    /// Prints how many protons and electrons are in an atom in the console, allows for overrides
    /// </summary>
    protected virtual void Print()
    {
        Debug.Log("This atom has " + protonCount + " protons and " + electronCount + " electrons.");
    }
}
