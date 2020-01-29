using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] //To be able to see it from the scene
    private Stats health;

    // Start is called before the first frame update
    private void Awake()
    {
        health.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) //To lower the stamina bar and accelerate
        {
            health.CurrentVal -= 10;

        }
        health.CurrentVal += Time.deltaTime*4;
        //health.CurrentVal += 1;
    }
}
