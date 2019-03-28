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
        if (gameObject.name == "trayBin")
        {
            if (gameplay.servingBoardS1 == "empty")
            {
                Instantiate(trayObj, new Vector2(-1, -1f), trayObj.rotation);
                Instantiate(pastaObj, new Vector2(-1, -1.25f), pastaObj.rotation);
                gameplay.servingBoardS1 = "justPasta";
                gameplay.selectedSlot = 1;
            }

        }
    }
}
         
