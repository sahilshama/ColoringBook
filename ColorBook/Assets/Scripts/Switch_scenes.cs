using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Switch_scenes : MonoBehaviour
{

    public Button button;
    public string scene1;

    // Start is called before the first frame update
    private void Start()
    {
        button.onClick.AddListener(onButtonclick);
    }

    private void onButtonclick()
    {
        SceneManager.LoadScene(scene1);
    }

    
}
