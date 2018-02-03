using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightOperations : MonoBehaviour
{
    bool _value = false;
    public Material LightONMaterial;
    public Material LightOFFMaterial;

	// Use this for initialization
	void Start ()
    {
        var canvas = this.transform.parent.transform.Find("Canvas").gameObject;

        if (canvas != null)
        {
            UpdateImage(canvas);
            canvas.SetActive(false);
        }
    }

    private void UpdateImage(GameObject canvas)
    {
        // Get the value of the light object from server.
        var rawImage = canvas.GetComponentInChildren<RawImage>();
        if (rawImage != null)
        {
            if (!_value)
            {
                rawImage.material = LightOFFMaterial;
            }
            else
            {
                rawImage.material = LightONMaterial;
            }
        }
    }

    // Update is called once per frame
    void Update ()
    {
        // Get the value of the light object from server at regular interval.
    }

    void OnTapSelect()
    {
        // Toggle the light image as per the value of the light object.
        // Value shall be read from the server.
        //canvas.SetActive(true);
        _value = !_value;
        var canvas = this.transform.parent.transform.Find("Canvas").gameObject;

        if (canvas != null)
        {
            UpdateImage(canvas);
            canvas.SetActive(true);
        }
    }
}
