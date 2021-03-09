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


   [SerializeField] private InputField ifA; // [SerializedField] - auch wenn private im Inspector sichtbar
    public InputField ifB;
    public float Wert;
    public Text txt;

    public void AddNumbers()
    {
        Wert = float.Parse(ifA.text)+ float.Parse(ifB.text);
        Debug.Log(Wert);
        txt.text = Wert.ToString();
    }


   
}
