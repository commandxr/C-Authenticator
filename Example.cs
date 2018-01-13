using System.Net;

//Example from Bo
private void Auth()
        {
            string website = "https://pastebin.com/raw/iEybt0TJ";
            string auth = (new WebClient()).DownloadString(website.ToString());
            if (auth.Contains(Environment.MachineName))
            {
                MessageBox.Show("You're authenticated!");
                Tool().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You're not authenticated!");
            }
        }