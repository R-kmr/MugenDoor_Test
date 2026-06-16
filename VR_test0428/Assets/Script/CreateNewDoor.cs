using UnityEngine;

public class CreateNewDoor : MonoBehaviour
{
    Open open;
    GameObject Door;

    [SerializeField] GameObject RightSlide;
    [SerializeField] GameObject LeftSlide;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        open = GetComponent<Open>();

        int doorRnd = Random.Range(1, 3);

        switch (doorRnd)
        {
            case 1:
                Door = RightSlide; break;

            case 2:
                Door = LeftSlide; break;
        }

    }

    // Update is called once per frame
    void Update()
    {        

        Debug.Log(Door);

        if(open.open)
        {
            Debug.Log("В®Б[В’Вс");
            Instantiate(Door);
            open.open = false;
        }
    }
}
