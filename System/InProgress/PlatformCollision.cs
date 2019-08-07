using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCollision : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.SetParent(this.gameObject.transform);
        //collision.rigidbody.useGravity = false;
    }

    private void OnCollisionExit(Collision collision)
    {
        collision.gameObject.transform.SetParent(null);
        //collision.rigidbody.useGravity = true;
    }
}
