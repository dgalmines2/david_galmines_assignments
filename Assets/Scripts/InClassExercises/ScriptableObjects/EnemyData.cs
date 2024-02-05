using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Enemy Data")]     //makes it visible in the "create" menu in unity
public class EnemyData : ScriptableObject
{
    [SerializeField] private string EnemyName;
    [SerializeField] private string EnemyDescription;
    [SerializeField] private int EnemyHealth;
    [SerializeField] private int EnemyDamage;
    [SerializeField] private float EnemySpeed;

    public string EnemyName1 { get => EnemyName; set => EnemyName = value; }    //encapsulated variables
    public string EnemyDescription1 { get => EnemyDescription; set => EnemyDescription = value; }
    public int EnemyHealth1 { get => EnemyHealth; set => EnemyHealth = value; }
    public int EnemyDamage1 { get => EnemyDamage; set => EnemyDamage = value; }
    public float EnemySpeed1 { get => EnemySpeed; set => EnemySpeed = value; }

    public void Attacked(int damage)
    {
        EnemyHealth1 += damage;

        Debug.Log("I have taken " + damage + " damage!");
    }
}
