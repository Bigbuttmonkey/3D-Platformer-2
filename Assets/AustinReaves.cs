using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AustinReaves : MonoBehaviour
{
   
public float speed = 2;

private void Start() {


    Destroy(gameObject, 5);
}

void Update(){
    transform.Translate(0,0, speed * Time.deltaTime);
}


}
