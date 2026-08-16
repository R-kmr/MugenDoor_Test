using OVR.OpenVR;
using UnityEngine;
using TMPro;


public class ScoreScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Text;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int score = GenerateDoor.GetScore();

        string opened = score.ToString();
        Text.text = opened;
    }
}
