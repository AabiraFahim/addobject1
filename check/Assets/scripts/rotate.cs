using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up, -10);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up, 10);
        }
    }

    public void rotateobject()
    {
        
        if (Input.GetMouseButton(0)|| Input.GetMouseButton(1)||Input.GetMouseButton(2))
        {
            RaycastHit raycastHit;
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.transform.name=="Bed_Prefab(Clone)")
                {
                    
                        transform.Rotate(0.0f, 45f, 0.0f, Space.World);
                    
                }
            }
        }
    }

}
    

