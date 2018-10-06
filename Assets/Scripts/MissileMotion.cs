using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMotion : MonoBehaviour
{

    public float motionSpeed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        this.transform.Translate(Vector3.forward * motionSpeed);

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión entre dos colliders");

        //Destrucción del GameObject
        GameObject.Destroy(this.gameObject);

        //Destrucción del enemigo
        GameObject.Destroy(collision.collider.gameObject);
    }
}
