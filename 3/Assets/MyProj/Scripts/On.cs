using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube2;
    public GameObject cubeDestroy;
    public GameObject cubeDestroy2;
    private MeshRenderer mR;
    private MeshRenderer myR;
    private BoxCollider mB;
    private BoxCollider myB;

    private void Start()
    {
        mR = cube2.GetComponent<MeshRenderer>();
        myR = cube.GetComponent<MeshRenderer>();
        mB = cube2.GetComponent<BoxCollider>();
        myB = cube.GetComponent<BoxCollider>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            mR.enabled = true;
            myR.enabled = true;
            mB.enabled = true;
            myB.enabled = true;
            Destroy(cubeDestroy);
            Destroy(cubeDestroy2);
        }
    }
    
}
