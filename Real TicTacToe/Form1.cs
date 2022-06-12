namespace Real_TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bttn2nd(object sender, EventArgs e)
        {

        }

        private void bttn3rd(object sender, EventArgs e)
        {

        }

        private void bttnclick(object sender, EventArgs e)
        {
           
          
            
        }
        char symbolPut = 'X';

        


      
           
        
            
        
       

        private void upperbttn1CLICK(object sender, EventArgs e)
        {
            
           
            upperbttn1.Text = symbolPut.ToString();
            if (symbolPut == 'X')
            {
                symbolPut = 'O';
            }
            else
            {
                symbolPut = 'X';
            }



            if (upperbttn1.Enabled == true)
            {
                upperbttn1.Enabled = false;
            }

           
        }

        private void upperbttn2CLICK(object sender, EventArgs e)
        {
            upperbttn2.Text = symbolPut.ToString();
            if (symbolPut == 'X')
            {
                symbolPut = 'O';
            }
            else
            {
                symbolPut = 'X';
            }
            if (upperbttn2.Enabled == true)
            {
                upperbttn2.Enabled = false;
            }
        }

        private void upperbttn3CLICK (object sender, EventArgs e)
        {
            upperbttn3.Text = symbolPut.ToString();
            if (symbolPut == 'X')
            {
                symbolPut = 'O';
            }
            else
            {
                symbolPut = 'X';
            }
            if (upperbttn3.Enabled == true)
            {
                upperbttn3.Enabled = false;
            }
        }

        private void midbttn1CLICK(object sender, EventArgs e)
        {
            midbttn1.Text = symbolPut.ToString();
            if (symbolPut == 'X')
            {
                symbolPut = 'O';
            }
            else
            {
                symbolPut = 'X';
            }
            if (midbttn1.Enabled == true)
            {
                midbttn1.Enabled = false;
            }
        }

        private void midbttn2CLICK(object sender, EventArgs e)
        {
            midbttn2.Text = symbolPut.ToString();
            if (symbolPut == 'X')
            {
                symbolPut = 'O';
            }
            else
            {
                symbolPut = 'X';
            }
            if (midbttn2.Enabled == true)
            {
                midbttn2.Enabled = false;
            }
        }

        private void midbttn3CLICK(object sender, EventArgs e)
        {
            midbttn3.Text = symbolPut.ToString();
            if (symbolPut == 'X')
            {
                symbolPut = 'O';
            }
            else
            {
                symbolPut = 'X';
            }
            if (midbttn3.Enabled == true)
            {
                midbttn3.Enabled = false;
            }
        }

        private void lowerbttn1CLICK(object sender, EventArgs e)
        {
            lowerbttn1.Text = symbolPut.ToString();
            if(symbolPut == 'X')
            {
                symbolPut = 'O';
            }
            else
            {
                symbolPut = 'X';
            }



            if (lowerbttn1.Enabled == true)
            {
                lowerbttn1.Enabled = false;
            }
        }

        private void lowerbttn2CLICK(object sender, EventArgs e)
        {
            lowerbttn2.Text = symbolPut.ToString();
            if (symbolPut == 'X')
            {
                symbolPut = 'O';
            }
            else
            {
                symbolPut = 'X';
            }
            if (lowerbttn2.Enabled == true)
            {
                lowerbttn2.Enabled = false;
            }
        }

        private void lowerbttn3CLICK(object sender, EventArgs e)
        {
            lowerbttn3.Text = symbolPut.ToString();
            if (symbolPut == 'X')
            {
                symbolPut = 'O';
            }
            else
            {
                symbolPut = 'X';
            }
            if (lowerbttn3.Enabled == true)
            {
                lowerbttn3.Enabled = false;
            }
        }
    }

     
}