using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCollision : MonoBehaviour
{
    private LifeCount lifeCount;
    private AudioSource collisionSound;

    void Start()
    {
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
        lifeCount = GameObject.FindGameObjectWithTag("lifeCounter").GetComponent<LifeCount>();
        

    }
        void OnTriggerEnter2D(Collider2D colInfo)
    {
        if (colInfo.gameObject.tag.Equals("Enemy"))
        {
           
            lifeCount.LoseLife();
            collisionSound = GetComponent<AudioSource>();
            collisionSound.Play();



        }
   
    }
}
