using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBook : MonoBehaviour
{



    public Color[] colorlist;
    public Color curColor;
    public int colorCount;
     



    void Start()
    {
        Camera.main.backgroundColor = Color.gray;

    }

    
    void Update()
    {
        curColor = colorlist[colorCount];

        var ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray, -Vector2.up);

        if (Input.GetButton("Fire1"))
        {
            if (hit.collider != null)
            {
                SpriteRenderer sp = hit.collider.gameObject.GetComponent<SpriteRenderer>();
                Debug.Log(hit.collider.name);
                Debug.Log("fill iit up");
 
                sp.color = curColor;

            }
        }
        
    }
    public void Paint(int colorCode)
    {
        colorCount = colorCode;
    }

}
