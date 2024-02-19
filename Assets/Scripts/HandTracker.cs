using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTracker : MonoBehaviour
{

    public UDPReceive udpRecieve;

    public GameObject[] HandPoints;

    // Start is called before the first frame update
    void Start()
    {
        udpRecieve = GetComponent<UDPReceive>();   
    }

    // Update is called once per frame
    void Update()
    {

        string data = udpRecieve.data;

        if (data.Length > 0)
        {
            data = data.Remove(0, 1);
            data = data.Remove(data.Length - 1, 1);

            

            string[] points=data.Split(',');    

            for(int i=0;i<21;i++)
            {
                float x = 5-float.Parse(points[i*3])/100;
                float y = float.Parse(points[i * 3+1]) / 100;
                float z = float.Parse(points[i * 3 + 2]) / 100;

                HandPoints[i].transform.localPosition = new Vector3(x, y, z);
            }
        }





    }
}
