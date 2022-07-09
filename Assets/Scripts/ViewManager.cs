using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    [SerializeField] GameObject camIzo;
    [SerializeField] GameObject camTop;

    static GameObject izo;
    static GameObject top;

    private void Start()
    {
        izo = camIzo;
        top = camTop;
    }

    private void Update()
    {
        Test();
    }

    public static void SetViewToIzo()
    {
        izo.SetActive(true);
        top.SetActive(false);
    }

    public static void SetViewToTop(Transform point)
    {
        top.SetActive(true);
        izo.SetActive(false);

        top.transform.position = new Vector3(point.position.x, top.transform.position.y, point.position.z);
    }

    void Test()
    {
        if (Input.GetMouseButtonDown(1)) { SetViewToIzo(); }
    }
}