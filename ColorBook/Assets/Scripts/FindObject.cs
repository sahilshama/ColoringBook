using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FindObject : MonoBehaviour
{
    public GameObject[] objects;
    
    public Button button;
    private int count;
    private bool isOn = false;
    private void OnEnable()
    {
        isOn = false;
        for(int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(false);
            
        }
    }
    // Start is called before the first frame update
    void update()
    {
        button.onClick.AddListener(onbuttonclick);
    }

    private void onbuttonclick()
    {
        if(isOn)
        {
            isOn = true;
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(false);
                Debug.Log("activated");
            }
        }
    }
}
