using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
   // public int ScenesToLoad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    public void ChangeScene()
    {
        SceneManager.LoadScene(ScenesToLoad);
    }

    public void LoadNextSceneAutomated()
    {
        SceneManager.LoadScene(SceneManager.GeActiveScene().buildIndex +1);

    }
    */

    
    public void ChangeScene01()
    {
        SceneManager.LoadScene("01ColorScene");
    }

    public void ChangeScene02()
    {
        SceneManager.LoadScene("02NumberScene");
    }


   public void ChangeSzene00()
    {
        SceneManager.LoadScene("00WelcomeScene");
    }


    public InputField ifA;
    public InputField ifB;
    public Text txt;
    public Text message;

    public Color rot = Color.red;
    public Color weiss = Color.white;

    public float ifAFloat;
    public float ifBFloat;

    public void AddNumbers()
    {
        try
        {
            ifAFloat = float.Parse(ifA.text);
            ifA.image.color = weiss;
            message.text = "ADD NUMBERS";
        }
        catch (System.Exception)
        {
            message.text = "Geben Sie bitte eine gültige Zahl ein!";
            ifA.image.color = rot;
        }

        try
        {
            ifBFloat = float.Parse(ifB.text);
            ifB.image.color = weiss;
        }
        catch (System.Exception)
        {
            message.text = "Geben Sie bitte eine gültige Zahl ein!";
            ifB.image.color = rot;
        }

        txt.text = (ifAFloat + ifBFloat).ToString();
        Debug.Log("Die Addition ergibt: " + txt.text);
    }


}
