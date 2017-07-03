﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchScript.Gestures;

public class MoveNode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnEnable()
    {
        // Transform Gestureのdelegateに登録
        GetComponent<TransformGesture>().TransformStarted += TransformStartedHandle; // 変形開始
        GetComponent<TransformGesture>().StateChanged += StateChangedHandle; //　状態変化
        GetComponent<TransformGesture>().TransformCompleted += TransformCompletedHandle; // 変形終了
        GetComponent<TransformGesture>().Cancelled += CancelledHandle; // キャンセル
    }

    void OnDisable()
    {
        UnsubscribeEvent();
    }

    void OnDestroy()
    {
        UnsubscribeEvent();
    }

    void UnsubscribeEvent()
    {
        // 登録を解除
        GetComponent<TransformGesture>().TransformStarted -= TransformStartedHandle;
        GetComponent<TransformGesture>().StateChanged -= StateChangedHandle;
        GetComponent<TransformGesture>().TransformCompleted -= TransformCompletedHandle;
        GetComponent<TransformGesture>().Cancelled -= CancelledHandle;
    }

    void TransformStartedHandle(object sender, System.EventArgs e)
    {
        // 変形開始のタッチ時の処理
    }

    void StateChangedHandle(object sender, System.EventArgs e)
    {
        // 変形中のタッチ時の処理
    }

    void TransformCompletedHandle(object sender, System.EventArgs e)
    {
        // 変形終了のタッチ時の処理
    }
    void CancelledHandle(object sender, System.EventArgs e)
    {
        // 変形終了のタッチ時の処理
    }
}