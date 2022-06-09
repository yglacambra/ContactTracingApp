namespace ContactTracingApp
{
    public partial class ContactTracingAppForm : Form
    {
        public ContactTracingAppForm()
        {
            InitializeComponent();
        }

        private void BtnMonthVisited_Click(object sender, EventArgs e)
        {
            byte MonthVisited = 1;
            if (BtnMonthVisited.Text == "January")
            {
                BtnMonthVisited.Text = "February";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "February")
            {
                BtnMonthVisited.Text = "March";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "March")
            {
                BtnMonthVisited.Text = "April";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "April")
            {
                BtnMonthVisited.Text = "May";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "May")
            {
                BtnMonthVisited.Text = "June";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "June")
            {
                BtnMonthVisited.Text = "July";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "July")
            {
                BtnMonthVisited.Text = "August";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "August")
            {
                BtnMonthVisited.Text = "September";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "September")
            {
                BtnMonthVisited.Text = "October";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "October")
            {
                BtnMonthVisited.Text = "November";
                ++MonthVisited;
            }
            else if (BtnMonthVisited.Text == "November")
            {
                BtnMonthVisited.Text = "December";
                ++MonthVisited;
            }
            else
            {
                BtnMonthVisited.Text = "January";
                ++MonthVisited;
            }
        }
    }
}