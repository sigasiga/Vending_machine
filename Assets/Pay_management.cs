using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pay_management : MonoBehaviour {

	public Text All_payment;//投入金額表示用
	public Text Change_text;//お釣り金額表示用

	public int Payment=0;//投入金額管理用変数
	public int[] Pay;

	Price_management Price_management;//商品の値段を持つコンポーネント

	//お釣りの硬貨、紙幣の枚数の計算用の変数
	int Change_10	= 0;
	int Change_50	= 0;
	int Change_100	= 0;
	int Change_500 	= 0;
	int Change_1000 = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//投入金額表示
		All_payment.text = "投入金額: " + Payment.ToString();
	}
	//--------------------------------------
	//投入金額ごとに変数を用意
	//10円
	public void pay_10(){
		Payment += Pay[0];//10円加算
	}
	//50円
	public void pay_50(){
		Payment += Pay[1];//50円加算
	}
	//100円
	public void pay_100(){
		Payment += Pay[2];//100円加算
	}
	//500円
	public void pay_500(){
		Payment += Pay[3];//500円加算
	}
	//1000円
	public void pay_1000(){
		Payment += Pay[4];//1000円加算
	}
	//--------------------------------------

	//支払い用の関数
	//--------------------------------------
	//各商品ごとに支払い関数
	//商品1の支払い関数
	public void price0_Buy(){
		Price_management = gameObject.GetComponent<Price_management> ();//商品の値段を持つコンポーネントの取得
		//投入金額を超える場合は支払えない用にする
		if(Payment - Price_management.price [0] >= 0){
			Payment -= Price_management.price [0];//支払い
		}else{
			
		}
	}
	//商品2の支払い関数
	public void price1_Buy(){
		Price_management = gameObject.GetComponent<Price_management> ();//商品の値段を持つコンポーネントの取得
		//投入金額を超える場合は支払えない用にする
		if(Payment - Price_management.price [1] >= 0){
			Payment -= Price_management.price [1];//支払い
		}else{

		}
	}
	//商品3の支払い関数
	public void price2_Buy(){
		Price_management = gameObject.GetComponent<Price_management> ();//商品の値段を持つコンポーネントの取得
		//投入金額を超える場合は支払えない用にする
		if(Payment - Price_management.price [2] >= 0){
			Payment -= Price_management.price [2];//支払い
		}else{

		}
	}
	//--------------------------------------

	//お釣り精算関数
	public void Change(){
		//お釣りの金額の表示
		Change_text.text = "お釣り: " + Payment.ToString();

		//お釣り硬貨、紙幣の計算
		while(Payment>0){
			//1000円札の枚数
			if(Payment-Pay[4]>=0){
				Payment -= Pay [4];
				Change_1000++;
			}
			//500円玉の枚数
			else if(Payment-Pay[3]>=0){
				Payment -= Pay [3];
				Change_500++;
			}
			//100円玉の枚数
			else if(Payment-Pay[2]>=0){
				Payment -= Pay [2];
				Change_100++;
			}
			//50円玉の枚数
			else if(Payment-Pay[1]>=0){
				Payment -= Pay [1];
				Change_50++;
			}
			//10円玉の枚数
			else if(Payment-Pay[0]>=0){
				Payment -= Pay [0];
				Change_10++;
			}
		}

		//コンソールに硬貨、紙幣の枚数の表示
		Debug.Log (Pay [4]+ "円が" + Change_1000 + "枚");
		Debug.Log (Pay [3]+ "円が" + Change_500 + "枚");
		Debug.Log (Pay [2]+ "円が" + Change_100 + "枚");
		Debug.Log (Pay [1]+ "円が" + Change_50 + "枚");
		Debug.Log (Pay [0]+ "円が" + Change_10 + "枚");
		//枚数の初期化
		Change_1000=0;
		Change_500=0;
		Change_100=0;
		Change_50=0;
		Change_10=0;
	}
}
