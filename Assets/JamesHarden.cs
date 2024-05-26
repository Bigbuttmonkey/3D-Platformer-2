using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JamesHarden : MonoBehaviour
{
    
private void OnTriggerEnter(Collider other) {
    if (other.transform.tag == "Player"){
    SceneManager.LoadScene(0);

}
}
}
