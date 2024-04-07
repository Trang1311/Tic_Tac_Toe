using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class TicTacToe : MonoBehaviour
{

//testing git
    Boolean checker;
    int plusone;
    public Text btnText1   = null;
    public Text btnText2 = null;
    public Text btnText3 = null;
    public Text btnText4 = null;
    public Text btnText5 = null;
    public Text btnText6 = null;
    public Text btnText7 = null;
    public Text btnText8 = null;
    public Text btnText9 = null;
    
    public Text btnReset = null;
    public Text btnNewGame = null;
    public Text msgFeedBack = null;

    public Text txtPlayerX;
    public Text txtPlayerO;

    public void Score()
    {
        if(btnText1.text == "X" && btnText2.text == "X" && btnText3.text == "X")
        {
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedBack.text = "The winner is player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone +1);
        }
        if (btnText1.text == "X" && btnText4.text == "X" && btnText7.text == "X")
        {
            btnText1.color = Color.red;
            btnText4.color = Color.red;
            btnText7.color = Color.red;
            msgFeedBack.text = "The winner is player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "X" && btnText5.text == "X" && btnText9.text == "X")
        {
            btnText1.color = Color.red;
            btnText5.color = Color.red;
            btnText9.color = Color.red;
            msgFeedBack.text = "The winner is player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText3.text == "X" && btnText5.text == "X" && btnText7.text == "X")
        {
            btnText3.color = Color.red;
            btnText5.color = Color.red;
            btnText7.color = Color.red;
            msgFeedBack.text = "The winner is player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText3.text == "X" && btnText6.text == "X" && btnText9.text == "X")
        {
            btnText3.color = Color.red;
            btnText6.color = Color.red;
            btnText9.color = Color.red;
            msgFeedBack.text = "The winner is player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText2.text == "X" && btnText5.text == "X" && btnText8.text == "X")
        {
            btnText2.color = Color.red;
            btnText5.color = Color.red;
            btnText8.color = Color.red;
            msgFeedBack.text = "The winner is player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText4.text == "X" && btnText5.text == "X" && btnText6.text == "X")
        {
            btnText4.color = Color.red;
            btnText5.color = Color.red;
            btnText6.color = Color.red;
            msgFeedBack.text = "The winner is player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText7.text == "X" && btnText8.text == "X" && btnText9.text == "X")
        {
            btnText7.color = Color.red;
            btnText8.color = Color.red;
            btnText9.color = Color.red;
            msgFeedBack.text = "The winner is player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        //PlayerO
        if (btnText1.text == "O" && btnText2.text == "O" && btnText3.text == "O")
        {
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedBack.text = "The winner is player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "O" && btnText4.text == "O" && btnText7.text == "O")
        {
            btnText1.color = Color.red;
            btnText4.color = Color.red;
            btnText7.color = Color.red;
            msgFeedBack.text = "The winner is player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "O" && btnText5.text == "O" && btnText9.text == "O")
        {
            btnText1.color = Color.red;
            btnText5.color = Color.red;
            btnText9.color = Color.red;
            msgFeedBack.text = "The winner is player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText3.text == "O" && btnText5.text == "O" && btnText7.text == "O")
        {
            btnText3.color = Color.red;
            btnText5.color = Color.red;
            btnText7.color = Color.red;
            msgFeedBack.text = "The winner is player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText3.text == "O" && btnText6.text == "O" && btnText9.text == "O")
        {
            btnText3.color = Color.red;
            btnText6.color = Color.red;
            btnText9.color = Color.red;
            msgFeedBack.text = "The winner is player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText2.text == "O" && btnText5.text == "O" && btnText8.text == "O")
        {
            btnText2.color = Color.red;
            btnText5.color = Color.red;
            btnText8.color = Color.red;
            msgFeedBack.text = "The winner is player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText4.text == "O" && btnText5.text == "O" && btnText6.text == "O")
        {
            btnText4.color = Color.red;
            btnText5.color = Color.red;
            btnText6.color = Color.red;
            msgFeedBack.text = "The winner is player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText7.text == "O" && btnText8.text == "O" && btnText9.text == "O")
        {
            btnText7.color = Color.red;
            btnText8.color = Color.red;
            btnText9.color = Color.red;
            msgFeedBack.text = "The winner is player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
    } 
    public void btnText1_Click()
    {
        if(checker==false)
        {
            btnText1.text = "X";
            checker = true;
        }
        else
        {
            btnText1.text = "O";
            checker = false;
        }
        Score();
            

    }
    public void btnText2_Click()
    {
        if (checker == false)
        {
            btnText2.text = "X";
            checker = true;
        }
        else
        {
            btnText2.text = "O";
            checker = false;
        }
        Score();


    }
    public void btnText3_Click()
    {
        if (checker == false)
        {
            btnText3.text = "X";
            checker = true;
        }
        else
        {
            btnText3.text = "O";
            checker = false;
        }
        Score();


    }
    public void btnText4_Click()
    {
        if (checker == false)
        {
            btnText4.text = "X";
            checker = true;
        }
        else
        {
            btnText4.text = "O";
            checker = false;
        }
        Score();


    }
    public void btnText5_Click()
    {
        if (checker == false)
        {
            btnText5.text = "X";
            checker = true;
        }
        else
        {
            btnText5.text = "O";
            checker = false;
        }
        Score();


    }
    public void btnText6_Click()
    {
        if (checker == false)
        {
            btnText6.text = "X";
            checker = true;
        }
        else
        {
            btnText6.text = "O";
            checker = false;
        }
        Score();


    }
    public void btnText7_Click()
    {
        if (checker == false)
        {
            btnText7.text = "X";
            checker = true;
        }
        else
        {
            btnText7.text = "O";
            checker = false;
        }
        Score();


    }
    public void btnText8_Click()
    {
        if (checker == false)
        {
            btnText8.text = "X";
            checker = true;
        }
        else
        {
            btnText8.text = "O";
            checker = false;
        }
        Score();


    }
    public void btnText9_Click()
    {
        if (checker == false)
        {
            btnText9.text = "X";
            checker = true;
        }
        else
        {
            btnText9.text = "O";
            checker = false;
        }
        Score();


    }
    public void btnReset_Click()
    {
        btnText1.text = " ";
        btnText2.text = " ";
        btnText3.text = " ";
        btnText4.text = " ";
        btnText5.text = " ";
        btnText6.text = " ";
        btnText7.text = " ";
        btnText8.text = " ";
        btnText9.text = " ";

        btnText1.color =Color.black; btnText2.color =Color.black;
        btnText3.color =Color.black;
            btnText4.color =Color.black;
        btnText5.color =Color.black;
        btnText6.color =Color.black;
            btnText7.color =Color.black;
        btnText8.color =Color.black;
        btnText9.color =Color.black;

    }    
    public void btnNew_Click()
    {
        SceneManager.LoadSceneAsync(0);
    } 
    
}
