using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject sett;
    public GameObject refr;
    public GameObject eye;
    public GameObject info;
    public GameObject whichGal;
    public GameObject infoscr;
    public Animator transAnim;
    public GameObject bgsound;
    public AudioSource hover;
    public AudioSource tele;

    public Image milkyw;
    public Image androm;

    public Sprite mwf;
    public Sprite mwb;
    public Sprite amf;
    public Sprite amb;

    // Start is called before the first frame update
    void Start()
    {
        whichGal.SetActive(false);
        infoscr.SetActive(false);
    }

    public void Awake()
    {
        if (bgsound != null)
        {
            DontDestroyOnLoad(bgsound);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(whichGal);
    }

    public void ShowMenu()
    {
        whichGal.SetActive(!(whichGal.activeSelf));
        if(infoscr.activeSelf == true) { infoscr.SetActive(false); }
    }

    public void ShowInfo()
    {   
        infoscr.SetActive(!(infoscr.activeSelf));
        if (whichGal.activeSelf == true) { whichGal.SetActive(false); }

    }

    public void GoToMilkyWay()
    {
        tele.Play();
        DontDestroyOnLoad (tele);
        SceneManager.LoadScene("milkyway");
        Debug.Log("Milky way yay!");
    }
    public void GoToAndromeda()
    {
        tele.Play();
        DontDestroyOnLoad(tele);
        SceneManager.LoadScene("andromeda");
        Debug.Log("Andrommeda");
    }

    public void Reset()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void HoverSound()
    {
        hover.Play();
    }

    public void ShowMWBack()
    {
        androm.sprite = mwb;
    }

    public void ShowAMBack()
    {
        milkyw.sprite = amb;
    }

    public void RestoreAM()
    {
        androm.sprite = amf;
    }

    public void RestoreMW()
    {
        milkyw.sprite = mwf;
    }
}
