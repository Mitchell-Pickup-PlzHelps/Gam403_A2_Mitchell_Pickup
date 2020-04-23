using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce_Pad : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 dir = transform.up * bounceStrength;
            rb.AddForce(dir, ForceMode.Impulse);

        }
    }

}
