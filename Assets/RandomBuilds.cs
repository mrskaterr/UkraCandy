using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBuilds : MonoBehaviour
{
    int rnd;
    [SerializeField] List<GameObject> Builds;
    public static GameObject NextBuilding;
    public List<int> queue;
    GameObject buff;
    void Start()
    {
        for(int i=transform.childCount-1;i>=0;i--)
        {
            rnd=Random.Range(0,Builds.Count);
            buff=Instantiate(Builds[rnd]);
            queue.Add(rnd);
            buff.transform.SetParent(transform.GetChild(i));
            buff.transform.localPosition = new Vector3(0, 0, 0);
        }
        NextBuilding=Builds[queue[0]];
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
        NextBuilding=Builds[queue[0]];
        queue.RemoveAt(0);
        Destroy(transform.GetChild(transform.childCount-1).GetChild(0).gameObject);
        for(int i=transform.childCount-1;i>=1;i--)
        {
            buff=transform.GetChild(i-1).GetChild(0).gameObject;
            buff.transform.SetParent(transform.GetChild(i));
            buff.transform.localPosition = new Vector3(0, 0, 0);            
        }
        rnd=Random.Range(0,Builds.Count);
        buff=Instantiate(Builds[rnd]);
        queue.Add(rnd);
        buff.transform.SetParent(transform.GetChild(0));
        buff.transform.localPosition = new Vector3(0, 0, 0);            
        
    }

    
    
}