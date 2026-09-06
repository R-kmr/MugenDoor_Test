using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SocialPlatforms.Impl;

public class GenerateDoor : MonoBehaviour
{
    public GameObject Door;
    public  GameObject NewDoor;

    int doorRnd;

    [SerializeField] GameObject RightSlide;
    [SerializeField] GameObject LeftSlide;

    protected static int Opened = 0;　　//とびら　開けた数


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


    public static int GetScore()
    {
        return Opened;
    }
}
