using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StephCurry : MonoBehaviour
{

public Transform destination;

private void OnCollisionEnter(Collision other) {
    other.transform.position = destination.position;
}

}

