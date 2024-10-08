using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TowerHP_Bar : MonoBehaviour
{
    public Slider slider;
    public Slider P_slider;
    public GameObject Player_;
    public GameObject Tower_;
    public Gradient gradient;
    public Image fill;
    public Text T_hp_text;
    public Text P_hp_text;
    public int DiedScene = 2;
    public static float wave = TimeCountdown.currentWave;

//---------------------Tower-----------------------

    public void SetMaxTowerHP(int T_hp)
    {
        slider.maxValue = T_hp;
        slider.value = T_hp;

        fill.color = gradient.Evaluate(1f);
        T_hp_text.text = slider.maxValue.ToString() + " / "  + slider.maxValue.ToString();
    }

    public void SetTowerHP(int T_hp)
    {
        slider.value = T_hp;

        fill.color = gradient.Evaluate(slider.normalizedValue);     //normalizedValue
        T_hp_text.text = slider.value.ToString() + " / "  + slider.maxValue.ToString();
    }

    public void ShowTowerHP()
    {
        fill.color = gradient.Evaluate(slider.normalizedValue);     //normalizedValue
        T_hp_text.text = slider.value.ToString() + " / "  + slider.maxValue.ToString();
    }


//---------------------Player-----------------------

    public void SetMaxPlayerHP(int P_hp)
    {
        P_slider.maxValue = P_hp;
        P_slider.value = P_hp;

        fill.color = gradient.Evaluate(1f);
        P_hp_text.text = P_slider.maxValue.ToString() + " / "  + P_slider.maxValue.ToString();
    }

    public void SetPlayerHP(int T_hp)
    {
        P_slider.value = T_hp;

        fill.color = gradient.Evaluate(P_slider.normalizedValue);     //normalizedValue
        P_hp_text.text = P_slider.value.ToString() + " / "  + P_slider.maxValue.ToString();
    }

    public void ShowPlayerHP()
    {
        fill.color = gradient.Evaluate(P_slider.normalizedValue);     //normalizedValue
        P_hp_text.text = P_slider.value.ToString() + " / "  + P_slider.maxValue.ToString();
    }

//--------------------------------------------------

    void Start()
    {
        Player_.SetActive(false);
        Tower_.SetActive(true);

        P_slider.maxValue = 100;
    }

    void Update()
    {
        if(slider.value <= 0)
        {
            SceneManager.LoadScene(DiedScene);
        }

        if(TimeCountdown.currentWave == 3f)
        {
            Debug.Log("K");
            Player_.SetActive(true);
            Tower_.SetActive(false);
            ShowPlayerHP();
            
            if(P_slider.value <= 0)
            {
                SceneManager.LoadScene(DiedScene);
            }
        }

        ShowTowerHP();
        ShowPlayerHP();
    }
}
