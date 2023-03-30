using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotPointScript : MonoBehaviour
{
    public Transform pivotPoint;

    public float maxY = 20f;
    public float minY = -20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.E))
        {
            rotateleft();
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rotateright();
        }
       
    }
    void rotateleft()
    {
        pivotPoint.transform.Rotate(-50f * Time.deltaTime, 0, 0);
    }

    void rotateright()
    {
        pivotPoint.transform.Rotate(50 * Time.deltaTime, 0, 0);
    }



}
