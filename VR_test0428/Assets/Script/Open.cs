using UnityEngine;

public class Open : MonoBehaviour
{
    //[SerializeField] GameObject Door; 
    public float OpenNum;
    Vector3 totte;

    public bool open = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //name = gameObject.name;
        //open = false;
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
}
