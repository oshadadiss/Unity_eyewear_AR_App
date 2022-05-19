using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chooseGlasses : MonoBehaviour
{
    public GameObject glasses1;
    public GameObject glasses2;
    public GameObject glasses3;

    Button glasses1button;
    Button glasses2button;
    Button glasses3button;


    // Start is called before the first frame update
    void Start()
    {
        glasses1button = GameObject.Find("Canvas/glasses1btn").GetComponent<Button>();
        glasses2button = GameObject.Find("Canvas/glasses2btn").GetComponent<Button>();
        glasses3button = GameObject.Find("Canvas/glasses3btn").GetComponent<Button>();

        glasses1button.onClick.AddListener(glasses1selected);
        glasses2button.onClick.AddListener(glasses2selected);
        glasses3button.onClick.AddListener(glasses3selected);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void glasses1selected()
    {
        glasses1.SetActive(true);
        glasses2.SetActive(false);
        glasses3.SetActive(false);

    }

    public void glasses2selected()
    {
        glasses1.SetActive(false);
        glasses2.SetActive(true);
        glasses3.SetActive(false);

    }

    public void glasses3selected()
    {
        glasses1.SetActive(false);
        glasses2.SetActive(false);
        glasses3.SetActive(true);

    }

}
