using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    public GameObject prefab;

    [Range (1, 5000)]
    public int radius = 50;
    
    public int count = 10;

    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < count; i++)
        {
            GameObject nematode = Instantiate(prefab);
            nematode.transform.parent = transform;
            nematode.transform.localPosition = new Vector3(Random.Range(-radius, radius), Random.Range(-radius, radius), Random.Range(-radius, radius));
        }

        for (int i = 0; i < count; i++)
        {
            Transform current = transform.GetChild(i);
            current.transform.localRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
