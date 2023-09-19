using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StretchObject : MonoBehaviour
{
    public Transform targetObject;
    public float stretchSpeed = 1.0f;
    [SerializeField] string _stretchButton = "StretchButton"; // ボタンの名前

    private bool stretching = false;

    void Update()
    {
        // ボタンが押されている間にストレッチを開始
        if (Input.GetButtonDown(_stretchButton))
        {
            stretching = true;
        }

        // ボタンが離されたらストップ
        if (Input.GetButtonUp(_stretchButton))
        {
            stretching = false;
        }

        // ボタンが押されている間に伸ばす処理
        if (stretching)
        {
            Vector3 scale = targetObject.localScale;
            scale.y += stretchSpeed * Time.deltaTime;
            targetObject.localScale = scale;
        }
    }
}
