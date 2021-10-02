using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show2DMessage : MonoBehaviour
{
    private Text _text;
    // Start is called before the first frame update
    void Start()
    {
        Canvas _c = GetComponentInChildren<Canvas>();
        _text = _c.GetComponentInChildren<Text>();
        _text.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D obj) {
        if (obj.tag == "Player"){
            _text.gameObject.SetActive(true);
            Destroy(_text, 2.0f);
        }
    }
}
