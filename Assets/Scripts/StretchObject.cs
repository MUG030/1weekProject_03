using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StretchObject : MonoBehaviour
{
    public Transform targetObject;
    public float stretchSpeed = 1.0f;

    private bool _stretching = false;
    private Vector3 _originalScale;

    private void Start()
    {
        // 初期のスケールを保存
        _originalScale = targetObject.localScale;
    }

    private void Update()
    {
        // ボタンが押されている間に伸ばす処理
        if (_stretching)
        {
            Vector3 scale = targetObject.localScale;
            scale.y += stretchSpeed * Time.deltaTime;
            targetObject.localScale = scale;
        }
        else
        {
            // ボタンが離されたときに元の大きさに戻す処理
            Vector3 currentScale = targetObject.localScale;
            currentScale.y = Mathf.MoveTowards(currentScale.y, _originalScale.y, stretchSpeed * Time.deltaTime);
            targetObject.localScale = currentScale;
        }
    }

    public void StartStretching()
    {
        // ボタンが押されたときに伸ばす処理を開始
        _stretching = true;
    }

    public void StopStretching()
    {
        // ボタンが離されたときに伸ばす処理を停止
        _stretching = false;
    }
}
