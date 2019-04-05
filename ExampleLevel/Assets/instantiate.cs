using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour
{
    public GameObject plate;
    public Transform plateObj;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject newplate = Instantiate(plate, transform.position, transform.rotation) as GameObject;
        //newplate.transform.SetParent(GameObject.FindGameObjectWithTag("plate").transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (gameObject.name == "platestackBin")
        {
            if (gameplay.servingBoardS1 == "empty")
            {
                GameObject newplate = Instantiate(plate, new Vector2(0,0) , transform.rotation) as GameObject;
                newplate.transform.SetParent(GameObject.FindGameObjectWithTag("plate").transform, false);

                gameplay.servingBoardS1 = "justplate";
                //gameplay.selectedSlot = 1;
            }
            else
                if (gameplay.servingBoardS2 == "empty")
            {
                GameObject newplate = Instantiate(plate, new Vector2(0, -1), transform.rotation) as GameObject;
                newplate.transform.SetParent(GameObject.FindGameObjectWithTag("plate").transform, false);

                gameplay.servingBoardS2 = "justplate";
                //gameplay.selectedSlot = 1;
            }
        }
    }
}
