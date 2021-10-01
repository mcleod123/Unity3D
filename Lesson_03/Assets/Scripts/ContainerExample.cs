using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerExample : MonoBehaviour
{
    [SerializeField] private List<Enemy> _enemies = new List<Enemy>();

    [SerializeField] private List<Enemy> _enemyOnLevelOne = new List<Enemy>();

    [SerializeField] private EnemyType[] _enemyTypeOnLevelOne;

    private Dictionary<EnemyType, Enemy> _enemiesDictionary = new Dictionary<EnemyType, Enemy>();
    // Start is called before the first frame update
    void Start()
    {
        PrepareDictionary();
        InitLevelOneEnemies();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void PrepareDictionary()
    {
        foreach (var enemy in _enemies)
        {
            _enemiesDictionary[enemy.Type] = enemy;
        }
    }

    private void CheckOnFinish()
    {
        if (_enemyOnLevelOne.Count == 0)
        {
            Debug.Log("Level completed");
        }
    }

    [ContextMenu("Test Kill Enemy")]
    private void TestKillEnemy()
    {
        var index = UnityEngine.Random.Range(0, _enemies.Count);
        Debug.Log($"Was killed {_enemyOnLevelOne[index].Type}");
        _enemyOnLevelOne.RemoveAt(index);
        CheckOnFinish();
    }

    private void InitLevelOneEnemies()
    {
        foreach (var enemyType in _enemyTypeOnLevelOne)
        {
            _enemyOnLevelOne.Add(_enemiesDictionary[enemyType]);
            //var enemyResult = _enemies.Find(enemy => enemy.Type == enemyType);
            //_enemyOnLevelOne.Add(enemyResult);
        }
    }
}

public enum EnemyType
{
    Andromeda,
    Beshop,
    Challenger
}

[System.Serializable]
public class Enemy
{
    public int HealthPoint;
    public int ScorePointsOnDeath;
    public EnemyType Type;
}

