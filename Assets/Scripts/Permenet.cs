using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Permenet : MonoBehaviour
{
    //This Script prevents objects from being destroyed when a scene is loaded
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);
        //this code makes it so that you cant have duplicates of an object with the same tag

        DontDestroyOnLoad(this.gameObject);
    }
    
}
