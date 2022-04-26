using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 5;

    public Material material;

    void Awake()
    {
        for (int i = 0; i < length; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = transform.position - transform.forward * i;
            sphere.transform.parent = transform;
            sphere.GetComponent<Renderer>().material = material;

            if (i == 0)
            {
                sphere.AddComponent(typeof(NoiseWander)); 
                sphere.AddComponent(typeof(Constrain));
                sphere.AddComponent(typeof(ObstacleAvoidance));      
            }
            
        }
        
        for (int i = 0; i < length; i++)
        {
            transform.GetChild(i).GetComponent<Renderer>().material.color = Color.HSVToRGB(i / (float)length, 1, 1);
        }

        
    }

    void Update()
    {
        for (int i = 0; i < length; i++)
        {
            transform.GetChild(i).Rotate(0, 0, 0.5f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
