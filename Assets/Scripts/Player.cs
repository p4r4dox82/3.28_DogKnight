using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private Enemy _enemy;
    private float _randomAttack;

    /// <summary>
    /// 1. Init: �ʱ�ȭ ���
    /// 1) Subject�� Observer�� ���
    /// 2) _myName, _myHp, _myDamage, _playerNumber �ʱ�ȭ
    /// 3) _playerNumber�� ������ 0���� �� ��
    /// 4) Player, 100, 20���� ���� �ʱ�ȭ (���� ����)
    /// </summary>
    protected override void Init()
    {
        base.Init();
    }

    private void Awake()
    {
        Init();
    }

    /// <summary>
    /// 1) _enemy�� �Ҵ��� �ȵƴٸ�,
    /// 2) GameObject.FindWithTag �̿��ؼ� _enemy �Ҵ�
    /// </summary>
    private void Start()
    {

    }

    /// <summary>
    /// Attack:
    /// 1) Player�� 30%�� Ȯ���� ���ݷ��� �� ���� ������ ���� ��
    /// 2) _randomAttack = Random.Range(0,10); ���� ���� ���� ����
    ///   -> 0~9 ������ ���� �� �ϳ��� �������� �Ҵ����.
    /// 3) _randomAttack �̿��ؼ� 30% Ȯ���� ���� ���ݷº��� 10 ���� ���� ����
    /// 4) �̶��� AttackMotion() ���� SpecialAttackMotion() ȣ���� ��
    ///    + Debug.Log($"{_myName} Special Attack!"); �߰�
    /// 5) 70% Ȯ���� �ϴ� �Ϲ� ������ Character�� ���ִ� �ּ��� ����
    /// </summary>
    public override void Attack()
    {

    }

    public override void GetHit(float damage)
    {

    }
}