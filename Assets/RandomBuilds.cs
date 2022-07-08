using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBuilds : MonoBehaviour
{
    int rnd;
    [SerializeField]  List<Material> material;
    void Start()
    {
        for(int i=0;i<transform.childCount;i++)
        {
            rnd=Random.Range(0,4);
            transform.GetChild(i).GetComponent<MeshRenderer>().material=material[rnd];
            Debug.Log(material[rnd]);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            deleteAndRandom();
        }
    }
    void deleteAndRandom()
    {
        
        for(int i=transform.childCount-1;i>=1;i--)
        {
            transform.GetChild(i).GetComponent<MeshRenderer>().material= transform.GetChild(i-1).GetComponent<MeshRenderer>().material;
        }
        transform.GetChild(0).GetComponent<MeshRenderer>().material=material[Random.Range(0,4)];
    }

    
    
}