using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCount : MonoBehaviour
{
    public float maxEnergy = 100;
    public float currentEnergy;
    public energySlider energySlider;

    // Start is called before the first frame update
    void Start()
    {
        currentEnergy = maxEnergy;
        energySlider.SetMaxEnergy(maxEnergy);
        InvokeRepeating("energyDown", 3.0f,1f);
        
    }

 
    void energyDown()
    {
        TakeDamage(4f);
//        Debug.Log(currentEnergy);
    }
    void TakeDamage(float damage)
    {
        currentEnergy -= damage;
        energySlider.SetEnergy(currentEnergy);
        if (currentEnergy <= 0)
        {
            FindObjectOfType<gameManager>().Gameover();
        }
    }

    public void refillEnergy(float refill)
    {
        
              currentEnergy += refill;
            energySlider.SetEnergy(currentEnergy);
        if (currentEnergy > 100) currentEnergy = 100;
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Energy")
        {
            refillEnergy(2f);
            Destroy(other.gameObject);

        }


    }
}