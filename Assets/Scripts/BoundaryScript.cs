using UnityEngine;
using System.Collections;

public class BoundaryScript : MonoBehaviour
{   
    //when an object exits the boundary they are destroyed
    void OnTriggerExit2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}