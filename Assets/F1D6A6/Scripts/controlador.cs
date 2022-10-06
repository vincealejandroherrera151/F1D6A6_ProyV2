using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class controlador : MonoBehaviour
{
    public GameObject[] objects;
    public int sigAPisar = 0;
    public bool regreso;
    // Start is called before the first frame update

    public IEnumerator iniciarJuego()
    {
        yield return new WaitForSeconds(1f);
        objects[0].GetComponent<objetosPisar>().subir();
        yield return new WaitForSeconds(.5f);
        objects[1].GetComponent<objetosPisar>().subir();
        sigAPisar = 0;
    }
    void Start()
    {
        StartCoroutine(iniciarJuego());
        Debug.Log("Se inicializo la corrutina: ");
    }
    // Update is called once per frame
    void Update()
    {
        /*if (sigAPisar<objects.Length)
        {
            if (objects[sigAPisar].GetComponent<objetosPisar>().mePisaron)
            {
                if (sigAPisar + 2 < objects.Length)
                {
                    objects[sigAPisar + 2].GetComponent<objetosPisar>().subir();
                }
                if (sigAPisar - 2 >= 0)
                {
                    objects[sigAPisar - 2].GetComponent<objetosPisar>().bajar();
                }
                sigAPisar += 1;
            }
        }*/
        if (regreso == false)
        {
            if (sigAPisar < objects.Length)
            {
                if (objects[sigAPisar].GetComponent<objetosPisar>().mePisaron)
                {
                    if (sigAPisar + 2 < objects.Length)
                    {
                        objects[sigAPisar + 2].GetComponent<objetosPisar>().subir();
                    }
                    if (sigAPisar - 2 >= 0)
                    {
                        objects[sigAPisar - 2].GetComponent<objetosPisar>().bajar();
                        objects[sigAPisar - 2].GetComponent<objetosPisar>().mePisaron=false;
                        //objects[sigAPisar - 1].GetComponent<objetosPisar>().mePisaron = false;
                    }
                    if (sigAPisar == objects.Length-1) {
                        regreso = true;
                        sigAPisar -= 1;
                    }

                    sigAPisar += 1;
                }
            }
        }
        else
        {
            if (regreso == true) {
                if (sigAPisar >= 0)
                {
                    if (objects[sigAPisar].GetComponent<objetosPisar>().mePisaron)
                    {
                        if (sigAPisar - 2 >= 0)
                        {
                            objects[sigAPisar - 2].GetComponent<objetosPisar>().subir();
                        }
                        if (sigAPisar + 2 < objects.Length)
                        {
                            objects[sigAPisar + 2].GetComponent<objetosPisar>().bajar();
                        }
                        sigAPisar -= 1;
                    }
                } 
            }
        }
    }
}
