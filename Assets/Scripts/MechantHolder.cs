using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MechantHolder : MonoBehaviour
{
    public GameObject mechant;
    
    
    public GameObject Enemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

  
    public float spawnRate = 0.2f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    

    }
    IEnumerator EnemyDrop()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(12, 38);
            zPos = Random.Range(15, 39);
            Instantiate(Enemy, new Vector3(xPos, 20, zPos), Quaternion.identity);
            yield return new WaitForSeconds(4f);
            enemyCount += 1;
        }

    }





}