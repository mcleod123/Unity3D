using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    // test
    [SerializeField] float forceEnemyEngine = 180f;
    // ---------

    public Text scoreText;
 
    [SerializeField] GameObject _enemyShip1;
    [SerializeField] GameObject _enemyShip2;
    [SerializeField] GameObject _respaun;

    private Vector3 _gamerPosition;
    private Quaternion _gamerRotation;

    private Vector3 _respaunPosition;
    private Quaternion _respaunRotation;

    private float _frequencySetEnemyShips = 1f;
    private float _rightEdge = 20f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SetEnemyShipCoroutine());
        
        AudioManager.PlayMusic(MusicType.BackgroundMusic);
        
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    IEnumerator SetEnemyShipCoroutine()
    {
        while (true)
        {
            // yield return null;
            yield return new WaitForSeconds(_frequencySetEnemyShips);
            SetEnemyShip();
        }
    }


    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreContoller.GetPoints().ToString();
    }


    void SetEnemyShip()
    {

        // player position
        _gamerPosition = GameObject.Find("PlayerGroup").transform.position;
        _gamerRotation = GameObject.Find("PlayerGroup").transform.rotation;

        // respaun point position
        _respaunPosition = GameObject.Find("Respaun1").transform.position;
        _respaunRotation = GameObject.Find("Respaun1").transform.rotation;

        // random enemy ship types
        int randShip = Random.Range(1, 3);
        GameObject randEnemyShip;


        switch(((uint)randShip))
        {
            case 1:
                randEnemyShip = _enemyShip1;
                break;

            case 2:
                randEnemyShip = _enemyShip2;
                break;
            default:
                randEnemyShip = _enemyShip1;
                break;
        }

        // GameObject enemyShip = Instantiate(_enemyShip1, _gamerPosition, _gamerRotation ) as GameObject;
        GameObject enemyShip = Instantiate(randEnemyShip, _respaunPosition, _respaunRotation) as GameObject;






        Rigidbody enemyShipRigitBody = enemyShip.GetComponent<Rigidbody>();

        // mass
        // enemyShipRigitBody.SetDensity(50);

        enemyShip.transform.Rotate(0, 180, 0);
        enemyShipRigitBody.transform.Rotate(0, 180, 0);


        // enemyShip.transform.Translate(Vector3.right * Random.Range(0, 12) * Time.deltaTime);
        enemyShip.transform.Translate(Vector3.right * Random.Range(0, _rightEdge));


        // add force to enemyship
        enemyShipRigitBody.AddForce( -enemyShip.transform.forward * 60, ForceMode.Impulse);

        Destroy(enemyShip, 30);

    }









}
