using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MechantHolder : MonoBehaviour
{
    
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public int xPos;
    public int zPos;
    public int enemyCount;
    public int rdmenemy;

  
    public float spawnRate = 0.2f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    

    }
    IEnumerator EnemyDrop()
    {
        GameObject Enemy = Enemy1;
        while (enemyCount < 10)
        {
            rdmenemy = Random.Range(1, 4);
            if(rdmenemy == 1)
            {
                 Enemy = Enemy1;
            }
            else
            {
                if (rdmenemy == 2)
                {
                    Enemy = Enemy2;
                }
                else
                {
                    if (rdmenemy == 3)
                    {
                        Enemy = Enemy3;
                    }
                    else
                    {
                        if (rdmenemy == 4)
                        {
                             Enemy = Enemy4;
                        }
                    }
                }
            }
            xPos = Random.Range(12, 38);
            zPos = Random.Range(15, 39);

            Instantiate(Enemy, new Vector3(xPos, 20, zPos), Quaternion.identity);
            yield return new WaitForSeconds(4f);
            enemyCount += 1;
        }

    }





}