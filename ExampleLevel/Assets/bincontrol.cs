using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bincontrol : MonoBehaviour
{
    public Transform pizzaObj;
    public Transform pastaObj;
    public Transform marinarasauceObj;
    public Transform cheeseObj;
    public Transform plateObj;
    public Transform trayObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (gameObject.name == "platestackBin")
        {
            if (gameplay.servingBoardS1 == "empty")
            {
                Instantiate(plateObj, new Vector2(5, -2f), plateObj.rotation);
                gameplay.servingBoardS1 = "justPlate";
                gameplay.selectedSlot = 1;
            }

        }
    }
}
         
