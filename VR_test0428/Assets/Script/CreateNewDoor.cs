using UnityEngine;

public class CreateNewDoor : MonoBehaviour
{
    Open open;

    [SerializeField] GameObject Door;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        open = GetComponent<Open>();
    }

    // Update is called once per frame
    void Update()
    {
        if(open.open)
        {
            Debug.Log("В®Б[В’Вс");
            Instantiate(Door);
            open.open = false;
        }
    }
}
