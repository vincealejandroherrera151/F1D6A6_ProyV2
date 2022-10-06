using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Valve.VR.InteractionSystem;


namespace Valve.VR.InteractionSystem
{

    public class objetosPisar : MonoBehaviour
    {
        public Interactable inCube;
        public bool mePisaron;
        public Animator anim;
        public bool ambosPies;
        //public GameObject manoDer, manoIzq;

        public void subir()
        {
            anim.SetTrigger("subir");
        }

        public void bajar()
        {
            anim.SetTrigger("bajar");
        }


        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
            inCube = GetComponent<Interactable>();
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.blue);
            //controlador = GameObject.Find("objetosPisar").GetComponent<Controlador>();
        }

        private void Update()
        {
            if (inCube.isHovering)
            {
                Debug.Log(inCube.hoveringHand.handType);
                if (ambosPies) {
                    if (inCube.hoveringHands.ToArray().Length > 1)// == SteamVR_Input_Sources.LeftHand
                    {
                        mePisaron = true;
                    }
                }
                else
                {
                    mePisaron = true;
                }
                
                Debug.Log(transform.name);
            }
            else
            {
                mePisaron = false;
            }
        }
        /*private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.name);
        }*/
    }
}