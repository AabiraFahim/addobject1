using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstantiateManager : MonoBehaviour
{
    public GameObject Prefab;
    private Vector3 screenPoint;
    private Vector3 offset;
    int i;


    // Update is called once per frame
    void Update()
    {

    }
    public void createobject()
    {
        Instantiate(Prefab, new Vector3(i * 5f, 0f, 0f), Quaternion.Euler(0f, i * 50f, 0f));
        i++;
        
    }
    public void rotateobject()
    {
        GameObject.Find("Bed_Prefab(Clone)").transform.Rotate(0.0f, -45f, 0.0f, Space.World);
    }

    public void cancelobject()
    {
        Destroy(gameObject);
    }
    
    
}
