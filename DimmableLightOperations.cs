using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DimmableLightOperations : MonoBehaviour
{
    public Text text;
    public Slider dimmableLightValueChanger;

    // Use this for initialization
    void Start()
    {
        var canvas = this.transform.parent.transform.Find("Canvas").gameObject;

        if (canvas != null)
        {
            canvas.SetActive(false);
        }

        dimmableLightValueChanger.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ValueChangeCheck()
    {
        text.text = dimmableLightValueChanger.value.ToString();
    }
}
