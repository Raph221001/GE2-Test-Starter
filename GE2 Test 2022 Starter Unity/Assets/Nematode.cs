using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 5;

    public Material material;

    void Awake()
    {
        //Create a nematode with sphere
        for (int i = 0; i < length; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.parent = transform;
            sphere.transform.localPosition = new Vector3(0, i, 0);
            sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            sphere.GetComponent<Renderer>().material = material;
        }

           

        //Set the segments to be parented to the nematode gameObject
        for (int i = 0; i < length; i++)
        {
            transform.GetChild(i).parent = transform;
        }	
       
        //Colour the segments
        for (int i = 0; i < length; i++)
        {
            transform.GetChild(i).GetComponent<Renderer>().material.color = Color.HSVToRGB(i / (float)length, 1, 1);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
