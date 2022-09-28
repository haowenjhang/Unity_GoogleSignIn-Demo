using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public Button GoogleSignInBtn;
    public Button GoogleSignOutBtn;

    public Text Log;



    public void GoogleSign()
    {
        Log.text = "";

        using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            using (AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity"))
            {
                jo.Call("signIn");
            }
        }
    }

    public void GoogleSignOut()
    {
        Log.text = "";

        using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            using (AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity"))
            {
                jo.Call("signOut");
            }
        }
    }

    public void GetInfo(string str)
    {
        Log.text = str;
    }

}



