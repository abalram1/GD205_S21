using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float explosionForce = 50f;
    int howManyThingsHit = 0;
    //Rigidbody rb;
    public GameObject spawnItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit = new RaycastHit();
        
           if (Physics.Raycast(laser, out hit, 10000f))
           {
            Debug.Log("You hit" + hit.transform.gameObject.name);
            //hit.transform.localScale += new Vector3(1f, 1f, 1f);
                
                if (Input.GetMouseButtonDown(1))
                {
                Instantiate(spawnItem, hit.point, Quaternion.identity);
                }
                
                if (hit.rigidbody && hit.transform != transform && Input.GetMouseButton(0))
                {
                Debug.Log("PEWPEWPEW");
                hit.rigidbody.AddExplosionForce(explosionForce, hit.point, 10f, 5f);
                
                howManyThingsHit++;
                Debug.Log("You hit" + " " + howManyThingsHit + " " + "things");
                
                hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.red;
                //Destroy(hit.transform.gameObject);    
            }
        }
    }
}
