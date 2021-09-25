using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameStateEnumerator
{
    GameMenuPaused,
    GameIsStarting
}


public class Ship : MonoBehaviour
{

    public static GameStateEnumerator _state;

    [SerializeField] private float _speed = 3.5f;


    // private float _positionX;
    // private float _positionZ;

    private SpriteRenderer spriteRenderer;

    public Sprite _shipSpriteNormal = Resources.Load<Sprite>("Sprites/ship");
    public Sprite _shipSpriteTurnLeft = Resources.Load<Sprite>("Sprites/ship_turn_left");
    public Sprite _shipSpriteTurnRight = Resources.Load<Sprite>("Sprites/ship_turn_right");

    // Start is called before the first frame update
    void Start()
    {

        // default state
        //_state = GameStateEnumerator.GameMenuPaused;
        _state = GameStateEnumerator.GameIsStarting;

        // ship sprites
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = _shipSpriteNormal;


        // ShipHidingPausedGame();

    }


    // Update is called once per frame
    void Update()
    {

        if(_state == GameStateEnumerator.GameMenuPaused)
        {

        } 
        else
        {
           // ShipReadyToGame();
            //ShipMovement();
        }

        ShipMovement();

    }


    private void ShipMovement()
    {

        // if ship maneuvers
        bool _isShipManeuvers = false;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Motion(Vector3.right);
            _isShipManeuvers = true;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Motion(Vector3.left);
            _isShipManeuvers = true;
        }


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Motion(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Motion(Vector3.back);
        }



        if (_isShipManeuvers == false)
        {
            spriteRenderer.sprite = _shipSpriteNormal;
        }

    }
      

    private void Motion(Vector3 direction)
    {

        // if turn left or right
        ShipBodyTransform(direction);


        if (direction.Equals(Vector3.right))
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);

        }

        if (direction.Equals(Vector3.left))
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }





        if (direction.Equals(Vector3.back))
        {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }

        if (direction.Equals(Vector3.forward))
        {
            transform.Translate(Vector3.up * _speed * Time.deltaTime);
        }


    }


    // if ship move left or right - scale ship body
    private void ShipBodyTransform(Vector3 direction)
    {

        if (direction.Equals(Vector3.right))
        {
            spriteRenderer.sprite = _shipSpriteTurnRight;

        }


        if (direction.Equals(Vector3.left))
        {
            spriteRenderer.sprite = _shipSpriteTurnLeft;
        }


        if (
                    direction.Equals(Vector3.forward) 
                ||  direction.Equals(Vector3.back)
            )
        {
            spriteRenderer.sprite = _shipSpriteNormal;
        }



    }


    private void ShipReadyToGame()
    {
        transform.position = new Vector3(0f, 3f);

    }

    private void ShipHidingPausedGame()
    {
        transform.position = new Vector3(0f, -200f);

    }

}
