using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
//CrossPlatformInputはNamespaceで分けられているため、usingで読み込む必要がある。

public class InputTest : MonoBehaviour
{
    void Update()
    {
        if(CrossPlatformInputManager.GetButtonDown("Jump")) {
            Debug.Log("Jumpボタンが押されたよ！");
        }
        if (CrossPlatformInputManager.GetButtonDown("Fire1")) {
            Debug.Log("Fire1ボタンが押されたよ！");
        }


    }
}
