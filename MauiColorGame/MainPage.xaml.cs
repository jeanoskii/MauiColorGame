namespace MauiColorGame;

public partial class MainPage : ContentPage
{
	public string[] colorsArray = { "#FF0000", "#0000FF", "#FFFFFF", "#FFC0CB", "#008000", "#FFFF00" };

	public MainPage()
	{
		InitializeComponent();
	}

    private async void btnRoll_Clicked(object sender, EventArgs e)
    {
        // assign random color to BoxViews from colorsArray
		Random rand = new Random();
		bvCube1.Color = Color.Parse(colorsArray[rand.Next(0, 6)]);
        bvCube2.Color = Color.Parse(colorsArray[rand.Next(0, 6)]);
        bvCube3.Color = Color.Parse(colorsArray[rand.Next(0, 6)]);

        int winnings = CalculateWinnings();
        if (winnings > 0)
        {
            await DisplayAlert("Winner!", "You won Php " + winnings, "OK");
            ClearBets();
        }
    }

    private void stprBet_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		lblBetAmount.Text = stprBet.Value.ToString();
    }

    private void btnBet_Clicked(object sender, EventArgs e)
    {
        //shared event handler for bet buttons
        var button = (Button)sender;
        var classId = button.ClassId;
        int.TryParse(lblBetAmount.Text, out int betAmount);
        int.TryParse(button.Text, out int currentBet);
        int newBet = betAmount + currentBet;
        button.Text = newBet.ToString();
    }

    private int CalculateWinnings()
    {
        //function could be better optimized to implement D.R.Y.
        int winnings = 0;
        switch (bvCube1.Color.ToHex())
        {
            case "#FF0000":
                winnings = winnings + int.Parse(btnBetRed.Text);
                break;
            case "#0000FF":
                winnings = winnings + int.Parse(btnBetBlue.Text);
                break;
            case "#FFFFFF":
                winnings = winnings + int.Parse(btnBetWhite.Text);
                break;
            case "#FFC0CB":
                winnings = winnings + int.Parse(btnBetPink.Text);
                break;
            case "#008000":
                winnings = winnings + int.Parse(btnBetGreen.Text);
                break;
            case "#FFFF00":
                winnings = winnings + int.Parse(btnBetYellow.Text);
                break;
        }
        switch (bvCube2.Color.ToHex())
        {
            case "#FF0000":
                winnings = winnings + int.Parse(btnBetRed.Text);
                break;
            case "#0000FF":
                winnings = winnings + int.Parse(btnBetBlue.Text);
                break;
            case "#FFFFFF":
                winnings = winnings + int.Parse(btnBetWhite.Text);
                break;
            case "#FFC0CB":
                winnings = winnings + int.Parse(btnBetPink.Text);
                break;
            case "#008000":
                winnings = winnings + int.Parse(btnBetGreen.Text);
                break;
            case "#FFFF00":
                winnings = winnings + int.Parse(btnBetYellow.Text);
                break;
        }
        switch (bvCube3.Color.ToHex())
        {
            case "#FF0000":
                winnings = winnings + int.Parse(btnBetRed.Text);
                break;
            case "#0000FF":
                winnings = winnings + int.Parse(btnBetBlue.Text);
                break;
            case "#FFFFFF":
                winnings = winnings + int.Parse(btnBetWhite.Text);
                break;
            case "#FFC0CB":
                winnings = winnings + int.Parse(btnBetPink.Text);
                break;
            case "#008000":
                winnings = winnings + int.Parse(btnBetGreen.Text);
                break;
            case "#FFFF00":
                winnings = winnings + int.Parse(btnBetYellow.Text);
                break;
        }
        return winnings;
    }

    private void btnClearBet_Clicked(object sender, EventArgs e)
    {
        ClearBets();
    }

    private void ClearBets()
    {
        btnBetRed.Text = "0";
        btnBetWhite.Text = "0";
        btnBetYellow.Text = "0";
        btnBetBlue.Text = "0";
        btnBetGreen.Text = "0";
        btnBetPink.Text = "0";
    }
}