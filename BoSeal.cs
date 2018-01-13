using System.Net;

//<summary>
//Made by Bo.
//Give credits if you use this.
//This is only for the C# Language.
//PC Names are specific.
//Must have a raw pastebin link with the PC names of the users.
//If you have a question, feel free to contact me https://www.github.com/comandxr or instagram @commandxr.
//Version 1.0.
//</summary>

#region Authenticator
public void Auth()
{
    //Copy and Paste this code:
    //You can either put this inside a button to login, or put it under initialize component to see if the users PC name is authenticated when they open the tool.
    string seal = "Pastebin Link";
    string auth = (new WebClient()).DownloadString(seal.ToString());
    //Checks to see if the users PC name is inside the pastebin link.
    if (auth.Contains(Environment.MachineName))
    {
        //If the users PC name is inside the pastebin, it will show as "authenticated".
        MessageBox.Show("You're authenticated!");
        //When the PC is authenticated, the new form will show.
        Tool().Show();
        this.Hide();
    }
    else
    {
        //If the users PC name is not inside the pastebin, it will show as "not authenticated".
        MessageBox.Show("You're not authenticated!");
    }
    //End of code
}
#endregion