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
        //above = accidentally clicked functions that i cannot remove or my program will crash
        char symbolPut = 'X';
        int tie = 0;
        

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

                                               //winner section
            //horizontal
            if (upperbttn1.Text == upperbttn2.Text && upperbttn2.Text == upperbttn3.Text)
            {
                MessageBox.Show(upperbttn1.Text + " won!");
                this.Close();
             
            }
            //vertical 
            if (upperbttn1.Text == midbttn1.Text && midbttn1.Text == lowerbttn1.Text)
            {
                MessageBox.Show(upperbttn1.Text + " won!");
                this.Close();
            }
            //diagonal
            if (upperbttn1.Text == midbttn2.Text && midbttn2.Text == lowerbttn3.Text)
            {
                MessageBox.Show(upperbttn1.Text + " won!");
                this.Close();
            }

            //disable button after click
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
                                          //winner section
            //horizontal
            if (upperbttn1.Text == upperbttn2.Text && upperbttn2.Text == upperbttn3.Text)
            {
                MessageBox.Show(upperbttn1.Text + " won!");
                this.Close();


            }
            if (upperbttn2.Text == midbttn2.Text && midbttn2.Text == lowerbttn2.Text)
            {
                MessageBox.Show(upperbttn2.Text + " won!");
                this.Close();
            }
           
          
            

            //disable button
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
                                                 //winner
            if (upperbttn1.Text == upperbttn2.Text && upperbttn2.Text == upperbttn3.Text)
            {
                MessageBox.Show(upperbttn1.Text + " won!");
                this.Close();

            }
            if (upperbttn3.Text == midbttn3.Text && midbttn3.Text == lowerbttn3.Text)
            {
                MessageBox.Show(upperbttn3.Text + " won!");
                this.Close();

            }
            //diagonal
            if (upperbttn3.Text == midbttn2.Text && midbttn2.Text == lowerbttn1.Text)
            {
                MessageBox.Show(upperbttn1.Text + " won!");
                this.Close();
            }
           

            //disable buttons
            if (upperbttn3.Enabled == true)
            {
                upperbttn3.Enabled = false;
            }
           
        }//upperbuttons^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

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
                                             //winner section
            //horizontal
            if (midbttn1.Text == midbttn2.Text && midbttn2.Text == midbttn3.Text)
            {
                MessageBox.Show(midbttn1.Text + " won!");
                this.Close();

            }
            //vertical 
            if (upperbttn1.Text == midbttn1.Text && midbttn1.Text == lowerbttn1.Text)
            {
                MessageBox.Show(upperbttn1.Text + " won!");
                this.Close();
            }
           
            //button disabler
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
            //winner section
            //horizontal
            if (midbttn1.Text == midbttn2.Text && midbttn2.Text == midbttn3.Text)
            {
                MessageBox.Show(midbttn1.Text + " won!");
                this.Close();

            }
            //vertical
            if (upperbttn2.Text == midbttn2.Text && midbttn2.Text == lowerbttn2.Text)
            {
                MessageBox.Show(upperbttn2.Text + " won!");
                this.Close();
            }
            //diagonal
            if (upperbttn1.Text == midbttn2.Text && midbttn2.Text == lowerbttn3.Text)
            {
                MessageBox.Show(upperbttn1.Text + " won!");
                this.Close();
            }
            //diagonal
            if (upperbttn3.Text == midbttn2.Text && midbttn2.Text == lowerbttn1.Text)
            {
                MessageBox.Show(upperbttn1.Text + " won!");
                this.Close();
            }
           
            //button disabler
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
            //winner section
            //horizontal
            if (midbttn1.Text == midbttn2.Text && midbttn2.Text == midbttn3.Text)
            {
                MessageBox.Show(midbttn1.Text + " won!");
                this.Close();

            }
            if (upperbttn3.Text == midbttn3.Text && midbttn3.Text == lowerbttn3.Text)
            {
                MessageBox.Show(upperbttn3.Text + " won!");
                this.Close();

            }
            
            //button disabler
            if (midbttn3.Enabled == true)
            {
                midbttn3.Enabled = false;
            }
          
        }
        //midbuttons^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
            //winner section
            //horizontal
            if (lowerbttn1.Text == lowerbttn2.Text && lowerbttn2.Text == lowerbttn3.Text)
            {
                MessageBox.Show(lowerbttn1.Text + " won!");
                this.Close();

            }
            //vertical 
            if (upperbttn1.Text == midbttn1.Text && midbttn1.Text == lowerbttn1.Text)
            {
                MessageBox.Show(upperbttn1.Text + " won!");
                this.Close();
            }
            //diagonal
            if (upperbttn3.Text == midbttn2.Text && midbttn2.Text == lowerbttn1.Text)
            {
                MessageBox.Show(upperbttn1.Text + " won!");
                this.Close();
            }
            
            //button disabler



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

            }            //winner section
            //horizontal
            if (lowerbttn1.Text == lowerbttn2.Text && lowerbttn2.Text == lowerbttn3.Text)
            {
                MessageBox.Show(lowerbttn1.Text + " won!");
                this.Close();

            }
            //vertical
            if (upperbttn2.Text == midbttn2.Text && midbttn2.Text == lowerbttn2.Text)
            {
                MessageBox.Show(upperbttn2.Text + " won!");
                this.Close();
            }
            
            //button disabler

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
                                                 //winner section
            //horizontal
            if (lowerbttn1.Text == lowerbttn2.Text && lowerbttn2.Text == lowerbttn3.Text)
            {
                MessageBox.Show(lowerbttn1.Text + " won!");
                this.Close();

            }
            //vertical 
            if (upperbttn3.Text == midbttn3.Text && midbttn3.Text == lowerbttn3.Text)
            {
                MessageBox.Show(upperbttn3.Text + " won!");
                this.Close();

            } //diagonal
            if (upperbttn1.Text == midbttn2.Text && midbttn2.Text == lowerbttn3.Text)
            {
                MessageBox.Show(upperbttn1.Text + " won!");
                this.Close();
            }
            //button disabler
            if (lowerbttn3.Enabled == true)
            {
                lowerbttn3.Enabled = false;
            }
            
        } 
                
            
        }
}

    
