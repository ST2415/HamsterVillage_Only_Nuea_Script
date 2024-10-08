using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enermy_Remaining : MonoBehaviour
{
    [SerializeField] Text enermyLeftText;
    int enermyLeft;

    // Start is called before the first frame update
    void Start()
    {
        enermyLeft = 20;
    }

    // Update is called once per frame
    void Update()
    {
        ShowingEnermies();
    }

    public void ShowingEnermies()
    {
        enermyLeftText.text = "ENERMY LEFT: " + enermyLeft.ToString();
    }
}
