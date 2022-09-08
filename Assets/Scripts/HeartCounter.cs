using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HeartCounter : MonoBehaviour
{   
    public TMP_Text txt;
    public int heartCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        heartCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = heartCount.ToString("Hearts collected:    "+heartCount);
    }
    private void OnTriggerEnter(Collider other)
    {
        heartCount++;
        Destroy(other.gameObject);
        Debug.Log("Hearts collected: " + heartCount);
    }
}
