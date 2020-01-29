using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour
{

    private float fillAmount;

    [SerializeField]//To be able to see it from the scene
    private float lerpSpeed;

    [SerializeField]//To be able to see it from the scene
    private Image content;

    [SerializeField]//To be able to see it from the scene
    private Color fullColor;

    [SerializeField]//To be able to see it from the scene
    private Color lowColor;

    public float MaxValue
    {
        get;
        set;
    }

    public float Value
    {
        set
        {
            fillAmount = Map(value, 0, MaxValue, 0, 1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleBar();
    }

    private void HandleBar()
    {
        if (fillAmount != content.fillAmount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount, fillAmount, Time.deltaTime * lerpSpeed);
        }
        content.color = Color.Lerp(lowColor, fullColor, fillAmount);
    }

    private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }

}
