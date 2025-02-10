namespace TapGestureExample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        

        public MainPage()
        {
            InitializeComponent();
        }
        string choice = "Male";
        double weight = 0;
        double height = 0;
        private void TapMale_Tapped(object sender, TappedEventArgs e)
        {
            choice = "Male";
            FrameMale.BorderColor = Color.FromArgb("#0a0e29");
            FrameFemale.BorderColor = Color.FromArgb("#fdfdfd");
        }

        private void TapFemale_Tapped(object sender, TappedEventArgs e)
        {
            choice = "Female";
            FrameFemale.BorderColor = Color.FromArgb("#0a0e29");
            FrameMale.BorderColor = Color.FromArgb("#fdfdfd");
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            height = HeightSlider.Value;
            weight= WeightSlider.Value;
            Double BMI = (weight * 703) / (height * height);

            if (BMI < 18.5 && choice == "Male")
            {
                DisplayAlert("Your BMI is:" + "_" + BMI + ", which is underweight", "" +
                    "Increase calorie intak with nutrient-rich foods. Inorporate strength training to build muscle mass. Consult a nutritionist if needed.", "Ok");
            }

            if (24 > BMI && BMI >= 18.5 && choice == "Male")
            {
                DisplayAlert("Your BMI is:" + "_" + BMI + ", which is normal weight", "Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of excercise per week. Keep regular check ups to monitor overall health.", "Ok");
            }

            if (29 > BMI && BMI >= 24 && choice == "Male")
            {
                DisplayAlert("Your BMI is:" + "_" + BMI + ", which is overweight.", "Reduce processed foods and focus on portion control. Engage in regular physical exercise and strength training. Drink plenty of water and track your progress.", "Ok");
            }

            if (BMI >= 29 && choice == "Male")
            {
                DisplayAlert("Your BMI is:" + "_" + BMI + ", which is obese.", "Consult a doctor for personalized guidance. Start with low-impact exercises. Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary drinks and maintain a consistent sleep schedule.", "Ok");
            }

            if (BMI < 18 && choice == "Female")
            {
                DisplayAlert("Your BMI is:" + " " + BMI + ", which is underweight", "" +
                    "Increase calorie intak with nutrient-rich foods. Inorporate strength training to build muscle mass. Consult a nutritionist if needed.", "Ok");
            }
           

            if (BMI > 24 && BMI >= 18 && choice == "Female") { DisplayAlert("Your BMI is:" + "_" + BMI + ", which is normal weight", "Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of excercise per week. Keep regular check ups to monitor overall health.", "Ok"); }
           

            if (BMI >= 24 && BMI < 29  && choice == "Female") { DisplayAlert("Your BMI is:" + "_" + BMI + ", which is overweight.", "Reduce processed foods and focus on portion control. Engage in regular physical exercise and strength training. Drink plenty of water and track your progress.", "Ok"); }
           

            if (BMI >= 29 && choice == "Female") { DisplayAlert("Your BMI is:" + "_" + BMI + ", which is obese.", "Consult a doctor for personalized guidance. Start with low-impact exercises. Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary drinks and maintain a consistent sleep schedule.", "Ok");  }
           
        }
    }
}


