using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
    public Text text;
    int ZMIANA;
    // Start is called before the first frame update
    States myState;
    private enum States { state_entry, state_talkone, state_compliment, state_book, state_weather,
        state_gate, state_window, state_windowlocked, state_pay, state_miracle, state_gatetwo, state_paytwo,
        state_miracletwo, state_friend, state_weird, state_chair, state_sit, state_noattention, state__waiter,
        state_water, state_wine, state_ask, state_smile, state_fun, state_takeabillpay, state_complimenttwo,
        state_share, state_payforyourself, state_shewantstopay, state_agree, state_disagree }

    void state_entry()
    {
        
        text.text = "Znajdujesz się przed wejściem do ekskluzywnej restauracji Ryneczek Lidla, \n" +
            " jesteś tam wraz z dziewczyną, którą poznałeś wczoraj na imprezie w pubie, \n" +
            "problem w tym, że zapomniałeś zarezerwować stolik... \n" +
            "Naciśnij 1, aby zagadać do laski\n" +
            "1. Zagadaj";

        if (Input.GetKeyDown(KeyCode.Alpha1))
        { 
            myState = States.state_talkone;
        }
    }

    void Start() {
        myState = States.state_entry;

    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.state_entry) { state_entry(); }
        else if (myState == States.state_talkone) { state_talkone(); }
        else if (myState == States.state_agree) { state_agree(); }
        //else if (myState == States.state_book) { state_book(); }
        

        
        //else if (myState = States.state_entry){state_entry(); }

    } 

    private void state_agree()
    {
        text.text = "zgoda text tutaj";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_agree; }
    }

    private void state_book()
    {
        text.text = "cytat text tutaj";
        if (Input.GetKeyDown(KeyCode.A)) { myState = States.state_book; }
    }

    private void state_talkone()
    {
        text.text = "zagadaj text tutaj";
        if (Input.GetKeyDown(KeyCode.Alpha1)) {myState = States.state_talkone; }

    }

    private void state_compliment()
    {
        text.text = "komplement text tutaj";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_book; }
    }
    private void state_gate()
    {
        text.text = "bramka text tutaj";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_gate; }
      
    }
}
