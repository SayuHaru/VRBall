using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 追加しましょう


public class FinishScore : MonoBehaviour
{
    public GameObject score_object2 = null; // Textオブジェクト

    // 初期化
    void Start()
    {
    }

    // 更新
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object2.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Finish!!";
        score_text.text = "Your Score : " + akatamaController.score;
    }
}