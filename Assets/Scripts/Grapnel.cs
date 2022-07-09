using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapnel : MonoBehaviour
{
    [SerializeField] List<PairOfPoints> paths;
    [SerializeField] Transform tip;
    int index;
    Transform target;
    [SerializeField] float speed = 1;
    public static Building building;

    private void Start()
    {
        Init();
    }

    void Init()
    {
        index = Random.Range(0, paths.Count);
        bool rand = (Random.value > .5f);
        switch (rand)
        {
            case true:
                tip.position = paths[index].A.position;
                target = paths[index].B;
                break;
            case false:
                tip.position = paths[index].B.position;
                target = paths[index].A;
                break;
        }
        
    }

    void SetBuildingPart()
    {
        Instantiate(building.mid, tip);
    }

    private void Update()
    {
        tip.position = Vector3.MoveTowards(tip.position, target.position, speed * Time.deltaTime);
        if(Vector3.Distance(tip.position, paths[index].B.position) < .02f) { target = paths[index].A; }
        else if(Vector3.Distance(tip.position, paths[index].A.position) < .02f) { target = paths[index].B; }

        if (Input.GetKeyDown(KeyCode.K)) { Init(); }
    }
}
[System.Serializable]
public class PairOfPoints
{
    public Transform A, B;
}