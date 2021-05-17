using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinPicker : MonoBehaviour
{
    private float coin = 0;
    public TextMeshProUGUI textCoin;
    TimerScript timer;
    

    private void Update()
    {

        if (coin > 99)
        {
            FindObjectOfType<TimerScript>().stopTimer();
            FindObjectOfType<gameManager>().Winner();

        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag== "Coin")
        {
            coin++;
            textCoin.text = coin.ToString();
            Destroy(other.gameObject);
            


        }
        
    }

}
