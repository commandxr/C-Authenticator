using System.Net;
//<summary>
//Made by Bo
//Give credits if you use this
//Must have a raw pastebin link with the PC names of the users
//If you have a question, feel free to contact me https://www.github.com/comandxr or instagram @commandxr
//Version 1.0
//</summary>

#region Authenticator
private void Button_Click(object sender, EventArgs e)
        {
            //Copy and Paste this code:
            string website = "Pastebin link here";
            string auth = (new WebClient()).DownloadString(website.ToString());
            if (auth.Contains(Environment.MachineName))
            {
                MessageBox.Show("You're authenticated!");
                Form().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You're not authenticated!");
            }
            //End of code
        }
#endregion