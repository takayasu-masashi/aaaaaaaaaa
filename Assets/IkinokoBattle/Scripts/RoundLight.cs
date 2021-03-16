using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundLight : MonoBehaviour
{
    // Start is called before the first frame update// Update is called once per frame
    void Update()
    {
        //Y軸に対して、1秒間に-12度回転させる
        transform.Rotate(new Vector3(0, -12) * Time.deltaTime);

    }
}
