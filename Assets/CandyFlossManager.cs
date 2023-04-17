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
        floss.enabled = true;

        Vector3 enlarge = new Vector3(0f, 0f, 0.2f);

        floss.transform.localScale += enlarge * Time.deltaTime;

    }
    private void OnCollisionStay(Collision collision)
    {

    }
}
