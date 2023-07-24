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
    public Animator transAnim;
    // Start is called before the first frame update
    void Start()
    {
        whichGal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(whichGal);
    }

    public void ShowMenu()
    {
        whichGal.SetActive(!(whichGal.activeSelf));
    }

    public void GoToMilkyWay()
    {
        SceneManager.LoadScene("milkyway");
        Debug.Log("Milky way yay!");
    }
    public void GoToAndromeda()
    {
        SceneManager.LoadScene("andromeda");
        Debug.Log("Andrommeda");
    }

    public void Reset()
    {
        SceneManager.LoadScene("MainScene");
    }


}
