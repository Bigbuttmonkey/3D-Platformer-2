using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyrieIrving : MonoBehaviour
{

    public GameObject fireball;
    void Start(){

    }

      void Update(){
        if(Input.GetMouseButtonDown(0)){
        Instantiate(fireball, transform.position, transform.rotation);
        }
    }
}
