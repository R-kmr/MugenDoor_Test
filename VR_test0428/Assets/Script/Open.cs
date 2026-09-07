using System;
using System.Collections;
using UnityEngine;

using UnityEngine.UI;

public class Open : MonoBehaviour
{
    //[SerializeField] GameObject Door; 
    public float OpenNum;  //Open判定の値
    public float MoveNum;　//扉スライドに移る値
    public float StopNum;  //扉　止まる位置

    Vector3 totte;

    public bool open = false;

    public float speed;
    int Opened;

   // BoxCollider col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("DoorMove");
        Opened= GenerateDoor.GetScore();
    }

    // Update is called once per frame
    void Update()
    {

        totte = transform.position;

        //if (Mathf.Abs(totte.x) <= Mathf.Abs(MoveNum))　//OPEN判定
        //{
        //    this.gameObject.GetComponent<BoxCollider>().enabled = false;　//取っ手の判定を削除

        //    StartCoroutine("DoorOut");
        //}


        if (Mathf.Abs(totte.x) > Mathf.Abs(OpenNum))
        {
            open = true;
        }

    }

    IEnumerator DoorMove()　   //奥から扉出現
    {
        while (transform.position.z > StopNum)
        {
            transform.Translate(0, 0, (speed- Opened*0.001f));
            yield return new WaitForSeconds(0.01f);
        }

        yield break;
    }

    IEnumerator DoorOut()　//とびら　横にスライドして消える
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
