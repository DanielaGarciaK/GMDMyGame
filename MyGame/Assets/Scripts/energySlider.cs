using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energySlider : MonoBehaviour
{
    [SerializeField]
     Slider slider;
    [SerializeField]
     Gradient gradiant;
    [SerializeField]
     Image fill;
    
    public void SetMaxEnergy(float energy)
    {
        slider.maxValue = energy;
        slider.value = energy;

        fill.color = gradiant.Evaluate(1f);
    }
    public void SetEnergy(float energy)
    {
        slider.value = energy;
        fill.color = gradiant.Evaluate(slider.normalizedValue);
    }

    
}
