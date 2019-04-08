using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public static string deleteFood = "n";
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseOver()
    {
        if ((deleteFood == "y"))
        {
            Destroy(gameObject);
            deleteFood = "n";

        }
    }
}
