using UnityEngine;
using TMPro;

public class GenerateDoor : MonoBehaviour
{
    public GameObject Door;
    public  GameObject NewDoor;

    int doorRnd;

    [SerializeField] GameObject RightSlide;
    [SerializeField] GameObject LeftSlide;

    int Opened = 0;


    [SerializeField] TextMeshProUGUI Text;

    public bool openCheck;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Door = GameObject.FindWithTag("Door");
    }

    // Update is called once per frame
    void Update()
    {
        Door = GameObject.FindWithTag("Door");

        if (Door.GetComponent<Open>().open)
        {
            doorRnd = Random.Range(1, 3);

            switch (doorRnd)
            {
                case 1:
                    NewDoor = RightSlide; break;

                case 2:
                    NewDoor = LeftSlide; break;
            }


            Instantiate(NewDoor);
            Destroy(Door);

            
            Opened++;
            string opened = Opened.ToString();
            Text.text = opened;

            openCheck = false;
        }
    }
}
