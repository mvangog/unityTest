using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectie : MonoBehaviour {

    Vector2 punt1;
    Vector2 punt2;
    public GameObject selectievak;
    bool tweedePunt;

    // Use this for initialization
    void Start () {
        tweedePunt = false;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            punt1 = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            //punt1.y = -1 * punt1.y;
            //punt1.z = 0;
            Debug.Log(punt1);
            selectievak.GetComponent<RectTransform>().anchoredPosition = punt1;
            tweedePunt = true;
        }
        else if (tweedePunt)
        {
            punt2 = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            
            Vector2 temppunt = new Vector2();
            if(punt2.y<punt1.y)
            {
                temppunt.y = punt2.y;
                punt2.y = punt1.y;
                punt1.y = temppunt.y;
            }
            if (punt2.x<punt1.x)
            {
                temppunt.x = punt2.x;
                punt2.x = punt1.x;
                punt1.x = temppunt.x;
            }
            selectievak.GetComponent<RectTransform>().sizeDelta = punt2 - punt1;
            if (Input.GetButtonDown("Fire1"))
            {
                tweedePunt = false;
            }
        }
    }
}
