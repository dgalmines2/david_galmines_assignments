/**********************************************************************************************************************
// File Name : BoxDestroyer.cs
// Author : David Galmines
// Creation Date : January 25, 2024
//
// Brief Description : This script tells spawned boxes to destroy themselves after pressing escape.
**********************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroyer : MonoBehaviour
{
    /// <summary>
    /// Pressing escape destroys the box
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Destroy(gameObject);
        }
    }
}
