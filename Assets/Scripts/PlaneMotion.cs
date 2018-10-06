using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMotion : MonoBehaviour
{

    public float motionSpeed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        this.transform.Translate(Vector3.forward);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * motionSpeed);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * motionSpeed);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up * motionSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down * motionSpeed);
        }


        //Spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Barra Espaciadora presionada");

            //Creamos un GameObject a partir de un prefab (planos a partir de un edificio)
            GameObject newMissile = GameObject.Instantiate(Resources.Load("Bullets/Missile 2") as GameObject);

            // Buscamos el GameObject del pivote de disparo (ShootPivot)
            GameObject shootPivot = GameObject.Find("CombatPlane/ShootPivot");

            //Hago el misil hijo de ShootPivot
            newMissile.transform.SetParent(shootPivot.transform);

            //Movemos el misil a la posición del pivote de disparo
            newMissile.transform.localPosition = Vector3.zero;

            //Sacar el misil del pivote para que no se mueva con el avión
            newMissile.transform.SetParent(null);

        }
    }
}