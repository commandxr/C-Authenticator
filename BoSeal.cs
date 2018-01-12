         //Made by Bo
		 //Give credits if you use this
		 //Must have a raw pastebin link with the PC names of the users
		 //If you have a question, feel free to contact me https://www.github.com/comandxr or instagram @commandxr
		 //Don't leech
         private void LoginButton_Click(object sender, EventArgs e)
        {
            string website = "Pastebin link here";
            string auth = (new WebClient()).DownloadString(website.ToString());
            if (auth.Contains(Environment.MachineName))
            {
                MessageBox.Show("You're authenticated!");
                tool tool = new tool();
                tool.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You're not authenticated!");
            }
        }