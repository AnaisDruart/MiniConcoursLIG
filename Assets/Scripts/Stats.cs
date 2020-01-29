using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Stats 
{
    [SerializeField]//To be able to see it from the scene
    private BarScript bar;

    [SerializeField]//To be able to see it from the scene
    private float maxVal;

    [SerializeField]//To be able to see it from the scene
    private float currentVal;

    public float CurrentVal
    {
        get
        {
            return currentVal;
        }
        set
        {
            bar.Value = Mathf.Clamp(value,0,MaxVal);
            this.currentVal = value;
        }
    }

    public float MaxVal
    {
        get
        {
            return maxVal;
        }
        set
        {
            bar.MaxValue = value;
            this.maxVal = value;
        }
    }

    public void Initialize()
    {
        this.MaxVal = maxVal;
        this.CurrentVal = currentVal;
    }
}
