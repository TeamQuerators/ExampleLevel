using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour
{
    //public GameObject plate;
    public Transform plateObj;
    public Transform pastaObj;
    public Transform marinarasauceObj;
    public Transform cheeseObj;

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
                Instantiate(plateObj, new Vector2(0, 0), plateObj.rotation);
                
                gameplay.servingBoardS1 = "justplate";
                //gameplay.selectedSlot = 1;
            }
            else
                if (gameplay.servingBoardS2 == "empty")
            {
                Instantiate(plateObj, new Vector2(2, -2f), plateObj.rotation);
                
                gameplay.servingBoardS2 = "justplate";
                //gameplay.selectedSlot = 1;
            }
        }

        //PASTA
        if (gameObject.name == "spagstrainerBin")
        {
            if (gameplay.servingBoardS1 == "justplate")
            {
                Instantiate(pastaObj, new Vector2(0, 0), pastaObj.rotation);
                //Instantiate(pastaObj, new Vector2(2.75f, -1.15f), pastaObj.rotation);
                gameplay.servingBoardS1 = "pastaplate";
                //gameplay.selectedSlot = 1;
            }
            else
                if (gameplay.servingBoardS2 == "justplate")
            {
                Instantiate(pastaObj, new Vector2(2.75f, -2.15f), pastaObj.rotation);
                //Instantiate(pastaObj, new Vector2(2.75f, -1.15f), pastaObj.rotation);
                gameplay.servingBoardS2 = "pastaplate";
                //gameplay.selectedSlot = 1;
            }
        }



        /* if (gameObject.name == "platestackBin")
        {
            if (gameplay.servingBoardS1 == "empty")
            {
                GameObject newplate = Instantiate(plate, new Vector2(0,0) , transform.rotation) as GameObject;
                newplate.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);

                gameplay.servingBoardS1 = "justplate";
                //gameplay.selectedSlot = 1;
            }
            else
                if (gameplay.servingBoardS2 == "empty")
            {
                GameObject newplate = Instantiate(plate, new Vector2(0, -1), transform.rotation) as GameObject;
                newplate.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);

                gameplay.servingBoardS2 = "justplate";
                //gameplay.selectedSlot = 1;
            }
        } */
    }
}
