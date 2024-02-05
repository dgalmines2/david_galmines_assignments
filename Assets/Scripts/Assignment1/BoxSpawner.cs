/**********************************************************************************************************************
// File Name : BoxSpawner.cs
// Author : David Galmines
// Creation Date : January 25, 2024
//
// Brief Description : This script spawns boxes from tapping the space bar, and clears boxes from the list upon tapping
                       escape.
**********************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxSpawner : MonoBehaviour
{
    //declares list for spawned boxes
    private List<GameObject> goList;

    //gives the script a reference of what to spawn (the box)
    public GameObject BoxInstance;

    //check in place when no boxes are on screen but the script is trying to access the reference
    private bool NoBoxes;

    /// <summary>
    /// Creates list of boxes
    /// </summary>
    void Start()
    {
        //defines list for spawned boxes
        goList = new List<GameObject>();

        //scene loads with one box, so the bool is set to false
        NoBoxes = false;    
    }

    /// <summary>
    /// Instantiates a box upon pressing space
    /// </summary>
    void Update()
    {
        //check for space bar being pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //initial check to see if any boxes are on screen
            //this is in place because after every box gets deleted, the script loses its reference for what to spawn
            if (NoBoxes)
            {
                SceneManager.LoadScene(0);                                             //reloads scene with box present
            }
            //if boxes are on screen, then the script has a reference of what it needs to instantiate
            else
            {
                Instantiate(BoxInstance);                                                                  //spawns box
                BoxInstance.transform.position = new Vector3(0, 4, 0);                    //spawns box at top of screen
                goList.Add(BoxInstance);                                                     //adds spawned box to list
            }
        }

        //clears list upon pressing escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //clears list
            goList.Clear();

            //this bool activates when there are zero boxes on screen, this changes what happens when pressing space
            NoBoxes = true;
        }
    }


}
