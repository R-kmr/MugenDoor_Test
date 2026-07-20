using System;
using System.Collections;
using UnityEngine;

using UnityEngine.UI;

public class Open : MonoBehaviour
{
    //[SerializeField] GameObject Door; 
    public float OpenNum;
    public float MoveNum;

    Vector3 totte;

    public bool open = false;

    public float speed;


   // BoxCollider col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("DoorMove");
    }

    // Update is called once per frame
    void Update()
    {

        totte = transform.position;

        if (Mathf.Abs(totte.x) >= Mathf.Abs(MoveNum))
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;

            StartCoroutine("DoorOut");
        }


        if (Mathf.Abs(totte.x) > Mathf.Abs(OpenNum))
        {
            open = true;
           // this.gameObject.tag = ("Open");
        }

    }

    IEnumerator DoorMove()
    {
        while (transform.position.z > 0.2f)
        {
            transform.Translate(0, 0, speed);
            yield return new WaitForSeconds(0.01f);
        }

        yield break;
    }

    IEnumerator DoorOut()
    {
        if (OpenNum > 0)
        {
            while (transform.position.x <= OpenNum)
            {
                Debug.Log("デストロイ");

                transform.Translate((-speed * (float)0.05), 0, 0);
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            while (transform.position.x >= OpenNum)
            {
                Debug.Log("デストロイ");

                transform.Translate((speed * (float)0.05), 0, 0);
                yield return new WaitForSeconds(0.01f);
            }
        }

        yield break;
    }

}
