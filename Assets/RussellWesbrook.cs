using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RussellWesbrook : MonoBehaviour
{

public GameObject player;
public float speed=1f;

void Update(){
    transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    transform.LookAt(player.transform.position);
}

    private void OnTriggerEnter(Collider other) {
        if (other.transform.tag == "Bombaclot")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

}

