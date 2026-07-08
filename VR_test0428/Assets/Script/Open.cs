using System.Collections;
using UnityEngine;

public class Open : MonoBehaviour
{
    //[SerializeField] GameObject Door; 
    public float OpenNum;
    Vector3 totte;

    public bool open = false;

    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("DoorMove");
    }

    // Update is called once per frame
    void Update()
    {

        totte = transform.position;

        if(Mathf.Abs(totte.x) >= Mathf.Abs(OpenNum))
        {
            open = true;
        }

        if (open)
        {
           // Destroy(this.gameObject);
            Debug.Log("デストロイ");
        }
    }

    IEnumerator DoorMove()
    {
        while (transform.position.z > 0.2f)
        {
            Debug.Log("移動");
           // pos = transform.position;
            transform.Translate(0, 0, speed);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
