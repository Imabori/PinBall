using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemePoint : MonoBehaviour {

    //ポイント表示するテキスト
    private GameObject GamePointText;

    //ポイントの変数宣言
    int point = 0;
    
    // Use this for initialization
    void Start () {

        //シーン中のGamePointTextオブジェクトを取得
        this.GamePointText = GameObject.Find("GamePointText");

        //初期ポイントを表示
        this.GamePointText.GetComponent<Text>().text = "Point : " + point;
        }

    // Update is called once per frame
    void Update() {
    
    }

    //星、雲に当たった時にポイントを加算する関数
    void OnCollisionEnter(Collision other) { 
            //小さい星と衝突した？
            if (other.gameObject.tag == "SmallStarTag"){
            point += 10;
    
            //大きい星と衝突した？
            }else if (other.gameObject.tag == "LargeStarTag"){
            point += 20;

            //小さい雲と衝突した？
            }else if (other.gameObject.tag == "SmallCloudTag"){
            point += 30;
            
            //大きい雲と衝突した？
            }else if (other.gameObject.tag == "LargeCloudTag"){
            point += 50;
            }



        //初期ポイントを表示
        this.GamePointText.GetComponent<Text>().text = "Point : " + point;
    }
}
