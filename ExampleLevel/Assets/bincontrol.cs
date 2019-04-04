using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bincontrol : MonoBehaviour
{
    public Transform platetopObj;
    public Transform platebottomObj;
    public Transform pizzaObj;
    public Transform pastaObj;
    public Transform marinarasauceObj;
    public Transform cheeseObj;
    public Transform trayObj;

    /* Instantiate variables
     * justplate = plate  
     * pastaplate = plate + pasta 
     * pastasauce = plate + pasta + sauce 
     * pasta cheese = plate+ pasta + sauce + cheese
     */


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
        //INSTANTIATE VARIABLES
        
        //PLATE
        
        if (gameObject.name == "platestackBin")
        {
            if (gameplay.servingBoardS1 == "empty")
            {
                Instantiate(platetopObj, new Vector2(2.75f, -0.75f), platetopObj.rotation);
                Instantiate(platebottomObj, new Vector2(2.75f, -0.75f), platebottomObj.rotation);
                gameplay.servingBoardS1 = "justplate";
                //gameplay.selectedSlot = 1;
            }
            else 
                if (gameplay.servingBoardS2 == "empty")
                {
                    Instantiate(platetopObj, new Vector2(2.75f, -1.75f), platetopObj.rotation);
                    Instantiate(platebottomObj, new Vector2(2.75f, -1.75f), platebottomObj.rotation);
                    gameplay.servingBoardS2 = "justplate";
                    //gameplay.selectedSlot = 1;
                }
        }
       


        //PASTA
        if (gameObject.name == "spagstrainerBin")
        {
            if (gameplay.servingBoardS1 == "justplate")
            {
                Instantiate(pastaObj, new Vector2(2.75f, -1.15f), pastaObj.rotation);
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

        //Marinara Sauce
        
        if (gameObject.name == "sauceBin")
        {
            if (gameplay.servingBoardS1 == "pastaplate")
            {
                Instantiate(marinarasauceObj, new Vector2(2.75f, -0.81f), marinarasauceObj.rotation);
                gameplay.servingBoardS1 = "pastasauce";
                //gameplay.selectedSlot = 1;
            }
            else
                if (gameplay.servingBoardS2 == "pastaplate")
            {
                Instantiate(marinarasauceObj, new Vector2(2.75f, -1.81f), marinarasauceObj.rotation);
                gameplay.servingBoardS2 = "pastasauce";
                //gameplay.selectedSlot = 1;
            }
        }

        //Cheese
        if (gameObject.name == "cheesebowlBin")
        {
            if (gameplay.servingBoardS1 == "pastasauce")
            {
                Instantiate(cheeseObj, new Vector2(2.75f, -0.8f), cheeseObj.rotation);
                Instantiate(cheeseObj, new Vector2(2.75f, -0.8f), cheeseObj.rotation);
                gameplay.servingBoardS1 = "pastacheese";
                //gameplay.selectedSlot = 1;
            }
            else
                if (gameplay.servingBoardS2 == "pastasauce")
            {
                Instantiate(cheeseObj, new Vector2(2.75f, -1.8f), cheeseObj.rotation);
                Instantiate(cheeseObj, new Vector2(2.75f, -0.8f), cheeseObj.rotation);
                gameplay.servingBoardS2 = "pastacheese";
                //gameplay.selectedSlot = 1;
            }
        }


    }

}
         
