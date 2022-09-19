using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    [SerializeField] GameObject[] playermodeller;

    Animator anim;
    void Start()
    {
        for (int i = 0; i < playermodeller.Length; i++)
        {
            if(playermodeller[i].activeSelf){
                anim =playermodeller[i].GetComponent<Animator>();
            }
        }
        
    }

    void Update()
    {
        anims();
    }

    void anims(){
        if(Input.GetAxis("Vertical")> 0 || Input.GetAxis("Horizontal")> 0 || Input.GetAxis("Vertical")< 0 ||Input.GetAxis("Horizontal")< 0 ){
            anim.CrossFade("Walk",0,0);
        }
        else{
            anim.CrossFade("Silly Dancing",0,0);
        }
    }
}
