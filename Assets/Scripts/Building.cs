using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    [Header("Storey")]
    public GameObject top;
    public GameObject mid;
    public GameObject ground;

    private void Start()
    {
        Grapnel.building = this;
    }
}