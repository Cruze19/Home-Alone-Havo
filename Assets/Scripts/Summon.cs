using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour
{
 public GameObject Santa, block1;
    public Collider collision;
    public bool blocks;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Santa.SetActive(true);
            if(blocks == true)
            {
                block1.SetActive(true);
            }
            collision.enabled = false;
        }
    }
}