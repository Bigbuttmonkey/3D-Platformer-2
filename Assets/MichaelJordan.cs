using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichaelJordan : MonoBehaviour
{
    public int jumpStrength = 1;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpStrength;
    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpStrength;

    }
}
