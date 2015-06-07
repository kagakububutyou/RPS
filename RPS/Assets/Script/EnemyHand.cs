using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
/// <summary>
/// 相手の手を決めるスクリプト
/// </summary>
public class EnemyHand : IHand{

    /// <summary>
    /// 敵の手のデータ
    /// </summary>
    [System.Serializable]
    public struct DATA
    {
        /// <summary>
        /// 敵の手のデータ
        /// </summary>
        /// <param name="type">手の種類</param>
        /// <param name="sprite">画像</param>
        public DATA(ICharacterHand.HandType type, Sprite sprite)
        {
            this.type = type;
            this.sprite = sprite;
 
        }
        /// <summary>
        /// 手の種類
        /// </summary>
        public ICharacterHand.HandType type;
        /// <summary>
        /// スプライト
        /// </summary>
        public Sprite sprite;
    }

    /// <summary>
    /// 敵のデータ
    /// </summary>
    [SerializeField]
    private List<DATA> data = new List<DATA>();
    /// <summary>
    /// 画像
    /// </summary>
    private Image image = null;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    private void Start()
    {
        image = GetComponent<Image>();
		image.enabled = false;
    }
    /// <summary>
    /// ゲーム開始時
    /// </summary>
	public void StartGame()
	{
		PushHand ();
		image.enabled = true;
	}

    /// <summary>
    /// リセット
    /// </summary>
	public void Reset()
	{
		PushHand ();
	}
    /// <summary>
    /// ゲーム終了
    /// </summary>
	public void EndGame()
	{
		image.enabled = false;
	}
	/// <summary>
	/// 何を出すか決めるところ
	/// </summary>
	protected override void PushHand()
	{
		RandomHand();
		manager.GetHand(handType);
	}

    /// <summary>
    /// 敵の手を決める
    /// </summary>
    private void RandomHand()
    {
        handType = (ICharacterHand.HandType)Random.Range(0, (int)ICharacterHand.HandType.MaxValue);
        foreach (var d in data)
	    {
            if (d.type == handType)
            {
		        image.sprite = d.sprite;
                break;
            }
	    }
    }
}
