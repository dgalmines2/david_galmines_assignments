using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private EnemyData EnemyData;

    // Start is called before the first frame update
    void Start()
    {
        print("Name = " + EnemyData.EnemyName1 + " has " + EnemyData.EnemyHealth1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            EnemyData.Attacked(7);
        }
    }
}
