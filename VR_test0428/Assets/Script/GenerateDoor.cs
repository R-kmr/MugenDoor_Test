using UnityEngine;

public class GenerateDoor : MonoBehaviour
{
    Open open;
    GameObject Door;
    GameObject NewDoor;

    [SerializeField] GameObject RightSlide;
    [SerializeField] GameObject LeftSlide;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        Door = GameObject.FindWithTag("Door");
        open = Door.GetComponent<Open>();


        int doorRnd = Random.Range(1, 3);

        switch (doorRnd)
        {
            case 1:
                NewDoor = RightSlide; break;

            case 2:
                NewDoor = LeftSlide; break;
        }

        if (open.open)
        {
           // Debug.Log("В®Б[В’Вс");
            Instantiate(NewDoor);
            //Door = NewDoor;
            //open.open = false;
        }
    }
}
