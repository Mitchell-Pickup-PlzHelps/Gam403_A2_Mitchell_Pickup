using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    public string Level;

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(Level);
        }
    }
}
