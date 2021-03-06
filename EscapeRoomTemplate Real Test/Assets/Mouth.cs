using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        //detect meat gameObject
        //once meat touches lion it disappears
        //make lion disappear
        if (other.gameObject.CompareTag("Meat")){
            Destroy(other.gameObject);
        }
    }
}
