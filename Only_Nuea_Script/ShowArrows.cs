using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowArrows : MonoBehaviour
{
    [SerializeField] Text arrowsText;
    int arrowsMax = 30;
    int arrowsMin = 0;
    int arrowsLeft = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowingArrows();
    }

    public void ShowingArrows()
    {
        arrowsText.text = "ARROWS: " + arrowsLeft.ToString() + "/ " + arrowsMax.ToString();
    }
}
