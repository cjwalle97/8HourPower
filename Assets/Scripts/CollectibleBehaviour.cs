using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBehaviour : MonoBehaviour {
    public GameObject Collectible;
    public int amount;

    void OnTriggerEnter(Collider other)
    {
        CompareTag("Player");
        DestroyObject(Collectible);
    }
}
