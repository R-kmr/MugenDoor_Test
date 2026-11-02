using System.Reflection;
using UnityEngine;

public class ChildObject : MonoBehaviour
{
    [SerializeField] GameObject Door;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.transform.parent = Door.transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (Door.GetComponent<Open>().stop)
        {
            this.gameObject.transform.parent = null;
        }
    }
}
