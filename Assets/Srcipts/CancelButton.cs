﻿using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CancelButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ボタン押した時にキャンセルの音が鳴るようにする
        GetComponent<Button>().onClick.AddListener(() =>
        {
            AudioManager.Instance.Play("cancel");
        });
    }
}
