using UnityEngine;
using System.Collections;
using System;
/// <summary>
/// オフラインでのスコアランキング
/// </summary>
public class ScoreRanking : MonoBehaviour {

    /// <summary>
    /// ランキングのアクセスキー
    /// </summary>
    private string rankingPrefKey = "ranking";
    /// <summary>
    /// ランキングの順位数
    /// </summary>
    private static int rankingNum = 5;
    /// <summary>
    /// ランキング格納するところ
    /// </summary>
    private int[] ranking = new int[rankingNum];

	// Use this for initialization
	void Start () 
    {
        DrawRanking();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    /// <summary>
    /// ランキングをPlayerPrefsから取得してRankingに格納
    /// </summary>
    public void GetRanking()
    {
        var _ranking = PlayerPrefs.GetString(rankingPrefKey);
        if (_ranking.Length > 0)
        {
            var _scor = _ranking.Split(","[0]);
            for (int i = 0; i < _scor.Length && i< rankingNum; i++)
            {
                ranking[i] = int.Parse(_scor[i]);
            }
        }
    }
    /// <summary>
    /// 新しいスコアの保存
    /// </summary>
    /// <param name="NewScor">新しい記録</param>
    public void SaveRanking(int NewScor)
    {
        if (ranking != null)
        {
            for (int i = 0; i < ranking.Length; i++)
            {
                if (ranking[i] < NewScor)
                {
                    var tmp = ranking[i];
                    ranking[i] = NewScor;
                    NewScor = tmp;
                }
            }
        }
        else
        {
            ranking[0] = NewScor;
        }
        
        //  int配列をstring配列へ
        string ranking_string = string.Join(",", Array.ConvertAll(ranking, new Converter<int, string>(s => s.ToString())));
        // 配列を文字列に変換して PlayerPrefs に格納
        PlayerPrefs.SetString(rankingPrefKey, ranking_string);
    }
    /// <summary>
    /// ランキング削除 
    /// </summary>
    private void DeleteRanking()
    {
        PlayerPrefs.DeleteKey(rankingPrefKey);
    }

    private void DrawRanking()
    {
        for (int i = 0; i < ranking.Length; i++)
        {
            Debug.Log(ranking[i]);
        }
    }
}
