using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    ////////////////////////////////////////////////////////////////////////////////////
    // Lesson6 課題作成（画面外に出たオブジェクトを削除する）
    ////////////////////////////////////////////////////////////////////////////////////
    public void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

}
