namespace BMI;

public partial class BMI : ContentPage
{
    public BMI()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Parse user input for weight and height
        if (double.TryParse(WeightEntry.Text, out double weight) &&
            double.TryParse(HeightEntry.Text, out double height))
        {
            if (height > 0)
            {
                // Calculate BMI
                double bmi = weight / (height * height);

                // Display the result in the BMIResultLabel
                BMIResultLabel.Text = $"Your BMI is {bmi:F2}";

                // Optionally, add a BMI category message based on the calculated BMI
                if (bmi < 18.5)
                {
                    BMIResultLabel.Text += "\nCategory: Underweight";
                }
                else if (bmi >= 18.5 && bmi < 24.9)
                {
                    BMIResultLabel.Text += "\nCategory: Normal weight";
                }
                else if (bmi >= 25 && bmi < 29.9)
                {
                    BMIResultLabel.Text += "\nCategory: Overweight";
                }
                else
                {
                    BMIResultLabel.Text += "\nCategory: Obesity";
                }
            }
            else
            {
                // Display error for invalid height
                BMIResultLabel.Text = "Height must be greater than zero.";
            }
        }
        else
        {
            // Display error if parsing fails
            BMIResultLabel.Text = "Please enter valid numeric values for weight and height.";
        }
    }
}
