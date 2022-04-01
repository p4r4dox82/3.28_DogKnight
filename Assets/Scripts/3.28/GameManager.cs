using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, Subject
{
    private static GameManager _instance;
    public static GameManager Instance()
    {
        return _instance;
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (this != _instance)
            {
                Destroy(this.gameObject);
            }
        }
    }

    private int _gameRound = 0;
    private string _whoseTurn = "Enemy";
    private bool _isEnd = false;

    // 1. SceneUI�� GameManager ���� �� �� �ֵ��� ĳ���� ��ųʸ� ����
    private Dictionary<string, Character> _characterList = new Dictionary<string, Character>();

    private delegate void TurnHandler(int round, string turn);
    private TurnHandler _turnHandler;
    private delegate void FinishHandler(bool isFinish);
    private FinishHandler _finishHandler;
    // 2. UIHandler ���� (�̹����� round, turn, isFinish ��� �޴´�)
    private delegate void UIHandler(int round, string turn, bool isFinish);
    private UIHandler _uiHandler;

    public void RoundNotify()
    {
        if (!_isEnd)
        {
            if(_whoseTurn == "Enemy")
            {
                _gameRound++;
                Debug.Log($"GameManager: Round {_gameRound}.");
            }
            TurnNotify();
        }
    }

    public void TurnNotify()
    {
        _whoseTurn = _whoseTurn == "Enemy" ? "Player" : "Enemy";
        Debug.Log($"GameManager: {_whoseTurn} turn.");
        _turnHandler(_gameRound, _whoseTurn);
        // 2. _uiHandler ȣ��
    }

    public void EndNotify()
    {
        _isEnd = true;
        _finishHandler(_isEnd);
        // 2. _uiHandler ȣ��
        Debug.Log("GameManager: The End");
        Debug.Log($"GameManager: {_whoseTurn} is Win!");
    }

    public void AddCharacter(Character character)
    {
        _turnHandler += new TurnHandler(character.TurnUpdate);
        _finishHandler += new FinishHandler(character.FinishUpdate);
        // 1. _characterList�� �߰�
    }

    // 3. AddUI: SceneUI �������� ���
    public void AddUI(SceneUI ui)
    {
    
    }

    /// <summary>
    /// 4. GetChracter: �Ѱ� ���� name�� Character�� �ִٸ� �ش� ĳ���� ��ȯ
    /// 1) _characterList ��ȸ�ϸ�
    /// 2) if ���� ContainsKey(name) �̿�
    /// 3) ���ٸ� null ��ȯ
    /// </summary>
    public Character GetCharacter(string name)
    {
        return null;
    }
}