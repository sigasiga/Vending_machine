using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Price_management : MonoBehaviour {

	public int[] price;//商品の値段
	public Text[] Text_price;//ボタンに表示する値段の管理


	// Use this for initialization
	void Start () {
		//ボタンに金額の代入
		for(int i=0;i<price.Length; i++){
			Text_price[i].text = "値段"+price[i].ToString();//ボタンのテキストに代入
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
