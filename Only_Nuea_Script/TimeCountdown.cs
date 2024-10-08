using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCountdown : MonoBehaviour
{
    private bool c = false;
    public int SelectScene;

    //Time

    public float currentTime = 0f;
    public float startingTime = 10f;
    public Text countdownTime;

    //Wave

    public static float currentWave = 1;
    public Text WaveNum;
    public float timeBetweenWaves;
    public Text nextWaveInText;

    //enemies

    public Text enemiesLeftText;

    // Start is called before the first frame update
    void Start()
    {
        currentWave = 1;
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        StartWave();
        ShowingWave();

        if(currentTime <= 0)
        {
            NextWave();
            TimeUntilNextWave();
        }

        if(timeBetweenWaves <= 0)
        {
            StartWave();
            timeBetweenWaves = 5f;
            c = false;
        }

        if(currentWave == 4f)
        {
            SceneManager.LoadScene(SelectScene);
        }

        
    }



    public void ShowingWave()
    {
        WaveNum.text = "WAVE: " + currentWave.ToString();
    }

    public void NextWave()
    {
        StartCoroutine(ReturnWave());
    }

    public void StartWave()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownTime.text = "TIME LEFT : " + currentTime.ToString("0");

        if(currentTime <= 10f)
        {
            countdownTime.color = Color.red;
        }

        if(currentTime <= 0)
        {
            currentTime = 0;
        }

    }

    public void TimeUntilNextWave()
    {
        nextWaveInText.color = Color.green;
        timeBetweenWaves -= 1 * Time.deltaTime;
        nextWaveInText.text = "NEXT WAVE IN: " + timeBetweenWaves.ToString("0");

        if(timeBetweenWaves <= 0)
        {
            timeBetweenWaves = 0;
            currentTime = startingTime;
        }
    }

    IEnumerator ReturnWave()
    {
        if(c == false)
        {
            currentWave = ChangeWave(currentWave);
            c = true;
        }
        
        yield return new WaitForSeconds(timeBetweenWaves);

        //enemiesLeftText.text = "ENEMIES REMANING: ";
        WaveNum.text = "WAVE: " + currentWave.ToString();

        //yield break;
 
    }

    float ChangeWave(float changeWave)
    {
        return changeWave + 1;
    }

}
