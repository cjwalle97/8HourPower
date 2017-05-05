﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBehaviour : MonoBehaviour {
    public GameObject Collectible;
    void OnTriggerEnter(Collider other)
    {
        CompareTag("Player");
        DestroyObject(Collectible);
    }
}
