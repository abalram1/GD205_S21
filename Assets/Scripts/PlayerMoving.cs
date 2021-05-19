using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class PlayerMoving : MonoBehaviour
{
    public List<Transform> Spaces;
    Vector3 NextPosition;
    public int CurrentSpace = 0;
    public GameObject Spinner;
    public TextMeshPro MovementCounter;

    [SerializeField] private UnityEvent IfBattle; //makes these events private so they cannot be called on
    [SerializeField] private UnityEvent IfNoBattle; //makes these events private so they cannot be called on

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Spaces[0].position;
        StartCoroutine(MoveSpaces(1));
    }
    public void SpinToMove()
    {
        int Value = Spinner.GetComponent<Spinner>().Spin_Spinner();
        StartCoroutine(MoveSpaces(Value));
        MovementCounter.text = Value.ToString();
    }
    IEnumerator MoveSpaces(int MoveAmount)
    {
        for (int y = 0; y <= MoveAmount-1; y++)
        {
            CurrentSpace++;
            if (CurrentSpace >= Spaces.Count) CurrentSpace -= Spaces.Count;

            for (int x = 0; x < MoveAmount; x++)
            {
                Vector3 Target = Spaces[CurrentSpace].position;
                yield return new WaitForSecondsRealtime(0.25f);
                Target.y = 3.83f;
                NextPosition = Target;
                MovementCounter.text = (MoveAmount-1 - y).ToString();
            }
        }
        MovementCounter.text = " ";
        Check_Space(Spaces[CurrentSpace].gameObject);
    }

    public void Check_Space(GameObject Space)
    {
        Type_Of_Space Place = Space.GetComponent<Type_Of_Space>();
        if (Place.Battle)
        {
            StartCoroutine(StartBattle());
        }
        else if (Place.No_Battle)
        {
            StartCoroutine(No_Battle());
        }
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, NextPosition, 25f * Time.deltaTime);
    }
    IEnumerator StartBattle()
    {
        yield return new WaitForSecondsRealtime(1f);
        IfBattle.Invoke();
        yield return null;
    }
    IEnumerator No_Battle()
    {
        yield return new WaitForSecondsRealtime(1f);
        IfNoBattle.Invoke();
        yield return null;
    }
}                            
