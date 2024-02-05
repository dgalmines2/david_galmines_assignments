using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Gun tommyGun;
    private Gun revolver;

    private void Start()
    {
        tommyGun = new Gun();
        revolver = new Gun("Revolver");
    }
}
