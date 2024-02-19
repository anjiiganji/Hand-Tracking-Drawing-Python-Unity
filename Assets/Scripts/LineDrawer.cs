using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    public Transform indexTip;
    public GameObject LineObject; 

    bool spacePressed = false;
    GameObject line;
    List<GameObject> allLines;

    private void Start()
    {
        allLines = new List<GameObject>();  
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            
            if (spacePressed)
            {
                 line= Instantiate(LineObject, indexTip.position, indexTip.rotation);
                line.GetComponent<LineRenderer>().positionCount = 0;
                line.GetComponent<LineRenderer>().SetPosition(0, indexTip.position);
                allLines.Add(line);
                spacePressed = false;
            }

                if (indexTip == null)
            {
                return;
            }
          
            line.GetComponent<LineRenderer>().positionCount++;
            line.GetComponent<LineRenderer>().SetPosition(line.GetComponent<LineRenderer>().positionCount - 1, indexTip.position);

           
        }
        else if (!Input.GetKey(KeyCode.Space)) 
        {
            spacePressed = true;
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            EraseAllLines();
        }
    }

    void EraseAllLines()
    {
        foreach(var item in allLines)
        {
            Destroy(item.gameObject);
        }
    }
}
