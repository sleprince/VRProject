using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyFlossManager : MonoBehaviour
{
    private MeshRenderer floss;


    // Start is called before the first frame update
    void Start()
    {
        floss = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Make")
        {
            floss.enabled = true;
            Vector3 enlarge = new Vector3(0f, 0f, 0.2f);
            floss.transform.localScale += enlarge;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(this.name + " collided with " + other.name);

        if (other.tag == "Eat")
        {
            Vector3 shrink = new Vector3(0f, 0f, -1.0f);

            floss.transform.localScale -= shrink;

        }
    }


    private void OnCollisionStay(Collision collision)
    {

    }
}
