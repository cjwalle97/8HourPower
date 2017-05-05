using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingBehaviour : MonoBehaviour {

    void Load()
    {
        SceneManager.LoadScene(0);
    }

    void OnTriggerEnter(Collider other)
    {
        CompareTag("Player");
        Load();
    }

	
}
