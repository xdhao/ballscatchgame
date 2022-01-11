using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    private int count;
    public Text CountText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        count++;
        CountText.text = "balls caught:" + count;
        Destroy(other.gameObject);
    }
}
