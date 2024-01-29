using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAssets : MonoBehaviour
{
    public static UIAssets Instance;

    [SerializeField]
    Slider speedSlider;

    [SerializeField]
    Slider timerSlider;

    private void Awake()
    {
        Instance = this;
    }

    public float GetTimeToSpawn()
    {
        return timerSlider.value;
    }

    public float GetSpeedSlider()
    {
        return speedSlider.value;
    }
}
