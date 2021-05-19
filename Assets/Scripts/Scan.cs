using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scan : MonoBehaviour
{
    // Start is called before the first frame update
    BoxCollider Col;
    public bool Closed;
    public GameObject In_Zone = null;
    void Start()
    {
        Col = transform.GetComponent<BoxCollider>();
    }
    public void Activated()
    {
        Destroy(In_Zone, 0.1f);
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.GetComponent<Pattern_Entry>().gameObject)
        {
            Closed = true;
            In_Zone = collision.gameObject;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        Closed = false;
        In_Zone = null;
    }
}
