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
    [SerializeField] GameObject RightPull;
    [SerializeField] GameObject LeftPull;

    protected static int Opened = 0;　　//とびら　開けた数


    [SerializeField] TextMeshProUGUI Text;


    public float OpenNum;  //Open判定の値
    public float MoveNum;　//扉スライドに移る値
    public float StopNum;  //扉　止まる位置
    public float speed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Door = GameObject.FindWithTag("DoubleDoor");
        StartCoroutine("DoorMove");
    }

    // Update is called once per frame
    void Update()
    {
        Door = GameObject.FindWithTag("Door");

        if (Door.GetComponent<Open>().open)
        {
            doorRnd = Random.Range(1, 5);

            switch (doorRnd)
            {
                case 1:
                    NewDoor = RightSlide; break;

                case 2:
                    NewDoor = LeftSlide; break;

                case 3:
                    NewDoor = RightPull ;  break;

                case 4:
                    NewDoor = LeftPull; break;
            }

            Instantiate(NewDoor);
            Destroy(Door);

            Opened++;
            string opened = Opened.ToString();
            Text.text = opened;
        }

        StartCoroutine("DoorMove");

    }

    public IEnumerator DoorMove()　   //奥から扉出現
    {
        while (Door.transform.position.z > StopNum)
        {
            Door.transform.Translate(0, 0, (speed - Opened * 0.0001f));
            yield return new WaitForSeconds(0.01f);
        }

        yield break;
    }

    public static int GetScore()
    {
        return Opened;
    }
}
