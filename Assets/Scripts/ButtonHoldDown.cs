using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHoldDown : MonoBehaviour
{
    // ボタンを押したときtrue、離したときfalseになるフラグ
    private bool buttonDownFlag = false;
    private void Update()
    {
        if (buttonDownFlag)
        {
            // ボタンが押しっぱなしの状態の時にのみ「Hold」を表示する。
            Debug.Log("Hold");
        }
    }
    // ボタンを押したときの処理
    public void OnButtonDown()
    {
        Debug.Log("Down");
        buttonDownFlag = true;
    }
    // ボタンを離したときの処理
    public void OnButtonUp()
    {
        Debug.Log("Up");
        buttonDownFlag = false;
    }
}
