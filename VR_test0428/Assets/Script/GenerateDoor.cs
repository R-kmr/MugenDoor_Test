using UnityEngine;
using TMPro;
using System.Collections;

public class GenerateDoor : MonoBehaviour
{
    public GameObject Door;
    GameObject OldDoor;
    public  GameObject NewDoor;

    int doorRnd;

    [SerializeField] GameObject RightSlide;
    [SerializeField] GameObject LeftSlide;

    int Opened = 0;


    [SerializeField] TextMeshProUGUI Text;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Door = GameObject.FindWithTag("Door");
       // OldDoor = GameObject.FindWithTag("Open");

        if (Door.GetComponent<Open>().open)
        {
            Debug.Log("おーーーーーぷん");
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
        }
    }

  
}
